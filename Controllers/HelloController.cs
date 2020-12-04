using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers     //be sure to use your own project's namespace!
{
    public class HelloController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public string Index()
        {
            return "This is my Index";
        }

        [HttpGet("projects")]
        public string Projects()
        {
            return "These are my Projects";
        }

        [HttpGet("contact")]
        public string contact()
        {
            return "This is my Contact";
        }

    }
}