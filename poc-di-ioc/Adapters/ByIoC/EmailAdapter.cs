using MailKit.Net.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poc_di_ioc.Adapters.ByIoC
{
    public class EmailAdapter : IEmailAdapter
    {
        private readonly ISmtpClient _smtpClient;

        public EmailAdapter(ISmtpClient smtpClient)
        {
            _smtpClient = smtpClient;
        }

        public void DoSomething()
        {
            // ... do something
        }
    }
}
