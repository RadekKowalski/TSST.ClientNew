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
        static private async Task getAccessToken()
        {
            using (var client = new HttpClient())
            {
                var values = new Dictionary<string, string>
                {
                        { "grant_type", "facebook" },
                        { "accesstoken", Properties.Settings.Default.FacebookToken }
                };
                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync(Properties.Settings.Default.ServiceUri+ "/Token", content);
                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    var postResponse = new JavaScriptSerializer().Deserialize<PostResponse>(responseString);
                    Properties.Settings.Default.ApiToken = postResponse.access_token;
                }
                else
                {
                    throw new Exception();
                }

            }
        }

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
                var getToken =  getAccessToken();
                getToken.Wait();
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

