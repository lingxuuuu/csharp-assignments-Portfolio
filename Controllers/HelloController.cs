using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers  //be sure to use your own project's namespace!
{
    public class HelloController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public ViewResult Index()
        {
            // will attempt to serve 
                // Views/Hello/Index.cshtml
            // or if that file isn't there:
                // Views/Shared/Index.cshtml
            return View();
        }

        [HttpGet("projects")]
        public string Projects()
        {
            return "These are my Projects";
        }

        [HttpGet("contact")]
        public string Contact()
        {
            return "This is my Contact";
        }

        [HttpGet]
        [Route("razor")]
        public ViewResult Razor()
        {
            return View();
        }


    }
}