using IO.Swagger.Model;
using Miro.API;
using System;
using System.Threading;

namespace API_DOTNET_Framework
{
    internal class Program
    {
        static MiroAPI _miroAPI;

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

            _miroAPI = new MiroAPI();

            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Miro API Client : .NET Framework 4.8 + RestSharp\n");
                Console.WriteLine("<1> Get Boards");
                Console.WriteLine("<2> Create Board");
                Console.WriteLine("<3> Get Board Items");
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
                        GetBoards();
                        break;

                    case ('2'):
                        CreateBoard();
                        break;

                    case ('3'):
                        {
                            GetBoards();
                            Console.Write("\nBoard Id ? ");
                            string boardId = Console.ReadLine();
                            GetBoardItems(boardId);
                        }
                        break;

                    case ('4'):
                        {
                            GetBoards();
                            Console.Write("\nBoard Id ? ");
                            string boardId = Console.ReadLine();
                            CreateBoardShapesConnectors(boardId);
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

        static void GetBoards()
        {
            try
            {
                var response = _miroAPI.GetBoards();

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

        static void CreateBoard()
        {
            try
            {
                var board = new BoardChanges("Board Description", "Board Name");
                var response = _miroAPI.CreateBoard(board);

                Log("\nBoard");
                Log("Id: {0}", response.Id);
            }
            catch (Exception exception)
            {
                Log(exception);
            }
        }

        static void GetBoardItems(string boardId)
        {
            try
            {
                var response = _miroAPI.GetBoardItems(boardId);

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

        static void CreateBoardShapesConnectors(string boardId)
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
                var shape1 = _miroAPI.CreateBoardShape(boardId, shape);

                shape.Position.X = 100;
                shape.Data.Shape = ShapeData.ShapeEnum.Circle;
                var shape2 = _miroAPI.CreateBoardShape(boardId, shape);

                shape.Position.X = 0;
                shape.Position.Y = 150;
                shape.Data.Shape = ShapeData.ShapeEnum.Triangle;
                var shape3 = _miroAPI.CreateBoardShape(boardId, shape);

                Log("\nShapes");
                Log("Id: {0} Type: {1}", shape1.Id, shape1.Type);
                Log("Id: {0} Type: {1}", shape2.Id, shape2.Type);
                Log("Id: {0} Type: {1}", shape3.Id, shape3.Type);

                var connectorCreationData12 = new ConnectorCreationData(new ItemConnectionCreationData(shape1.Id?.ToString()),
                    new ItemConnectionCreationData(shape2.Id?.ToString()));
                var connector12 = _miroAPI.CreateBoardConnector(boardId, connectorCreationData12);

                var connectorCreationData23 = new ConnectorCreationData(new ItemConnectionCreationData(shape2.Id?.ToString()),
                    new ItemConnectionCreationData(shape3.Id?.ToString()));
                var connector23 = _miroAPI.CreateBoardConnector(boardId, connectorCreationData23);

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
