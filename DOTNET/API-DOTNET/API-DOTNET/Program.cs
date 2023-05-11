using EasyLOB.Shell;
using IO.Swagger.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Miro.API;
using System;
using System.Threading.Tasks;

// API-DOTNET.csproj
// <ImplicitUsings>enable</ImplicitUsings> -> disable
// <Nullable>enable</Nullable> -> disable

namespace API_DOTNET
{
    internal class Program
    {
        static IConfiguration _configuration;

        static MiroAPI _miroAPI;

        static void Main(string[] args)
        {
            IServiceProvider serviceProvider = StartupCore.Startup();
            _configuration = serviceProvider.GetService<IConfiguration>();
            _miroAPI = new MiroAPI(_configuration);

            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Miro API Client : .NET 6.0 + HttpClient\n");
                Console.WriteLine("<1> Get Boards");
                Console.WriteLine("<2> Create Board");
                Console.WriteLine("<3> Get Board Members");
                Console.WriteLine("<4> Create Board Shapes and Connectors");
                Console.WriteLine("\n<X> EXIT");

                Console.Write("\nChoose an option... ");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine();

                switch (Char.ToUpper(key.KeyChar))
                {
                    case ('X'):
                        exit = true;
                        break;

                    case ('1'):
                        Task.Run(async () => await GetBoards()).Wait();
                        break;

                    case ('2'):
                        Task.Run(async () => await CreateBoard()).Wait();
                        break;

                    case ('3'):
                        {
                            Task.Run(async () => await GetBoards()).Wait();
                            Console.Write("\nBoard Id ? ");
                            string boardId = Console.ReadLine() ?? "";
                            Task.Run(async () => await GetBoardItems(boardId)).Wait();
                        }
                        break;

                    case ('4'):
                        {
                            Task.Run(async () => await GetBoards()).Wait();
                            Console.Write("\nBoard Id ? ");
                            string boardId = Console.ReadLine() ?? "";
                            Task.Run(async () => await CreateBoardShapesConnectors(boardId)).Wait();
                        }
                        break;
                }

                if (!exit)
                {
                    Console.Write("\nPress <KEY> to continue... ");
                    Console.ReadKey();
                }
            }
        }

        #region API Boards

        static async Task GetBoards()
        {
            try
            {
                var response = await _miroAPI.GetBoards();

                Log("\nBoards");
                foreach (var board in response)
                {
                    Log("Id: {0}", board.Id);
                }
            }
            catch (Exception exception)
            {
                Log(exception);
            }
        }

        static async Task CreateBoard()
        {
            try
            {
                var board = new BoardChanges("Board Description", "Board Name");
                var response = await _miroAPI.CreateBoard(board);

                Log("\nBoard");
                Log("Id: {0}", response.Id);
            }
            catch (Exception exception)
            {
                Log(exception);
            }
        }
        static async Task GetBoardItems(string boardId)
        {
            try
            {
                var response = await _miroAPI.GetBoardItems(boardId);

                Log("\nBoard Items");
                foreach (var item in response)
                {
                    Log("Id: {0} Type: {1}", item.Id, item.Type);
                }
            }
            catch (Exception exception)
            {
                Log(exception);
            }
        }

        static async Task CreateBoardShapesConnectors(string boardId)
        {
            try
            {
                var shape = new ShapeCreateRequest
                {
                    Data = new ShapeData
                    {
                        Shape = ShapeData.ShapeEnum.Rectangle
                    },
                    Geometry = new Geometry
                    {
                        Height = 100,
                        Width = 100
                    },
                    Position = new PositionChange
                    {
                        Origin = PositionChange.OriginEnum.Center,
                        X = -100,
                        Y = 0
                    }
                };
                var shape1 = await _miroAPI.CreateBoardShape(boardId, shape);

                shape.Position.X = 100;
                shape.Data.Shape = ShapeData.ShapeEnum.Circle;
                var shape2 = await _miroAPI.CreateBoardShape(boardId, shape);

                shape.Position.X = 0;
                shape.Position.Y = 150;
                shape.Data.Shape = ShapeData.ShapeEnum.Triangle;
                var shape3 = await _miroAPI.CreateBoardShape(boardId, shape);

                Log("\nShapes");
                Log("Id: {0} Type: {1}", shape1.Id, shape1.Type);
                Log("Id: {0} Type: {1}", shape2.Id, shape2.Type);
                Log("Id: {0} Type: {1}", shape3.Id, shape3.Type);

                var connectorCreationData12 = new ConnectorCreationData(new ItemConnectionCreationData(shape1.Id?.ToString()),
                    new ItemConnectionCreationData(shape2.Id?.ToString()));
                var connector12 = await _miroAPI.CreateBoardConnector(boardId, connectorCreationData12);

                var connectorCreationData23 = new ConnectorCreationData(new ItemConnectionCreationData(shape2.Id?.ToString()),
                    new ItemConnectionCreationData(shape3.Id?.ToString()));
                var connector23 = await _miroAPI.CreateBoardConnector(boardId, connectorCreationData23);

                Log("\nConnectors");
                Log("Id: {0}", connector12.Id);
                Log("Id: {0}", connector23.Id);
            }
            catch (Exception exception)
            {
                Log(exception);
            }
        }

        #endregion API Boards

        #region Log

        static void Log(string message)
        {
            Console.WriteLine(message);
        }

        static void Log(string format, params object[] arg)
        {
            Console.WriteLine(format, arg);
        }

        static void Log(Exception exception)
        {
            if (exception != null)
            {
                Console.WriteLine(exception.Message);
                if (exception.InnerException != null)
                {
                    Console.WriteLine(exception.InnerException.Message);
                }
            }
        }

        #endregion Log
    }
}
