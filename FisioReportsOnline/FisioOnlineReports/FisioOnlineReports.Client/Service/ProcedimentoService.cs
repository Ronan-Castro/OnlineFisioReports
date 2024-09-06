using FisioOnlineReports.Client.Pages.TabelaProcedimento;
using FisioOnlineReports.EndPoints;
using FisioOnlineReports.Models;
using FisioOnlineReports.Service;
using FisioOnlineReports.Utils;
using LibFisioOnline.Models;
using Newtonsoft.Json;

namespace FisioOnlineReports.Client.Service
{
    public class TabelaProcedimentoService
    {
        public async Task<List<TabelaProcedimento>> ConsultarTabelaProcedimentos()
        {
            try
            {
                var http = new HttpRequester();

                var (JsonResposta, CodigoResposta) = await http.SendGetRequestAsync(ApiFisio.TabelaProcedimentos());

                if (CodigoResposta.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<List<TabelaProcedimento>>>(JsonResposta);
                    if (apiResponse != null)
                        return apiResponse.data;
                }

                LogErro.SetLog(JsonResposta, $"Erro {CodigoResposta} - Consultar TabelaProcedimento");

                return null;
            }
            catch (Exception ex)
            {
                LogErro.SetLog(ex, "Throw ConsultarTabelaProcedimento");
                return null;
            }
        }

        public async Task<TabelaProcedimento> ConsultarTabelaProcedimento(int id)
        {
            try
            {
                var http = new HttpRequester();

                var (JsonResposta, CodigoResposta) = await http.SendGetRequestAsync(ApiFisio.TabelaProcedimentoId(id));

                if (CodigoResposta.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<TabelaProcedimento>>(JsonResposta);
                    if (apiResponse != null)
                        return apiResponse.data;
                }

                LogErro.SetLog(JsonResposta, $"Erro {CodigoResposta} - Consultar TabelaProcedimento");

                return null;
            }
            catch (Exception ex)
            {
                LogErro.SetLog(ex, "Throw ConsultarTabelaProcedimento");
                return null;
            }
        }

        public async Task DeleteTabelaProcedimento(int id)
        {
            try
            {
                var http = new HttpRequester();

                var (JsonResposta, CodigoResposta) = await http.SendDeleteRequestAsync(ApiFisio.TabelaProcedimentoId(id));

                if (CodigoResposta.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<TabelaProcedimento>>(JsonResposta);
                    if (apiResponse != null)
                        return;
                }

                LogErro.SetLog(JsonResposta, $"Erro {CodigoResposta} - Consultar TabelaProcedimento");

                return;
            }
            catch (Exception ex)
            {
                LogErro.SetLog(ex, "Throw ConsultarTabelaProcedimento");
                return;
            }
        }

        public async Task<TabelaProcedimento> InserirTabelaProcedimento(TabelaProcedimentoInputModel TabelaProcedimentoInputModel)
        {
            try
            {
                var http = new HttpRequester();

                string jsonString = JsonConvert.SerializeObject(TabelaProcedimentoInputModel);


                var (JsonResposta, CodigoResposta) = await http.SendPostRequestAsync(ApiFisio.TabelaProcedimentos(), jsonString);

                if (CodigoResposta.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<TabelaProcedimento>>(JsonResposta);
                    if (apiResponse != null)
                        return apiResponse.data;
                }

                LogErro.SetLog(JsonResposta, $"Erro {CodigoResposta} - Consultar TabelaProcedimento");

                return null;
            }
            catch (Exception ex)
            {
                LogErro.SetLog(ex, "Throw ConsultarTabelaProcedimento");
                return null;
            }
        }
        public async Task<TabelaProcedimento> AtualizarTabelaProcedimento(TabelaProcedimentoInputModel TabelaProcedimentoInputModel)
        {
            try
            {
                var http = new HttpRequester();

                string jsonString = JsonConvert.SerializeObject(TabelaProcedimentoInputModel);


                var (JsonResposta, CodigoResposta) = await http.SendPostRequestAsync(ApiFisio.TabelaProcedimentos(), jsonString);

                if (CodigoResposta.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<TabelaProcedimento>>(JsonResposta);
                    if (apiResponse != null)
                        return apiResponse.data;
                }

                LogErro.SetLog(JsonResposta, $"Erro {CodigoResposta} - Consultar TabelaProcedimento");

                return null;
            }
            catch (Exception ex)
            {
                LogErro.SetLog(ex, "Throw ConsultarTabelaProcedimento");
                return null;
            }
        }
    }
}
