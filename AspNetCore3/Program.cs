//Задание
//Создайте веб приложение. Добавьте модель, которая будет представлять коллекцию
//объектов со свойствами Id, Price, Name. Заполните коллекцию случайными значениями.
//Сделайте контроллер Products с методом доступа Index, который возвращает представление
//со всеми данными из модели. Сделайте передачу данных в представление двумя способами,
//через ViewBag и через строго типизированное представление.
//С какими сложностями Вы столкнулись во время реализации представлений двумя разными способами?
namespace AspNetCore3
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
                endpoints.MapControllerRoute("default", "{controller}/{action}");
            });

            app.Run();
        }
    }
}