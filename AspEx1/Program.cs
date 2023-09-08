//Задание 1
//Создайте веб приложение с пользовательским интерфейсом, представляющим простой калькулятор.
//Приложение должно иметь два поля ввода для числовых значений и несколько кнопок для арифметических действий.
//Реализуйте контроллер, который будет обрабатывать запросы и выполнять арифметические действия.

//Задание 2
//Создайте контроллер, который отображает пользователю информацию о его IP адресе и браузере, которым тот выполнил запрос.
namespace AspEx1
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
                endpoints.MapControllerRoute("default", "{controller=Calculator}/{action=Index}/{Id?}");
            });

            app.Run();
        }
    }
}