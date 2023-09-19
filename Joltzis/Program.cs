using System.Security.Cryptography.X509Certificates;

namespace Joltzis {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            ApplicationConfiguration.Initialize();
            Application.Run(new formStartMenu());
        }
    }
}