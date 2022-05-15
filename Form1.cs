using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;
using System.Net;

namespace test
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(config.AppSettings.Settings["currentTheme"].Value);

            if (config.AppSettings.Settings["alwaysTop"].Value == "true")
            {
                TopMost = true;
                onTopSwitch.IsOn = true;
            }

            comboBoxEdit2.Text = config.AppSettings.Settings["currentTheme"].Value;

            labelControl12.Text = "API Calls Today: " + config.AppSettings.Settings["todCall"].Value;
            labelControl14.Text = "API Calls Overall: " + config.AppSettings.Settings["totCall"].Value;
        }





        private void onTopSwitch_Toggled(object sender, EventArgs e)
        {
            if (onTopSwitch.IsOn)
            {
                TopMost = true;
            }

            else
            {
                TopMost = false;
            }
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            if (onTopSwitch.IsOn)
            {
                config.AppSettings.Settings["alwaysTop"].Value = "true";
            }

            else
            {
                config.AppSettings.Settings["alwaysTop"].Value = "false";
            }

            config.AppSettings.Settings["currentTheme"].Value = comboBoxEdit2.Text;
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(comboBoxEdit2.Text);
            config.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void hyperlinkLabelControl3_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/0xwarning");
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {
                checkEdit2.Checked = false;
                checkEdit3.Checked = false;
                checkEdit4.Checked = false;
                checkEdit5.Checked = false;
                checkEdit6.Checked = false;
                checkEdit7.Checked = false;
                checkEdit8.Checked = false;
                checkEdit9.Checked = false;

            }
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit2.Checked)
            {
                checkEdit1.Checked = false;
                checkEdit3.Checked = false;
                checkEdit4.Checked = false;
                checkEdit5.Checked = false;
                checkEdit6.Checked = false;
                checkEdit7.Checked = false;
                checkEdit8.Checked = false;
                checkEdit9.Checked = false;

            }
        }

        private void checkEdit4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit4.Checked)
            {
                checkEdit2.Checked = false;
                checkEdit3.Checked = false;
                checkEdit1.Checked = false;
                checkEdit5.Checked = false;
                checkEdit6.Checked = false;
                checkEdit7.Checked = false;
                checkEdit8.Checked = false;
                checkEdit9.Checked = false;

            }
        }

        private void checkEdit3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit3.Checked)
            {
                checkEdit2.Checked = false;
                checkEdit1.Checked = false;
                checkEdit4.Checked = false;
                checkEdit5.Checked = false;
                checkEdit6.Checked = false;
                checkEdit7.Checked = false;
                checkEdit8.Checked = false;
                checkEdit9.Checked = false;

            }
        }

        private void checkEdit5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit5.Checked)
            {
                checkEdit2.Checked = false;
                checkEdit3.Checked = false;
                checkEdit4.Checked = false;
                checkEdit1.Checked = false;
                checkEdit6.Checked = false;
                checkEdit7.Checked = false;
                checkEdit8.Checked = false;
                checkEdit9.Checked = false;

            }
        }

        private void checkEdit6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit6.Checked)
            {
                checkEdit2.Checked = false;
                checkEdit3.Checked = false;
                checkEdit4.Checked = false;
                checkEdit5.Checked = false;
                checkEdit1.Checked = false;
                checkEdit7.Checked = false;
                checkEdit8.Checked = false;
                checkEdit9.Checked = false;

            }
        }

        private void checkEdit7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit7.Checked)
            {
                checkEdit2.Checked = false;
                checkEdit3.Checked = false;
                checkEdit4.Checked = false;
                checkEdit5.Checked = false;
                checkEdit6.Checked = false;
                checkEdit1.Checked = false;
                checkEdit8.Checked = false;
                checkEdit9.Checked = false;

            }
        }

        private void checkEdit8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit8.Checked)
            {
                checkEdit2.Checked = false;
                checkEdit3.Checked = false;
                checkEdit4.Checked = false;
                checkEdit5.Checked = false;
                checkEdit6.Checked = false;
                checkEdit7.Checked = false;
                checkEdit1.Checked = false;
                checkEdit9.Checked = false;

            }
        }

        private void checkEdit9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit9.Checked)
            {
                checkEdit2.Checked = false;
                checkEdit3.Checked = false;
                checkEdit4.Checked = false;
                checkEdit5.Checked = false;
                checkEdit6.Checked = false;
                checkEdit7.Checked = false;
                checkEdit8.Checked = false;
                checkEdit1.Checked = false;

            }
        }

        private void Test()
        {
            int todCall = int.Parse(config.AppSettings.Settings["todCall"].Value);
            int totCall = int.Parse(config.AppSettings.Settings["totCall"].Value);
            todCall = todCall + 1;
            totCall = totCall + 1;
            string todcall2 = todCall.ToString();
            string totCall2 = totCall.ToString();
            config.AppSettings.Settings["todCall"].Value = todcall2;
            config.AppSettings.Settings["totCall"].Value = totCall2;
            config.Save();
            ConfigurationManager.RefreshSection("appSettings");
            labelControl12.Text = "API Calls Today: " + config.AppSettings.Settings["todCall"].Value;
            labelControl14.Text = "API Calls Overall: " + config.AppSettings.Settings["totCall"].Value;
        }
       

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {
                WebClient web = new WebClient();
                string result = web.DownloadString("http://localhost/detectcf?key=UUQl6GVF3wQTAvdv3wo5voryL6cRFDYgcp7V1IFqYyduU&output=html&host=" + apiInputTextBox.Text);
                richTextBox1.SelectionStart = richTextBox1.TextLength;
                richTextBox1.SelectionLength = 0;

                richTextBox1.SelectionColor = Color.Red;
                richTextBox1.AppendText(result + "\n");
                richTextBox1.SelectionColor = richTextBox1.ForeColor;
                apiStatusText.Text = "Request received";
                apiStatusText.ForeColor = Color.Lime;
                Test();
            }

            if (checkEdit2.Checked)
            {
                WebClient web = new WebClient();
                string result = web.DownloadString("http://localhost/geoip?key=UUQl6GVF3wQTAvdv3wo5voryL6cRFDYgcp7V1IFqYyduU&output=html&ip=" + apiInputTextBox.Text);
                result = result.Replace("<pre>{", "").Replace("}</pre>", "");
                richTextBox1.SelectionStart = richTextBox1.TextLength;
                richTextBox1.SelectionLength = 0;

                richTextBox1.SelectionColor = Color.Green;
                richTextBox1.AppendText(result + "\n");
                richTextBox1.SelectionColor = richTextBox1.ForeColor;
                apiStatusText.Text = "Request received";
                apiStatusText.ForeColor = Color.Lime;
                Test();
            }

            if (checkEdit4.Checked)
            {
                WebClient web = new WebClient();
                string result = web.DownloadString("http://localhost/validip?key=UUQl6GVF3wQTAvdv3wo5voryL6cRFDYgcp7V1IFqYyduU&output=html&ip=" + apiInputTextBox.Text);
                richTextBox1.SelectionStart = richTextBox1.TextLength;
                richTextBox1.SelectionLength = 0;

                richTextBox1.SelectionColor = Color.Yellow;
                richTextBox1.AppendText(result + "\n");
                richTextBox1.SelectionColor = richTextBox1.ForeColor;
                apiStatusText.Text = "Request received";
                apiStatusText.ForeColor = Color.Lime;
                Test();
            }

            if (checkEdit3.Checked)
            {
                WebClient web = new WebClient();
                string result = web.DownloadString("http://localhost/getheaders?key=UUQl6GVF3wQTAvdv3wo5voryL6cRFDYgcp7V1IFqYyduU&output=html&host=" + apiInputTextBox.Text);
                result = result.Replace("<pre>[", "").Replace("]</pre>", "");
                richTextBox1.SelectionStart = richTextBox1.TextLength;
                richTextBox1.SelectionLength = 0;

                richTextBox1.SelectionColor = Color.DarkCyan;
                richTextBox1.AppendText(result + "\n");
                richTextBox1.SelectionColor = richTextBox1.ForeColor;
                apiStatusText.Text = "Request received";
                apiStatusText.ForeColor = Color.Lime;
                Test();
            }

            if (checkEdit5.Checked)
            {
                WebClient web = new WebClient();
                string result = web.DownloadString("http://localhost/host2ip?key=UUQl6GVF3wQTAvdv3wo5voryL6cRFDYgcp7V1IFqYyduU&output=html&host=" + apiInputTextBox.Text);
                richTextBox1.SelectionStart = richTextBox1.TextLength;
                richTextBox1.SelectionLength = 0;
                result = result.Replace("<font color=\"#ff8c00\">", "").Replace("</font>", "");
                richTextBox1.SelectionColor = Color.HotPink;
                richTextBox1.AppendText(result + "\n");
                richTextBox1.SelectionColor = richTextBox1.ForeColor;
                apiStatusText.Text = "Request received";
                apiStatusText.ForeColor = Color.Lime;
                Test();
            }

            if (checkEdit6.Checked)
            {
                WebClient web = new WebClient();
                string result = web.DownloadString("http://localhost/ip2host?key=UUQl6GVF3wQTAvdv3wo5voryL6cRFDYgcp7V1IFqYyduU&output=html&ip=" + apiInputTextBox.Text);
                richTextBox1.SelectionStart = richTextBox1.TextLength;
                richTextBox1.SelectionLength = 0;
                result = result.Replace("<font color=\"blue\">", "").Replace("</font>", "");
                richTextBox1.SelectionColor = Color.Pink;
                richTextBox1.AppendText(result + "\n");
                richTextBox1.SelectionColor = richTextBox1.ForeColor;
                apiStatusText.Text = "Request received";
                apiStatusText.ForeColor = Color.Lime;
                Test();
            }
        }
    }
}


