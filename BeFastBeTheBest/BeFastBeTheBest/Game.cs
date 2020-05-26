using BeFastBeTheBest.Shared;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeFastBeTheBest
{
    public partial class Game : Form
    {
        private int quick;
        private string userName;

        Random random = new Random();
        int a, b, c;
        int q1, q2, q3, q4, q5, q6, q7, q8, q9, q10;
        int score = 0;
        public Game(string userName)
        {
            InitializeComponent();

            this.userName = userName;
            this.labelUserName.Text = userName;

            this.textBoxHelp.Text = "HOW TO PLAY: \n After pressing START button it is gonna be 10 mathematics questions, you have to answer in 60 seconds, if you finish earlier press Submit button, correctitude of answers is important, but speed too. Only final results are accepted!";
            this.textBoxHelp.BackColor = System.Drawing.SystemColors.Window;

            this.getScores();
            this.initializeInvisible();
        }

        public void initializeInvisible()
        {
            this.buttonSubmit.Visible = false;

            this.textBoxQ1.Visible = false;
            this.textBoxQ2.Visible = false;
            this.textBoxQ3.Visible = false;
            this.textBoxQ4.Visible = false;
            this.textBoxQ5.Visible = false;
            this.textBoxQ6.Visible = false;
            this.textBoxQ7.Visible = false;
            this.textBoxQ8.Visible = false;
            this.textBoxQ9.Visible = false;
            this.textBoxQ10.Visible = false;

            this.labelQ1.Visible = false;
            this.labelQ2.Visible = false;
            this.labelQ3.Visible = false;
            this.labelQ4.Visible = false;
            this.labelQ5.Visible = false;
            this.labelQ6.Visible = false;
            this.labelQ7.Visible = false;
            this.labelQ8.Visible = false;
            this.labelQ9.Visible = false;
            this.labelQ10.Visible = false;
        }

        public void initializeVisible()
        {
            this.buttonSubmit.Visible = true;

            this.textBoxQ1.Visible = true;
            this.textBoxQ2.Visible = true;
            this.textBoxQ3.Visible = true;
            this.textBoxQ4.Visible = true;
            this.textBoxQ5.Visible = true;
            this.textBoxQ6.Visible = true;
            this.textBoxQ7.Visible = true;
            this.textBoxQ8.Visible = true;
            this.textBoxQ9.Visible = true;
            this.textBoxQ10.Visible = true;

            this.labelQ1.Visible = true;
            this.labelQ2.Visible = true;
            this.labelQ3.Visible = true;
            this.labelQ4.Visible = true;
            this.labelQ5.Visible = true;
            this.labelQ6.Visible = true;
            this.labelQ7.Visible = true;
            this.labelQ8.Visible = true;
            this.labelQ9.Visible = true;
            this.labelQ10.Visible = true;
        }
        public void getScores()
        {
            WebRequest request = WebRequest.Create("https://scoreapi20200520112737.azurewebsites.net/api/scores");
            request.Credentials = CredentialCache.DefaultCredentials;

            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();

                List<Score> myDeserializedObjList = (List<Score>)Newtonsoft.Json.JsonConvert.DeserializeObject((responseFromServer),typeof(List<Score>));

                dataGridViewScores.DataSource = myDeserializedObjList;
                dataGridViewScores.Columns["id"].Visible = false;
                dataGridViewScores.Columns["userName"].DisplayIndex = 1;
                dataGridViewScores.Columns["points"].DisplayIndex = 0;
                dataGridViewScores.Columns["userName"].HeaderText = "User:";
                dataGridViewScores.Columns["points"].HeaderText = "Points:";

                dataGridViewScores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            response.Close();
        }
        private void dgGrid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Auth Next = new Auth();
            Next.Show();
            this.Close();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string sURL = "https://userapi20200519105404.azurewebsites.net/api/users/" + userName;

            WebRequest request = WebRequest.Create(sURL);
            request.Method = "DELETE";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            string result;

            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            if (result == "User not found!")
            {
                MessageBox.Show("Error: " + result);
            }
            else if (result == "Something went wrong!")
            {
                MessageBox.Show("Error: " + result);
                Auth Next = new Auth();
                Next.Show();
                this.Close();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure, you want to delete your account?", "Are you sure?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show(result);
                    Auth Next = new Auth();
                    Next.Show();
                    Hide();
                }
            }
        }
        private void dataGridViewScores_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.initializeVisible();
            this.buttonStart.Visible = false;
            Random random = new Random();
            int a, b, c;
            quick = 3600;

            timeGame = new System.Windows.Forms.Timer();
            timeGame.Interval = 1;

            timeGame.Tick += new EventHandler(timeGame_Tick);
            timeGame.Enabled = true;

            this.a = random.Next(1, 10);
            this.b = random.Next(1,30);
            this.labelQ1.Text = "Q1)  2 * " + this.a + " + 3 * (2 - " + this.b + ") = ?";
            this.q1 = 2 * this.a + 3 * (2 - this.b);

            this.a = random.Next(1, 12);
            this.b = random.Next(1, 10);
            this.labelQ2.Text = "Q2)  2 * " + this.a + " + 0 * (" + this.b + " + "+ this.a + ") = ?";
            this.q2 = 2 * this.a + 0 * (this.b + this.a);

            this.a = random.Next(1, 5);
            this.b = random.Next(1, 5); 
            this.c = random.Next(1, 5);
            this.labelQ3.Text = "Q3) " + this.a + " + " + this.b + " - " + this.c + " = ?";
            this.q3 = this.a + this.b - this.c;

            this.a = random.Next(1, 5);
            this.b = random.Next(1, 20);
            this.labelQ4.Text = "Q4)  (" + this.a + " + " + this.b + ") * 2 = ?";
            this.q4 = (this.a + this.b) * 2;

            this.a = random.Next(1, 5);
            this.b = random.Next(1, 30);
            this.c = random.Next(1, 5);
            this.labelQ5.Text = "Q5)  4 * " + this.a + " + 2 * " + this.b + " + " + this.c + " = ?";
            this.q5 = 4 * this.a + 2 * this.b + this.c;

            this.a = random.Next(1, 100);
            this.b = random.Next(1, 300);
            this.labelQ6.Text = "Q6)  " + this.a + " + " + this.b + " = ?";
            this.q6 = this.a + this.c;

            this.a = random.Next(1, 5);
            this.b = random.Next(1, 5);
            this.c = random.Next(1, 30);
            this.labelQ7.Text = "Q7)  " + this.a + " - " + this.b + " - " + this.c + " = ?";
            this.q7 = this.a - this.b - this.c;


            this.a = random.Next(1, 10);
            this.b = random.Next(1, 10);
            this.c = random.Next(1, 8);
            this.labelQ8.Text = "Q8)  (" + this.a + " + " + this.b + ") - " + this.c + " = ?";
            this.q8 = (this.a + this.b) - this.c;

            this.a = random.Next(1, 20);
            this.b = random.Next(1, 20);
            this.c = random.Next(1, 8);
            this.labelQ9.Text = "Q9)  1 - " + this.a + " + " + this.b + " * " + this.c + " = ?";
            this.q9 = 1 - this.a + this.c + this.c;

            this.a = random.Next(1, 200);
            this.b = random.Next(1, 20);
            this.c = random.Next(1, 100);
            this.labelQ10.Text = "Q10)  (" + this.a + " - " + this.b + " + 0 * " + this.c + ") * 1 = ?";
            this.q10 = (this.a - this.b + 0 * this.c) * 1;

        }
        private void timeGame_Tick(object sender, EventArgs e)
        {
            quick--;
            if (quick == 0)
            {
                labelTimer.ForeColor = Color.Black;
                timeGame.Stop();
                this.onSubmit();
            }
            if(quick != 0 && quick <= 600)
            {
                labelTimer.ForeColor = Color.Red;
                labelTimer.Text = quick / 60 + " : " + ((quick % 60) >= 10 ? (quick % 60).ToString() : "0" + (quick % 60));
            }
            else
            {
                labelTimer.ForeColor = Color.Black;
                labelTimer.Text = quick / 60 + " : " + ((quick % 60) >= 10 ? (quick % 60).ToString() : "0" + (quick % 60));
                if (quick == 0)
                {
                    labelTimer.Text = "60 : 00";
                }
            }
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            timeGame.Stop();
            this.onSubmit();
        }
        public void onUpdate()
        {
            string sURL = "https://scoreapi20200520112737.azurewebsites.net/api/scores/" + userName + "/" + this.score;

            WebRequest request = WebRequest.Create(sURL);
            request.Method = "PUT";
            request.ContentType = "application/json";
            request.ContentLength = 0;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            string result;

            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            if (result == "User not found!")
            {
                MessageBox.Show("Error: " + result);
            }
            this.getScores();
        }
        public void cleaning()
        {
            textBoxQ1.Text = String.Empty;
            textBoxQ2.Text = String.Empty;
            textBoxQ3.Text = String.Empty;
            textBoxQ4.Text = String.Empty;
            textBoxQ5.Text = String.Empty;
            textBoxQ6.Text = String.Empty;
            textBoxQ7.Text = String.Empty;
            textBoxQ8.Text = String.Empty;
            textBoxQ9.Text = String.Empty;
            textBoxQ10.Text = String.Empty;

        }
        public void onSubmit()
        {
            this.initializeInvisible();
            this.buttonStart.Visible = true;

            labelTimer.Text = "60 : 00";
            labelTimer.ForeColor = Color.Black;
            int score = 0;
            if (!String.IsNullOrEmpty(textBoxQ1.Text) && Int32.Parse(textBoxQ1.Text) == q1)
            {
                score++;
            }
            if (!String.IsNullOrEmpty(textBoxQ2.Text) && Int32.Parse(textBoxQ2.Text) == q2)
            {
                score++;
            }
            if (!String.IsNullOrEmpty(textBoxQ3.Text) && Int32.Parse(textBoxQ3.Text) == q3)
            {
                score++;
            }
            if (!String.IsNullOrEmpty(textBoxQ4.Text) && Int32.Parse(textBoxQ4.Text) == q4)
            {
                score++;
            }
            if (!String.IsNullOrEmpty(textBoxQ5.Text) && Int32.Parse(textBoxQ5.Text) == q5)
            {
                score++;
            }
            if (!String.IsNullOrEmpty(textBoxQ6.Text) && Int32.Parse(textBoxQ6.Text) == q6)
            {
                score++;
            }
            if (!String.IsNullOrEmpty(textBoxQ7.Text) && Int32.Parse(textBoxQ7.Text) == q7)
            {
                score++;
            }
            if (!String.IsNullOrEmpty(textBoxQ8.Text) && Int32.Parse(textBoxQ8.Text) == q8)
            {
                score++;
            }
            if (!String.IsNullOrEmpty(textBoxQ9.Text) && Int32.Parse(textBoxQ9.Text) == q9)
            {
                score++;
            }
            if (!String.IsNullOrEmpty(textBoxQ1.Text) && Int32.Parse(textBoxQ10.Text) == q10)
            {
                score++;
            }
            this.calculateScore(score);
            MessageBox.Show("Your score is: " + this.score);
            onUpdate();
            cleaning();
        }

        public void calculateScore(int contor)
        {
            int boostedNumber = 0;
            if (contor == 10)
            {
                boostedNumber = 512;
            }
            else if (contor == 9)
            {
                boostedNumber = 256;
            }
            else if (contor == 8)
            {
                boostedNumber = 128;
            }
            else if (contor == 7)
            {
                boostedNumber = 64;
            }
            else if (contor == 6)
            {
                boostedNumber = 32;
            }
            else if (contor == 5)
            {
                boostedNumber = 16;
            }
            else if (contor == 4)
            {
                boostedNumber = 8;
            }
            else if (contor == 3)
            {
                boostedNumber = 4;
            }
            else if (contor == 2)
            {
                boostedNumber = 2;
            }
            else if (contor == 1)
            {
                boostedNumber = 1;
            }
            this.score =Math.Max(1, quick / 60) * boostedNumber;
        }
    }
}
