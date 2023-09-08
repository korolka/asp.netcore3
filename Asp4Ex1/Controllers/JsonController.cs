using Microsoft.AspNetCore.Mvc;

namespace ActionResultsSamples.Controllers
{
    public class JsonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ClientInfo()
        {
            List<Client> clients = new List<Client>() {new Client()
            {
                Id = 100,
                Login = "user1",
                Email = "user1@example.com"
            },
            new Client()
            {
                Id = 101,
                Login = "korol",
                Email = "korol1@example.com"
            },
            new Client()
            {
                Id = 102,
                Login = "Andrey",
                Email = "Andrushka@example.com"
            }};
                        // Json - Сериализует объект переданный в параметрах в JSON и возвращает клиенту ответ.
            return Json(clients);
        }

        public IActionResult ClientInfo2()
        {
            // использование анонимных типов для формирования JSON ответа
            return Json(new
            {
                Id = 100,
                Login = "user1",
                Email = "user1@example.com"
            });
        }
    }

    public class Client
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
    }
}
