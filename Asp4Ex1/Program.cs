//Задание 1
//Доработайте JsonController и его представления таким образом,
//чтобы на сторону клиента возвращался массив экземпляров Client в виде JSON,
//а также они соответствующим образом отображались в пользовательском интерфейсе.
namespace Asp4Ex1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=json}/{action=index}");
            });

            app.Run();
        }
    }
}