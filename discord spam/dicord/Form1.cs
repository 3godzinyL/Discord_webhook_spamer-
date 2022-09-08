using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dicord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static void sendWebHook(string Url, string msg, string Username)
        {
            http.Post(Url, new System.Collections.Specialized.NameValueCollection()
            {
                { "avatar_url", Config.AvatarUrl},
                {
                    "username",
                    Username

                },
                {
                    "content",
                    msg
                }


            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            sendWebHook(textBox2.Text, textBox1.Text + "cipka", "3godziny_spam");
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {//add text
            WebClient webClient = new WebClient();
            Uri assetLoader = new Uri("https://cdn.discordapp.com/attachments/992551603863289888/1008750586801422446/spam_3godziny.txt", UriKind.Absolute);
            webClient.DownloadFile(assetLoader, Path.GetTempPath() + "\\spam_3godziny.txt");
            Process.Start(Path.GetTempPath() + "\\spam_3godziny.txt");
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.CheckState == CheckState.Checked)
            {

                timer1.Start();
                checkBox2.Text = "Spam";
                checkBox2.ForeColor = Color.LimeGreen;
            }
            else
            {
                timer1.Stop();
                checkBox2.Text = "Stop";
                checkBox2.ForeColor = Color.Red;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            

            Convert.ToInt32(textBox3.Text);
            timer1.Interval = Convert.ToInt32(textBox3.Text);

            sendWebHook(textBox2.Text, textBox1.Text + "cipa", "3godziny_spam");
        }
    }
}
