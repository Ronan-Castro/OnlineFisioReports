using FisioOnlineReports.EndPoints;
using FisioOnlineReports.Models;
using FisioOnlineReports.Service;
using FisioOnlineReports.Utils;
using LibFisioOnline.InputModels;
using LibFisioOnline.Models;
using Newtonsoft.Json;

namespace FisioOnlineReports.Client.Service
{
    public class PacienteService
    {
        public async Task<List<Paciente>> ConsultarPacientes()
        {
            try
            {
                var http = new HttpRequester();

                var (JsonResposta, CodigoResposta) = await http.SendGetRequestAsync(ApiFisio.Pacientes());

                if (CodigoResposta != null && CodigoResposta.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<List<Paciente>>>(JsonResposta);
                    if (apiResponse != null)
                        return apiResponse.data;
                }

                LogErro.SetLog(JsonResposta, $"Erro {CodigoResposta} - Consultar Paciente");

                return null;
            }
            catch (Exception ex)
            {
                LogErro.SetLog(ex, "Throw ConsultarPaciente");
                return null;
            }
        }

        public async Task<Paciente> ConsultarPaciente(int id)
        {
            try
            {
                var http = new HttpRequester();

                var (JsonResposta, CodigoResposta) = await http.SendGetRequestAsync(ApiFisio.PacienteId(id));

                if (CodigoResposta.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<Paciente>>(JsonResposta);
                    if (apiResponse != null)
                        return apiResponse.data;
                }

                LogErro.SetLog(JsonResposta, $"Erro {CodigoResposta} - Consultar Paciente");

                return null;
            }
            catch (Exception ex)
            {
                LogErro.SetLog(ex, "Throw ConsultarPaciente");
                return null;
            }
        }

        public async Task<Paciente> DeletePaciente(int id)
        {
            try
            {
                var http = new HttpRequester();

                var (JsonResposta, CodigoResposta) = await http.SendDeleteRequestAsync(ApiFisio.PacienteId(id));

                if (CodigoResposta.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<Paciente>>(JsonResposta);
                    if (apiResponse != null)
                        return apiResponse.data;
                }

                LogErro.SetLog(JsonResposta, $"Erro {CodigoResposta} - Consultar Paciente");

                return null;
            }
            catch (Exception ex)
            {
                LogErro.SetLog(ex, "Throw ConsultarPaciente");
                return null;
            }
        }

        public async Task<Paciente> InserirPaciente(PacienteInputModel pacienteInputModel)
        {
            try
            {
                var http = new HttpRequester();

                string jsonString = JsonConvert.SerializeObject(pacienteInputModel);


                var (JsonResposta, CodigoResposta) = await http.SendPostRequestAsync(ApiFisio.Pacientes(), jsonString);

                if (CodigoResposta != null && CodigoResposta.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<Paciente>>(JsonResposta);
                    if (apiResponse != null)
                        return apiResponse.data;
                }

                LogErro.SetLog(JsonResposta, $"Erro {CodigoResposta} - Consultar Paciente");

                return null;
            }
            catch (Exception ex)
            {
                LogErro.SetLog(ex, "Throw ConsultarPaciente");
                return null;
            }
        }

        public async Task<Paciente> AtualizarPaciente(PacienteInputModel pacienteInputModel)
        {
            try
            {
                var http = new HttpRequester();

                string jsonString = JsonConvert.SerializeObject(pacienteInputModel);


                var (JsonResposta, CodigoResposta) = await http.SendPutRequestAsync(ApiFisio.Pacientes(), jsonString);

                if (CodigoResposta.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<Paciente>>(JsonResposta);
                    if (apiResponse != null)
                        return apiResponse.data;
                }

                LogErro.SetLog(JsonResposta, $"Erro {CodigoResposta} - Consultar Paciente");

                return null;
            }
            catch (Exception ex)
            {
                LogErro.SetLog(ex, "Throw ConsultarPaciente");
                return null;
            }
        }

    }
}
