using MailKit.Net.Smtp;

namespace poc_di_ioc.Adapters.ByAbstraction
{
    public class EmailAdapter
    {
        private ISmtpClient _smtpClient;

        public EmailAdapter(ISmtpClient smtpClient)
        {
            _smtpClient = smtpClient;
        }

        // ... do something
    }
}
