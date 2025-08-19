using ECommerce.Model.AuthModel;


namespace ECommerce.Service.API.AuthService
{
    public interface IAuthService
    {
        Task<LoginResponse> LoginAsync(LoginRequest request);
    }
}
