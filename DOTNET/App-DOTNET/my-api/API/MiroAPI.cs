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
        #region static

        public static string AccessToken;

        public static string RefreshToken;

        public static DateTime ExpireDateTime;

        public static string TeamId;

        #endregion static

        #region Fields

        HttpClient _httpClient;

        IConfiguration _configuration;

        string _miroBaseUrl = "";

        int _timeout = 10000; // ms

        #endregion Fields

        // System.Text.Json
        //JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        #region Methods

        public MiroAPI(IConfiguration configuration)
        {
            _configuration = configuration;

            _miroBaseUrl = _configuration["Miro:BaseUrl"];

            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(_miroBaseUrl + (_miroBaseUrl.EndsWith("/") ? "" : "/")),
                Timeout = new TimeSpan(0, 0, _timeout)
            };
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.ConnectionClose = true;
        }

        async Task SetHeader(bool authorization = true)
        {
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            if (authorization)
            {
                string accessToken = await OAuthGetAccessToken() ?? "";
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            }
        }

        #endregion Methods

        #region OAuth

        public async Task<OAuthToken> OAuthToken(string authorizationCode)
        {
            OAuthToken result = null;

            await SetHeader();

            var redirectUri = _configuration["Miro:RedirectUri"];
            var clientId = _configuration["Miro:ClientId"];
            var clientSecret = _configuration["Miro:ClientSecret"];
            var response = await _httpClient.PostAsync("https://api.miro.com/v1/oauth/token?" +
                "grant_type=authorization_code" +
                $"&client_id={clientId}" +
                $"&client_secret={clientSecret}" + 
                $"&code={authorizationCode}" +
                $"&redirect_uri={redirectUri}",
                null);
            var content = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                result = JsonConvert.DeserializeObject<OAuthToken>(content);
                OAuthSaveToken(result);
            }
            else
            {
                throw new Exception(content);
            }

            return result;
        }

        public async Task<OAuthToken> OAuthRefresh()
        {
            OAuthToken result = null;

            await SetHeader();

            var clientId = _configuration["Miro:ClientId"];
            var clientSecret = _configuration["Miro:ClientSecret"];
            var refreshToken = MiroAPI.RefreshToken;

            var response = await _httpClient.PostAsync("https://api.miro.com/v1/oauth/token?" +
                "grant_type=refresh_token" +
                $"&client_id={clientId}" +
                $"&client_secret={clientSecret}" +
                $"&refresh_token={refreshToken}",
                null);
            var content = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                result = JsonConvert.DeserializeObject<OAuthToken>(content);
                OAuthSaveToken(result);
            }
            else
            {
                throw new Exception(content);
            }

            return result;
        }

        async Task<string> OAuthGetAccessToken()
        {
            var accessToken = MiroAPI.AccessToken;
            var expireDateTime = MiroAPI.ExpireDateTime;
            if (!string.IsNullOrEmpty(accessToken)
                && (expireDateTime - DateTime.Now).TotalSeconds < 60)
            {
                await OAuthRefresh();
                accessToken = MiroAPI.AccessToken;
            }

            return accessToken;
        }

        void OAuthSaveToken(OAuthToken token)
        {
            MiroAPI.AccessToken = token.access_token;
            MiroAPI.RefreshToken = token.refresh_token;
            MiroAPI.ExpireDateTime = token.ExpireDateTime ?? DateTime.Now;
            MiroAPI.TeamId = token.team_id;
        }

        #endregion OAuth

        #region Boards

        public async Task<List<Board>> GetBoards()
        {
            var result = new List<Board>();

            await SetHeader();

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

            await SetHeader();

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

            await SetHeader();

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

            await SetHeader();

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

            await SetHeader();

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
