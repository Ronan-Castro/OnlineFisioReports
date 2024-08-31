

namespace FisioOnlineReports.EndPoints
{
    public static class ApiFisio
    {

        // URLS GET

        public static string urlBase { get; set; } = $"https://localhost:7142";

        public static string UrlBase()
        {
            return urlBase;
        }
        public static string ConsultarAmbiente()
        {
            return $"/v1/ambientes";
        }
        public static string ConsultarAtendimento()
        {
            return $"/v1/atendimentos";
        }
    }
}
