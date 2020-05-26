using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Net.Http;


namespace BeFastBeTheBest
{
    public partial class Auth : Form
    {

        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);

        public Auth()
        {
            InitializeComponent();
            SendMessage(textBoxLoginName.Handle, EM_SETCUEBANNER, 0, "Username");
            SendMessage(textBoxLoginPassword.Handle, EM_SETCUEBANNER, 0, "Password");

            SendMessage(textBoxSignUpName.Handle, EM_SETCUEBANNER, 0, "Username");
            SendMessage(textBoxSignUpPassword.Handle, EM_SETCUEBANNER, 0, "Password");
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            if (this.textBoxSignUpName.Text.Trim().Length == 0 || this.textBoxSignUpPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("You must complete every field!");
                this.textBoxSignUpName.Text = String.Empty;
                this.textBoxSignUpPassword.Text = String.Empty;
            }
            else
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://userapi20200519105404.azurewebsites.net/api/users/");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{\"Name\":\"" + this.textBoxSignUpName.Text + "\"," +
                                  "\"Password\":\"" + this.textBoxSignUpPassword.Text + "\"}";

                    streamWriter.Write(json);
                }

                string result;
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }
                
                if (result == "User already exists!")
                {
                    MessageBox.Show("Error: " + result);
                }
                else if (result == "Something went wrong!")
                {
                    MessageBox.Show("Error: " + result);
                }
                else
                {
                    Game Next = new Game(this.textBoxSignUpName.Text);
                    Next.Show();
                    Hide();
                }
                this.textBoxSignUpName.Text = String.Empty;
                this.textBoxSignUpPassword.Text = String.Empty;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (this.textBoxLoginName.Text.Trim().Length == 0 || this.textBoxLoginPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("You must complete every field!");
                this.textBoxLoginName.Text = String.Empty;
                this.textBoxLoginPassword.Text = String.Empty;
            }
            else
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://userapi20200519105404.azurewebsites.net/api/users/login");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{\"Name\":\"" + this.textBoxLoginName.Text + "\"," +
                                  "\"Password\":\"" + this.textBoxLoginPassword.Text + "\"}";

                    streamWriter.Write(json);
                }

                string result;

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }
                if (result == "User not found!")
                {
                    MessageBox.Show("Error: " + result);
                }
                else if (result == "Wrong password!")
                {
                    MessageBox.Show("Error: " + result);
                }
                else
                {    
                    Game Next = new Game(this.textBoxLoginName.Text);
                    Next.Show();
                    Hide();
                    // MessageBox.Show("User " + result + " has bean found!");
                }
                this.textBoxLoginName.Text = String.Empty;
                this.textBoxLoginPassword.Text = String.Empty;
            }
        }

    }
}
