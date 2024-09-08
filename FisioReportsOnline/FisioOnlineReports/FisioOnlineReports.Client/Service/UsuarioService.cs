using FisioOnlineReports.Client.Pages.Pacientes;
using FisioOnlineReports.EndPoints;
using FisioOnlineReports.Models;
using FisioOnlineReports.Service;
using FisioOnlineReports.Utils;
using LibFisioOnline.InputModels;
using LibFisioOnline.Models;
using Newtonsoft.Json;

namespace FisioOnlineReports.Client.Service
{
    public class UsuarioService
    {
        public async Task<List<Usuario>> ConsultarUsuarios()
        {
            try
            {
                var http = new HttpRequester();

                var (JsonResposta, CodigoResposta) = await http.SendGetRequestAsync(ApiFisio.Usuarios());

                if (CodigoResposta.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<List<Usuario>>>(JsonResposta);
                    if (apiResponse != null)
                        return apiResponse.data;
                }

                LogErro.SetLog(JsonResposta, $"Erro {CodigoResposta} - Consultar Usuario");

                return null;
            }
            catch (Exception ex)
            {
                LogErro.SetLog(ex, "Throw ConsultarUsuario");
                return null;
            }
        }

        public async Task<Usuario> ConsultarUsuario(int id)
        {
            try
            {
                var http = new HttpRequester();

                var (JsonResposta, CodigoResposta) = await http.SendGetRequestAsync(ApiFisio.UsuarioId(id));

                if (CodigoResposta.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<Usuario>>(JsonResposta);
                    if (apiResponse != null)
                        return apiResponse.data;
                }

                LogErro.SetLog(JsonResposta, $"Erro {CodigoResposta} - Consultar Usuario");

                return null;
            }
            catch (Exception ex)
            {
                LogErro.SetLog(ex, "Throw ConsultarUsuario");
                return null;
            }
        }

        public async Task DeleteUsuario(int id)
        {
            try
            {
                var http = new HttpRequester();

                var (JsonResposta, CodigoResposta) = await http.SendDeleteRequestAsync(ApiFisio.UsuarioId(id));

                if (CodigoResposta.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<Usuario>>(JsonResposta);
                    if (apiResponse != null)
                        return;
                }

                LogErro.SetLog(JsonResposta, $"Erro {CodigoResposta} - Consultar Usuario");

                return;
            }
            catch (Exception ex)
            {
                LogErro.SetLog(ex, "Throw ConsultarUsuario");
                return;
            }
        }

        public async Task<Usuario> InserirUsuario(UsuarioInputModel usuarioInputModel)
        {
            try
            {
                var http = new HttpRequester();

                string jsonString = JsonConvert.SerializeObject(usuarioInputModel);


                var (JsonResposta, CodigoResposta) = await http.SendPostRequestAsync(ApiFisio.Usuarios(), jsonString);

                if (CodigoResposta.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<Usuario>>(JsonResposta);
                    if (apiResponse != null)
                        return apiResponse.data;
                }

                LogErro.SetLog(JsonResposta, $"Erro {CodigoResposta} - Consultar Usuario");

                return null;
            }
            catch (Exception ex)
            {
                LogErro.SetLog(ex, "Throw ConsultarUsuario");
                return null;
            }
        }
        public async Task<Usuario> AtualizarUsuario(UsuarioInputModel usuarioInputModel)
        {
            try
            {
                var http = new HttpRequester();

                string jsonString = JsonConvert.SerializeObject(usuarioInputModel);


                var (JsonResposta, CodigoResposta) = await http.SendPostRequestAsync(ApiFisio.Usuarios(), jsonString);

                if (CodigoResposta.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<Usuario>>(JsonResposta);
                    if (apiResponse != null)
                        return apiResponse.data;
                }

                LogErro.SetLog(JsonResposta, $"Erro {CodigoResposta} - Consultar Usuario");

                return null;
            }
            catch (Exception ex)
            {
                LogErro.SetLog(ex, "Throw ConsultarUsuario");
                return null;
            }
        }

    }
}
