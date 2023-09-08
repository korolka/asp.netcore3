using Microsoft.AspNetCore.Mvc;

namespace AspEx1.Cotrollers
{
    public class WebInfoController : Controller
    {
        public IActionResult Index()
        {
            string ip = HttpContext.Connection.RemoteIpAddress.ToString();
            string userAgent = HttpContext.Request.Headers["User-Agent"];

            List<string> headers = new List<string>() { ip, userAgent };
            return View(headers);
        }
    }
}
