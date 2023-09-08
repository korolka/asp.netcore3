using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace SimpleApp.Controllers
{
    public class HomeController : Controller
    {
        IHostingEnvironment environment;
        public HomeController(IHostingEnvironment environment)
        {
            this.environment = environment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public FileStreamResult /*VirtualFileResult *//*PhysicalFileResult */FIle1()
        {
            FileStream file = new FileStream(@"App_Data\data.txt", FileMode.Open);
            return File(file, "application/txt", "newFile.txt");
           //return File(@"App_Data\data.txt", "application/txt","newFile.txt");  
           // return PhysicalFile(environment.ContentRootPath + @"\App_Data\data.txt", "application/txt", "newFile.txt");
        }
    }
}
