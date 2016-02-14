using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace TSST.Client
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
            var fLogin = new LoginForm();

            if (fLogin.ShowDialog() == DialogResult.OK)
            {
               
                //   MessageBox.Show(Properties.Settings.Default.FacebookToken);
                Application.Run(new MainForm());
            }
            else
            {
                Application.Exit();
            }
        }
      
        }


    }

