

namespace FisioOnlineReports.EndPoints
{
    public static class ApiFisio
    {

        // URLS GET

        public static string urlBase { get; set; } = $"";

        public static string UrlBase()
        {
            return urlBase;
        }

        internal static string ConsultarAmbiente()
        {
            return $"/v1/ambientes";
        }
    }
}
