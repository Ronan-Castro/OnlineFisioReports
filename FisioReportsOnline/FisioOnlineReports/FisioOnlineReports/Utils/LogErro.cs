namespace FisioOnlineReports.Utils
{
    public class LogErro
    {
        public static void SetLog(Exception e, string log)
        {
            try
            {
                string file, pasta;
                Diretorio(out file, out pasta);

                using (StreamWriter writer = new StreamWriter(pasta + file, true))
                {
                    writer.WriteLine(Utils.GetDateTime().ToString());
                    writer.WriteLine(log);
                    writer.WriteLine("Exception: " + e.Message + " - " + e.ToString());
                    writer.WriteLine("---------------------------------");
                }

            }
            catch (Exception)
            {
                return;
            }
        }
        public static void SetLog(string retorno, string log)
        {
            try
            {
                string file, pasta;
                Diretorio(out file, out pasta);

                using (StreamWriter writer = new StreamWriter(pasta + file, true))
                {
                    writer.WriteLine(Utils.GetDateTime().ToString());
                    writer.WriteLine(log);
                    writer.WriteLine("Exception: " + retorno + " - retorno da Matera");
                    writer.WriteLine("---------------------------------");
                }

            }
            catch (Exception)
            {
                return;
            }
        }

        private static void Diretorio(out string file, out string pasta)
        {
            string diretorioAtual = @"C:\";
            string date = Utils.GetDateTime().ToString("dd-MM-yyyy");
            file = @"\Log_" + date + ".txt";
            pasta = diretorioAtual + @"\LogPainel";
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
        }
    }
}
