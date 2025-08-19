namespace ECommerce.Model.AuthModel
{
    public class LoginResponse
    {
        public int StatusCode { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public LoginData Data { get; set; }
    }
}
