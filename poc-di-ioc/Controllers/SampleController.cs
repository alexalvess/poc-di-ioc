using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using poc_di_ioc.Adapters.ByIoC;

namespace poc_di_ioc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        [HttpGet("byAbstraction")]
        public IActionResult ByAbstraction()
        {
            ISmtpClient smtpClient = new SmtpClient();
            new Adapters.ByAbstraction.EmailAdapter(smtpClient);

            return Ok();
        }

        [HttpGet("byConstructor")]
        public IActionResult ByConstructor()
        {
            SmtpClient smtpClient = new SmtpClient();
            new Adapters.ByConstructor.EmailAdapter(smtpClient);

            return Ok();
        }

        [HttpGet("byProperty")]
        public IActionResult ByProperty()
        {
            var emailAdapter = new Adapters.ByProperty.EmailAdapter();
            emailAdapter.SmtpClient = new SmtpClient();

            return Ok();
        }

        [HttpGet("byServiceLocator")]
        public IActionResult ByServiceLocator()
        {
            if (!Adapters.ByServiceLocator.ServiceLocators.Has("smtpClient"))
            {
                Adapters.ByServiceLocator.ServiceLocators.Register("smtpClient", new SmtpClient());
            }

            var emailAdapter = new Adapters.ByServiceLocator.EmailAdapter();
            emailAdapter.SetSmtpClient();

            return Ok();
        }

        [HttpGet("byIoC")]
        public IActionResult ByIoC([FromServices] IEmailAdapter emailAdapter)
        {
            emailAdapter.DoSomething();

            return Ok();
        }
    }
}
