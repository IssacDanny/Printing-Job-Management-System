using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPSO.Models;
using SPSO.Views;
using SPSO.Presenters;
using SPSO._Repositories;
using System.Configuration;

namespace SPSO
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
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;
            IMainView view = new MainView();              
            new MainPresenter(view, sqlConnectionString);
            Application.Run((Form)view);
        }
    }
}
