using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pointeuse.db_contexts;

namespace Pointeuse

{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //Application.EnableVisualStyles();
            
            //var services = new ServiceCollection();
            //ConfigureServices(services);



            ApplicationConfiguration.Initialize();
            Application.Run(new Accueil());
        }

        //private static void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddDbContext<PointeuseContext>(DbContextOptions => DbContextOptions.UseSqlite("Data Source=../../../Pointeuse.db"));
        //}
    }
}