using Facebook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSST.Client
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Login();
        }

        private void webBrowserLogin_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            if (e.Url.ToString().StartsWith("https://www.facebook.com/connect/login_success.html"))
            {
                string myUri = e.Url.AbsoluteUri;
                var splitted = myUri.Split(new char[] { '=', '&' });
                var token = splitted[1];
                Properties.Settings.Default.FacebookToken = token;
                this.DialogResult = DialogResult.OK;
            }
        }

        public void Login()
        {
            dynamic parameters = new ExpandoObject();
            parameters.client_id = "781659158605315";
            parameters.redirect_uri = "https://www.facebook.com/connect/login_success.html";
            parameters.response_type = "token";
            parameters.display = "popup";
            var fb = new FacebookClient();
            Uri loginUrl = fb.GetLoginUrl(parameters);
            var urlWithScope = loginUrl.AbsoluteUri + "&scope=user_friends";
            webBrowserLogin.Navigate(urlWithScope);
        }
    }
}
