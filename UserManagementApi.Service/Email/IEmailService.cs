using UserManagementApi.Service.Email.Models;

namespace UserManagementApi.Service.Email
{
    public interface IEmailService
    {
        void SendEmail(Message message);
    }
}