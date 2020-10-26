using MailKit.Net.Smtp;
using System;

namespace poc_di_ioc.Adapters.ByProperty
{
    public class EmailAdapter
    {
        private SmtpClient smtpClient;

        public SmtpClient SmtpClient
        {
            get
            {
                return smtpClient;
            }
            set
            {
                if(value == null)
                {
                    throw new Exception("Service not instantiated.");
                }

                smtpClient = value;
            }
        }

        // ... do something
    }
}
