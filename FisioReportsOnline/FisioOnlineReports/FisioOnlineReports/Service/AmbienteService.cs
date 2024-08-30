using FisioOnlineReports.EndPoints;
using FisioOnlineReports.Models;
using FisioOnlineReports.Utils;
using LibFisioOnline.Models;
using Newtonsoft.Json;

namespace FisioOnlineReports.Service
{
    public class AmbienteService
    {
        public async Task<List<Ambiente>> ConsultarAmbiente()
        {
            try
            {
                var http = new HttpRequester();

                var (JsonResposta, CodigoResposta) = await http.SendGetRequestAsync(ApiFisio.ConsultarAmbiente());

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
    }
}
