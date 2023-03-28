using SoftDesPhase2Engine;
using SoftDesPhase2Engine.Classes;

namespace SoftDesPhase2

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
            Application.Run(new HomePage());

            Farmer Lance = new Farmer("Lance", "Phone", "Ontario", "Big ahh farm");
            Product Peas = new Product(123, "Peas", "Green lil guys", 10.00, 30, Lance);

        }
    }
}