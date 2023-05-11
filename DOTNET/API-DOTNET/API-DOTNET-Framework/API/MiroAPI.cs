using IO.Swagger.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;

namespace Miro.API
{
    internal class MiroAPI
    {
        string _miroBaseUrl = ConfigurationManager.AppSettings.Get("Miro.BaseUrl");

        string _miroAccessToken = ConfigurationManager.AppSettings.Get("Miro.AccessToken");

        RestClient _restClient;

        int _timeout = 10000; // ms

        public MiroAPI()
        {
            var options = new RestClientOptions
            {
                BaseUrl = new Uri(_miroBaseUrl),
                MaxTimeout = _timeout
            };
            _restClient = new RestClient(options);
        }

        void SetHeader(RestRequest request)
        {
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", $"Bearer {_miroAccessToken}");
        }

        #region Boards

        public List<Board> GetBoards()
        {
            var result = new List<Board>();

            var request = new RestRequest("boards", Method.Get);
            SetHeader(request);

            var response = _restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var responseContent = JsonConvert.DeserializeObject<BoardsPagedResponse>(response.Content);
                result = responseContent.Data;
            }
            else
            {
                throw response.ErrorException;
            }

            return result;
        }

        public BoardWithLinks CreateBoard(BoardChanges board)
        {
            BoardWithLinks result = null;

            var request = new RestRequest("boards", Method.Post);
            SetHeader(request);
            request.AddJsonBody(board);

            var response = _restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.Created)
            {
                result = JsonConvert.DeserializeObject<BoardWithLinks>(response.Content);
            }
            else
            {
                throw response.ErrorException;
            }

            return result;
        }

        public List<GenericItem> GetBoardItems(string boardId)
        {
            var result = new List<GenericItem>();

            var request = new RestRequest($"boards/{boardId}/items", Method.Get);
            SetHeader(request);

            var response = _restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var responseContent = JsonConvert.DeserializeObject<GenericItemCursorPaged>(response.Content);
                result = responseContent.Data;
            }
            else
            {
                throw response.ErrorException;
            }

            return result;
        }

        public ShapeItem CreateBoardShape(string boardId, ShapeCreateRequest shape)
        {
            ShapeItem result = null;

            var request = new RestRequest($"boards/{boardId}/shapes", Method.Post);
            SetHeader(request);
            request.AddJsonBody(shape);

            var response = _restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.Created
                || response.StatusCode == HttpStatusCode.OK)
            {
                result = JsonConvert.DeserializeObject<ShapeItem>(response.Content);
            }
            else
            {
                throw response.ErrorException;
            }

            return result;
        }

        public ConnectorWithLinks CreateBoardConnector(string boardId, ConnectorCreationData connector)
        {
            ConnectorWithLinks result = null;

            var request = new RestRequest($"boards/{boardId}/connectors", Method.Post);
            SetHeader(request);
            request.AddJsonBody(connector);

            var response = _restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.Created
                || response.StatusCode == HttpStatusCode.OK)
            {
                result = JsonConvert.DeserializeObject<ConnectorWithLinks>(response.Content);
            }
            else
            {
                throw response.ErrorException;
            }

            return result;
        }

        #endregion Boards
    }
}
