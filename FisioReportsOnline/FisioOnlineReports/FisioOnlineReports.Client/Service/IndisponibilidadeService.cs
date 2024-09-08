using FisioOnlineReports.EndPoints;
using FisioOnlineReports.Models;
using FisioOnlineReports.Service;
using FisioOnlineReports.Utils;
using LibFisioOnline.InputModels;
using LibFisioOnline.Models;
using Newtonsoft.Json;

namespace FisioOnlineReports.Client.Service
{
    public class IndisponibilidadeService
    {
        public async Task<List<Indisponibilidade>> ConsultarIndisponibilidades(int ambienteId)
        {
            try
            {
                var http = new HttpRequester();

                var (JsonResposta, CodigoResposta) = await http.SendGetRequestAsync(ApiFisio.Indisponibilidades(ambienteId));

                if (CodigoResposta.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<List<Indisponibilidade>>>(JsonResposta);
                    if (apiResponse != null)
                        return apiResponse.data;
                }

                LogErro.SetLog(JsonResposta, $"Erro {CodigoResposta} - Consultar Indisponibilidade");

                return null;
            }
            catch (Exception ex)
            {
                LogErro.SetLog(ex, "Throw ConsultarIndisponibilidade");
                return null;
            }
        }

        public async Task<List<Indisponibilidade>> ConsultarIndisponibilidades()
        {
            try
            {
                var http = new HttpRequester();

                var (JsonResposta, CodigoResposta) = await http.SendGetRequestAsync(ApiFisio.Indisponibilidades());

                if (CodigoResposta.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<List<Indisponibilidade>>>(JsonResposta);
                    if (apiResponse != null)
                        return apiResponse.data;
                }

                LogErro.SetLog(JsonResposta, $"Erro {CodigoResposta} - Consultar Indisponibilidade");

                return null;
            }
            catch (Exception ex)
            {
                LogErro.SetLog(ex, "Throw ConsultarIndisponibilidade");
                return null;
            }
        }

        public async Task<Indisponibilidade> ConsultarIndisponibilidade(int id)
        {
            try
            {
                var http = new HttpRequester();

                var (JsonResposta, CodigoResposta) = await http.SendGetRequestAsync(ApiFisio.IndisponibilidadeId(id));

                if (CodigoResposta.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<Indisponibilidade>>(JsonResposta);
                    if (apiResponse != null)
                        return apiResponse.data;
                }

                LogErro.SetLog(JsonResposta, $"Erro {CodigoResposta} - Consultar Indisponibilidade");

                return null;
            }
            catch (Exception ex)
            {
                LogErro.SetLog(ex, "Throw ConsultarIndisponibilidade");
                return null;
            }
        }

        public async Task DeleteIndisponibilidade(int id)
        {
            try
            {
                var http = new HttpRequester();

                var (JsonResposta, CodigoResposta) = await http.SendDeleteRequestAsync(ApiFisio.IndisponibilidadeId(id));

                if (CodigoResposta.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<Indisponibilidade>>(JsonResposta);
                    if (apiResponse != null)
                        return;
                }

                LogErro.SetLog(JsonResposta, $"Erro {CodigoResposta} - Consultar Indisponibilidade");

                return;
            }
            catch (Exception ex)
            {
                LogErro.SetLog(ex, "Throw ConsultarIndisponibilidade");
                return;
            }
        }

        public async Task<Indisponibilidade> InserirIndisponibilidade(IndisponibilidadeInputModel IndisponibilidadeInputModel)
        {
            try
            {
                var http = new HttpRequester();

                string jsonString = JsonConvert.SerializeObject(IndisponibilidadeInputModel);


                var (JsonResposta, CodigoResposta) = await http.SendPostRequestAsync(ApiFisio.Indisponibilidades(), jsonString);

                if (CodigoResposta.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<Indisponibilidade>>(JsonResposta);
                    if (apiResponse != null)
                        return apiResponse.data;
                }

                LogErro.SetLog(JsonResposta, $"Erro {CodigoResposta} - Consultar Indisponibilidade");

                return null;
            }
            catch (Exception ex)
            {
                LogErro.SetLog(ex, "Throw ConsultarIndisponibilidade");
                return null;
            }
        }
        public async Task<Indisponibilidade> AtualizarIndisponibilidade(IndisponibilidadeInputModel IndisponibilidadeInputModel)
        {
            try
            {
                var http = new HttpRequester();

                string jsonString = JsonConvert.SerializeObject(IndisponibilidadeInputModel);


                var (JsonResposta, CodigoResposta) = await http.SendPostRequestAsync(ApiFisio.Indisponibilidades(), jsonString);

                if (CodigoResposta.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<Indisponibilidade>>(JsonResposta);
                    if (apiResponse != null)
                        return apiResponse.data;
                }

                LogErro.SetLog(JsonResposta, $"Erro {CodigoResposta} - Consultar Indisponibilidade");

                return null;
            }
            catch (Exception ex)
            {
                LogErro.SetLog(ex, "Throw ConsultarIndisponibilidade");
                return null;
            }
        }

    }
}
