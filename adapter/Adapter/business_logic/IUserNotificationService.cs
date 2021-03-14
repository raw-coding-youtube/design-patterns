using System.Threading.Tasks;

namespace Adapter.business_logic
{
    public interface IUserNotificationService
    {
        Task NotifyUser(string userId, string message);
    }
}
