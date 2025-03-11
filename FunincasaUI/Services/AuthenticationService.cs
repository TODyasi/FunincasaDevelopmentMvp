using FunincasaUI.Models;
using FunincasaUI.Services.IService;
using FunincasaUI.Utility;

namespace FunincasaUI.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IBaseService _baseService;
        public AuthenticationService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<ResponseDto?> AssignRoleAsync(RegistrationRequestDto registrationRequestDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SharedDetails.ApiType.POST,
                Data = registrationRequestDto,
                Url = SharedDetails.AuthenticationAPIBase + "/api/auth/AssignRole"
            });
        }

        public async Task<ResponseDto?> LoginAsync(LoginRequestDto loginRequestDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SharedDetails.ApiType.POST,
                Data = loginRequestDto,
                Url = SharedDetails.AuthenticationAPIBase + "/api/auth/login"
            }, withBearer: false);
        }

        public async Task<ResponseDto?> RegisterAsync(RegistrationRequestDto registrationRequestDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SharedDetails.ApiType.POST,
                Data = registrationRequestDto,
                Url = SharedDetails.AuthenticationAPIBase + "/api/auth/register"
            }, withBearer: false);
        }
    }
}
