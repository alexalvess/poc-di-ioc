using MailKit.Net.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poc_di_ioc.Adapters.ByServiceLocator
{
    public class EmailAdapter
    {
        private ISmtpClient smtpClient;

        public void SetSmtpClient()
        {
            if (ServiceLocators.Has("smtpClient"))
            {
                smtpClient = ServiceLocators.Get<SmtpClient>("smtpClient");
            }
            else
            {
                throw new Exception("This service not exists.");
            }
        }
    }
}
