namespace FisioOnlineReports.Utils
{
    public class Utils
    {
        public static DateTime GetDateTime()
        {
            DateTime utcNow = DateTime.UtcNow;

            // Definir o fuso horário para o Brasil
            TimeZoneInfo brazilTimeZone = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");

            // Converter a data e hora atual para o fuso horário do Brasil
            DateTime brazilTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, brazilTimeZone);

            return brazilTime;
        }
    }
}
