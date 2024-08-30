namespace FisioOnlineReports.Models
{
    public class ApiResponse<T>
    {
        public T data { get; set; }
        public List<string> errors { get; set; }
    }
}
