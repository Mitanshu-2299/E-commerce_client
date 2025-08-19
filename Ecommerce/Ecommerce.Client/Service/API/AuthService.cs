using ECommerce.Config;
using ECommerce.Model.AuthModel;

using Microsoft.Extensions.Options;

namespace ECommerce.Service.API.AuthService
{
    public class AuthService : IAuthService
    {
        private readonly ApiService _apiService;
        private readonly ApiSettings _settings;

        public AuthService(ApiService apiService, IOptions<ApiSettings> settings)
        {
            _apiService = apiService;
            _settings = settings.Value;
        }

        public async Task<LoginResponse> LoginAsync(LoginRequest request)
        {

            var url = $"{APIEndPoints.BaseUrl}{APIEndPoints.Auth.Login}";
            return await _apiService.PostAsync<LoginResponse>(url, request);
        }
    }
}
