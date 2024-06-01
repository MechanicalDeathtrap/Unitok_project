using Unitok_progect.Application.DTOs.Email;

namespace CleanArchitectureDemo.Application.Interfaces
{
	public interface IEmailSender
	{
		Task SendEmailAsync(string email, string subject, string message);
	}
}
