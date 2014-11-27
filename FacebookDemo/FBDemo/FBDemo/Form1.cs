using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using FB.Core;

namespace FBDemo
{
    public partial class Form1 : Form
    {
        private string AccessToken { get; set; }
        public Form1()
        {
            InitializeComponent();

        }

        private void btnAuthorize_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAppId.Text))
            {
                var facebookLogin = new FacebookLogin();
                Uri fbloginuri = facebookLogin.GenerateLoginUrl(txtAppId.Text.Trim());
                var browserForm = new Browser();
                browserForm.webBrowser.Navigate(fbloginuri);
                browserForm.ShowDialog();
                AccessToken = browserForm.AccessToken;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetConfiguration();
        }

        public void GetConfiguration()
        {
            var appId = ConfigurationManager.AppSettings["facebook:AppId"];
            if (appId != null)
            {
                if (!string.IsNullOrEmpty(appId))
                {
                    txtAppId.Text = appId;
                }
            }
        }

        private async void btnFeeds_Click(object sender, EventArgs e)
        {
            var fbClient = new FacebookClient(AccessToken);
            dynamic parameters = new ExpandoObject();
            parameters.access_token = AccessToken;
            dynamic result = await fbClient.GetTaskAsync("me/feed", parameters);
        }

        private void btnGetConfig_Click(object sender, EventArgs e)
        {
            GetConfiguration();
        }
    }
}
