using FisioOnlineReports.EndPoints;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FisioOnlineReports.Service
{
    public class HttpRequester
    {
        private readonly HttpClient _client;

        public HttpRequester()
        {
            _client = new HttpClient();
        }

        public async Task<(string, HttpResponseMessage)> SendGetRequestAsync(string url, string queryParams = null, string headers = null)
        {
            try
            {
                if (!string.IsNullOrEmpty(queryParams))
                {
                    url = $"{url}?{queryParams}";
                }

                if (!string.IsNullOrEmpty(headers))
                {
                    _client.DefaultRequestHeaders.Add("Custom-Header", headers);
                }

                HttpResponseMessage response = await _client.GetAsync(ApiFisio.UrlBase() + url);
                response.EnsureSuccessStatusCode();

                string content = await response.Content.ReadAsStringAsync();
                return (content, response);
            }
            catch (Exception ex)
            {
                return ($"Erro na requisição GET: {ex.Message}", null);
            }
        }

        public async Task<(string, HttpResponseMessage)> SendPostRequestAsync(string url, string jsonData, string headers = null)
        {
            try
            {
                if (!string.IsNullOrEmpty(headers))
                {
                    _client.DefaultRequestHeaders.Add("Custom-Header", headers);
                }

                StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _client.PostAsync(ApiFisio.UrlBase() + url, content);
                response.EnsureSuccessStatusCode();

                string responseContent = await response.Content.ReadAsStringAsync();
                return (responseContent, response);
            }
            catch (Exception ex)
            {
                return ($"Erro na requisição POST: {ex.Message}", null);
            }
        }

        public async Task<(string, HttpResponseMessage)> SendPutRequestAsync(string url, string jsonData, string headers = null)
        {
            try
            {
                if (!string.IsNullOrEmpty(headers))
                {
                    _client.DefaultRequestHeaders.Add("Custom-Header", headers);
                }

                StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _client.PutAsync(url, content);
                response.EnsureSuccessStatusCode();

                string responseContent = await response.Content.ReadAsStringAsync();
                return (responseContent, response);
            }
            catch (Exception ex)
            {
                return ($"Erro na requisição PUT: {ex.Message}", null);
            }
        }

        public async Task<(string, HttpResponseMessage)> SendDeleteRequestAsync(string url, string headers = null)
        {
            try
            {
                if (!string.IsNullOrEmpty(headers))
                {
                    _client.DefaultRequestHeaders.Add("Custom-Header", headers);
                }

                HttpResponseMessage response = await _client.DeleteAsync(url);
                response.EnsureSuccessStatusCode();

                string content = await response.Content.ReadAsStringAsync();
                return (content, response);
            }
            catch (Exception ex)
            {
                return ($"Erro na requisição DELETE: {ex.Message}", null);
            }
        }
    }
}
