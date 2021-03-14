using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

namespace Adapter.business_logic
{
    public class BitcoinEvent
    {
        private readonly IUserNotificationService userNF;

        public BitcoinEvent(IUserNotificationService userNF)
        {
            this.userNF = userNF;
        }

        public Task Execute()
        {
            // other work here
            return userNF.NotifyUser("", "");
        }
    }
}
