using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System;
using MtgCollectionCore.Db;

namespace MtgCollectionCore
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).

            var connectionString = ConfigurationManager.ConnectionStrings["MtgCollectionConnection"].ConnectionString;
            var optionsBuilder = new DbContextOptionsBuilder<MtgCollectionContext>();
            optionsBuilder.UseSqlServer(connectionString);

            using (var context = new MtgCollectionContext(optionsBuilder.Options))
            {
                var cards = context.Cards.ToList();
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new MainView());
        }
    }
}