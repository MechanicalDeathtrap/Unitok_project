using Unitok_progect.Application.DTOs.Email;

namespace CleanArchitectureDemo.Application.Interfaces
{
    public interface IEmailService
    {
        Task SendAsync(EmailRequestDto request);
    }
}
