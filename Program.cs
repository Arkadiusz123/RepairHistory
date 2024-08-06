using Microsoft.EntityFrameworkCore;
using RepairHistory.Database;

namespace RepairHistory
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var context = new AppDbContext())
            {
                context.Database.EnsureCreated();

                if (!context.Database.GetPendingMigrations().Any())                
                    context.Database.Migrate();               
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}