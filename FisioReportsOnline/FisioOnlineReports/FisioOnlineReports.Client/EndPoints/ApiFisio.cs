


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
        public static string Ambientes()
        {
            return $"/v1/ambientes";
        }
        public static string AmbienteId(int id)
        {
            return $"/v1/ambientes/{id}";
        }
        public static string Atendimentos()
        {
            return $"/v1/atendimentos";
        }

        public static string Pacientes()
        {
            return $"/v1/pacientes";
        }
        public static string PacienteId(int id)
        {
            return $"/v1/pacientes/{id}";
        }
        public static string Usuarios()
        {
            return $"/v1/usuarios";
        }
        public static string UsuarioId(int id)
        {
            return $"/v1/usuarios/{id}";
        }
        public static string Especialidades()
        {
            return $"/v1/especialidades";
        }
        public static string EspecialidadeId(int id)
        {
            return $"/v1/especialidades/{id}";
        }
    }
}
