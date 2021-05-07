using EndPoint.Site.Models.Contact;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Application.Services.Contacts.Commands.RegisterMessage;

namespace EndPoint.Site.Controllers
{

    public class ContactController : Controller
    {
        private readonly IRegisterMessageService _registerMessageService;
        public ContactController(IRegisterMessageService registerMessageService)
        {
            _registerMessageService = registerMessageService;

        }


        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.StateErr = "none";
            ViewBag.State = "none";
            return View();
        }



        [HttpPost]
        public IActionResult Index(ContactModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.StateErr = "none";
                ViewBag.State = "none";
                return View(model);
            }
                
            var result = _registerMessageService.Execute(new RequestRegisterMsgDto
            {
                Email = model.Email,
                FullName = model.Name,

                Subject = model.Subject,
                Message = model.Message,
            });
            if (!result.IsSuccess)
            {
                ViewBag.StateErr = "block";
                ViewBag.State = "none";
                ViewBag.ErrorMessage = result.Message;
                return View(model);
            }
            else
            {
                ViewBag.State = "block";
                ViewBag.StateErr = "none";
                ViewBag.SuccessfulMessage = result.Message;
                return View(model);
            }

           

        }
    }
}
