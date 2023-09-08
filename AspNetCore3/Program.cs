//�������
//�������� ��� ����������. �������� ������, ������� ����� ������������ ���������
//�������� �� ���������� Id, Price, Name. ��������� ��������� ���������� ����������.
//�������� ���������� Products � ������� ������� Index, ������� ���������� �������������
//�� ����� ������� �� ������. �������� �������� ������ � ������������� ����� ���������,
//����� ViewBag � ����� ������ �������������� �������������.
//� ������ ����������� �� ����������� �� ����� ���������� ������������� ����� ������� ���������?
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