using AuthentificationAPI.Models.Dtos;

namespace AuthentificationAPI.Services.IService
{
    public interface IAuthenticationService
    {
        Task<string> Register(RegistrationRequestDto registrationRequestDto);
        Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto);
        Task<bool> AssignRole(string email, string roleName);
    }
}
