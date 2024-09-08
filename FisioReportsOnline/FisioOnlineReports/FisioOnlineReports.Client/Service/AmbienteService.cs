using FisioOnlineReports.EndPoints;
using FisioOnlineReports.Models;
using FisioOnlineReports.Service;
using FisioOnlineReports.Utils;
using LibFisioOnline.InputModels;
using LibFisioOnline.Models;
using Newtonsoft.Json;

namespace FisioOnlineReports.Client.Service
{
    public class AmbienteService
    {
        public async Task<List<Ambiente>> ConsultarAmbientes()
        {
            try
            {
                var http = new HttpRequester();

                var (JsonResposta, CodigoResposta) = await http.SendGetRequestAsync(ApiFisio.Ambientes());

                if (CodigoResposta.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<List<Ambiente>>>(JsonResposta);
                    if (apiResponse != null)
                        return apiResponse.data;
                }

                LogErro.SetLog(JsonResposta, $"Erro {CodigoResposta} - Consultar Ambiente");

                return null;
            }
            catch (Exception ex)
            {
                LogErro.SetLog(ex, "Throw ConsultarAmbiente");
                return null;
            }
        }

        public async Task<Ambiente> ConsultarAmbiente(int id)
        {
            try
            {
                var http = new HttpRequester();

                var (JsonResposta, CodigoResposta) = await http.SendGetRequestAsync(ApiFisio.AmbienteId(id));

                if (CodigoResposta.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<Ambiente>>(JsonResposta);
                    if (apiResponse != null)
                        return apiResponse.data;
                }

                LogErro.SetLog(JsonResposta, $"Erro {CodigoResposta} - Consultar Ambiente");

                return null;
            }
            catch (Exception ex)
            {
                LogErro.SetLog(ex, "Throw ConsultarAmbiente");
                return null;
            }
        }

        public async Task DeleteAmbiente(int id)
        {
            try
            {
                var http = new HttpRequester();

                var (JsonResposta, CodigoResposta) = await http.SendDeleteRequestAsync(ApiFisio.AmbienteId(id));

                if (CodigoResposta.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<Ambiente>>(JsonResposta);
                    if (apiResponse != null)
                        return;
                }

                LogErro.SetLog(JsonResposta, $"Erro {CodigoResposta} - Consultar Ambiente");

                return;
            }
            catch (Exception ex)
            {
                LogErro.SetLog(ex, "Throw ConsultarAmbiente");
                return;
            }
        }

        public async Task<Ambiente> InserirAmbiente(AmbienteInputModel AmbienteInputModel)
        {
            try
            {
                var http = new HttpRequester();

                string jsonString = JsonConvert.SerializeObject(AmbienteInputModel);


                var (JsonResposta, CodigoResposta) = await http.SendPostRequestAsync(ApiFisio.Ambientes(), jsonString);

                if (CodigoResposta.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<Ambiente>>(JsonResposta);
                    if (apiResponse != null)
                        return apiResponse.data;
                }

                LogErro.SetLog(JsonResposta, $"Erro {CodigoResposta} - Consultar Ambiente");

                return null;
            }
            catch (Exception ex)
            {
                LogErro.SetLog(ex, "Throw ConsultarAmbiente");
                return null;
            }
        }
        public async Task<Ambiente> AtualizarAmbiente(AmbienteInputModel AmbienteInputModel)
        {
            try
            {
                var http = new HttpRequester();

                string jsonString = JsonConvert.SerializeObject(AmbienteInputModel);


                var (JsonResposta, CodigoResposta) = await http.SendPostRequestAsync(ApiFisio.Ambientes(), jsonString);

                if (CodigoResposta.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<Ambiente>>(JsonResposta);
                    if (apiResponse != null)
                        return apiResponse.data;
                }

                LogErro.SetLog(JsonResposta, $"Erro {CodigoResposta} - Consultar Ambiente");

                return null;
            }
            catch (Exception ex)
            {
                LogErro.SetLog(ex, "Throw ConsultarAmbiente");
                return null;
            }
        }
    }
}
