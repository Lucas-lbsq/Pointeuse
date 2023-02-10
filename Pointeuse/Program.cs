using Microsoft.VisualBasic.ApplicationServices;
using Pointeuse;
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
            ApplicationConfiguration.Initialize();
            Application.Run(new Accueil());
            
        }

    }
}