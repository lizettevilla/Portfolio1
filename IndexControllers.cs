using Microsoft.AspNetCore.Mvc;
namespace MyPortfolio.Controllers;   
    public class IndexController : Controller  
    {
        [HttpGet]     
        [Route("")]    
        public string Index()
        {
            return "This is my Index!";
        }
        [HttpGet("projects")]        
        public string Projects()
        {
            return "These are my projects!";
        }
        [HttpGet("contact")]       
        public string Contact()
        {
            return "This is my contact!";
        }
    }




