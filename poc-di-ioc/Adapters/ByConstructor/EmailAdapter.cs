using MailKit.Net.Smtp;

namespace poc_di_ioc.Adapters.ByConstructor
{
    public class EmailAdapter
    {
        private readonly SmtpClient _smtpClient;

        public EmailAdapter(SmtpClient smtpClient)
        {
            _smtpClient = smtpClient;
        }

        // ... do something
    }
}
