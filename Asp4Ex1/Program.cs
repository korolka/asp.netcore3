//������� 1
//����������� JsonController � ��� ������������� ����� �������,
//����� �� ������� ������� ����������� ������ ����������� Client � ���� JSON,
//� ����� ��� ��������������� ������� ������������ � ���������������� ����������.
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