using IO.Swagger.Model;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
//using System.Text.Json;
using System.Threading.Tasks;

// Netwonsoft.Json
// var data = new StringContent(JsonConvert.SerializeObject(shape), Encoding.UTF8, "application/json");
// result = JsonConvert.DeserializeObject<ShapeItem>(content);

// System.Text.Json
// var data = new StringContent(JsonSerializer.Serialize(shape), Encoding.UTF8, "application/json");
// result = JsonSerializer.Deserialize<ShapeItem>(content);
// var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

namespace Miro.API
{
    internal class MiroAPI
    {
        HttpClient _httpClient;

        IConfiguration _configuration;

        string _miroBaseUrl = "";

        string _miroAccessToken = "";

        int _timeout = 10000; // ms

        // System.Text.Json
        //JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public MiroAPI(IConfiguration configuration)
        {
            _configuration = configuration;

            _miroBaseUrl = _configuration["Miro:BaseUrl"];
            _miroAccessToken = _configuration["Miro:AccessToken"];

            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(_miroBaseUrl + (_miroBaseUrl.EndsWith("/") ? "" : "/")),
                Timeout = new TimeSpan(0, 0, _timeout)
            };
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.ConnectionClose = true;
        }

        void SetHeader(bool authorization = true)
        {
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            if (authorization)
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _miroAccessToken);
            }
        }

        #region Boards

        public async Task<List<Board>> GetBoards()
        {
            var result = new List<Board>();

            SetHeader();

            var response = await _httpClient.GetAsync("boards");
            var content = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                var responseContent = JsonConvert.DeserializeObject<BoardsPagedResponse>(content);
                //var responseContent = JsonSerializer.Deserialize<BoardsPagedResponse>(content, _jsonSerializerOptions);
                result = responseContent.Data;
            }
            else
            {
                throw new Exception(content);
            }

            return result;
        }

        public async Task<BoardWithLinks> CreateBoard(BoardChanges board)
        {
            BoardWithLinks result = null;

            SetHeader();

            var data = new StringContent(JsonConvert.SerializeObject(board), Encoding.UTF8, "application/json");
            //var data = new StringContent(JsonSerializer.Serialize(board), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"boards", data);
            var content = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                result = JsonConvert.DeserializeObject<BoardWithLinks>(content);
                //result = JsonSerializer.Deserialize<BoardWithLinks>(content, _jsonSerializerOptions);
            }
            else
            {
                throw new Exception(content);
            }

            return result;
        }

        public async Task<List<GenericItem>> GetBoardItems(string boardId)
        {
            var result = new List<GenericItem>();

            SetHeader();

            var response = await _httpClient.GetAsync($"boards/{boardId}/items");
            var content = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                var responseContent = JsonConvert.DeserializeObject<GenericItemCursorPaged>(content);
                //var responseContent = JsonSerializer.Deserialize<GenericItemCursorPaged>(content, _jsonSerializerOptions);
                result = responseContent.Data;
            }
            else
            {
                throw new Exception(content);
            }

            return result;
        }

        public async Task<ShapeItem> CreateBoardShape(string boardId, ShapeCreateRequest shape)
        {
            ShapeItem result = null;

            SetHeader();

            var data = new StringContent(JsonConvert.SerializeObject(shape), Encoding.UTF8, "application/json");
            //var data = new StringContent(JsonSerializer.Serialize(shape), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"boards/{boardId}/shapes", data);
            var content = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                result = JsonConvert.DeserializeObject<ShapeItem>(content);
                //result = JsonSerializer.Deserialize<ShapeItem>(content, _jsonSerializerOptions);
            }
            else
            {
                throw new Exception(content);
            }

            return result;
        }

        public async Task<ConnectorWithLinks> CreateBoardConnector(string boardId, ConnectorCreationData connector)
        {
            ConnectorWithLinks result = null;

            SetHeader();

            var data = new StringContent(JsonConvert.SerializeObject(connector), Encoding.UTF8, "application/json");
            //var data = new StringContent(JsonSerializer.Serialize(connector), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"boards/{boardId}/connectors", data);
            var content = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                result = JsonConvert.DeserializeObject<ConnectorWithLinks>(content);
                //result = JsonSerializer.Deserialize<ConnectorWithLinks>(content, _jsonSerializerOptions);
            }
            else
            {
                throw new Exception(content);
            }

            return result;
        }

        #endregion Boards
    }
}
