using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheNoteBookProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());  //Selam canlarım :* Lütfen check in yaparken buranın login form olarak kaldığından emin olun, çalışırken değiştirebilirsiniz ama check in yaparken eski haline geri getirelim ya da sadece çalıştığınız formları ve classları checkin yapın Program'ı yapmayın, merak etmeyin yaptığınız değişiklikler kaydolur, öperimmmm...
        }
    }
}
