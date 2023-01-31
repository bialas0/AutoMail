using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


// Add continious checks for each text box, which will validate data, showing
// a small message saying that the input is in incorrect format. 


namespace AutoMail
{
    public partial class AutoMail : Form
    {
        public AutoMail()
        {
            DataManagment dataManagment = new DataManagment();
            InitializeComponent();

            fileExpOpen.MouseEnter += OnMouseEnterFileExpOpen; fileExpOpen.MouseLeave += OnMouseLeaveFileExpOpen;
            closeNewsGB.MouseEnter += OnMouseEnterCloseNewsGB; closeNewsGB.MouseLeave += OnMouseLeaveCloseNewsGB;
            attachFile.MouseEnter += OnMouseEnterAttachFile; attachFile.MouseLeave += OnMouseLeaveAttachFile;
            sender.MouseEnter += OnMouseEnterSender; sender.MouseLeave += OnMouseLeaveSender;
            darkMode.MouseEnter += OnMouseEnterDarkMode; darkMode.MouseLeave += OnMouseLeaveDarkMode;
            viewPw.MouseEnter += OnMouseEnterViewPw; viewPw.MouseLeave += OnMouseLeaveViewPw;

            newsLable1.Text = "- Automated emails sourced from one text file." +
                "\n\n📨 - Dark mode switch allowing light/ dark." +
                "\n\n🌻 - CLI -> GUI migration, allowing for easier use." +
                "\n\n❤️ - More cozy colours, with a user-friendly design." +
                "\n\n🚀 - Emails now send much faster, with custom\n delay-time option." +
                " You can change this depending\n on your network speed." +
                "\n\n\nThis app uses the Gmail SMTP servers to send your" +
                "\nemails securely over the 587 port." +
                "\n\nContact (Discord): bialasik__#3738";
        }
        private void OnMouseEnterFileExpOpen(object sender, EventArgs e)
        {
            fileExpOpen.BackColor = SystemColors.ControlLightLight;
            fileExpOpen.ForeColor = SystemColors.ControlDarkDark;
        }
        private void OnMouseLeaveFileExpOpen(object sender, EventArgs e)
        {
            fileExpOpen.BackColor = SystemColors.ControlDarkDark;
            fileExpOpen.ForeColor = SystemColors.ControlLightLight;
        }

        private void OnMouseEnterCloseNewsGB(object sender, EventArgs e)
        {
            closeNewsGB.BackColor = SystemColors.ControlLightLight;
            closeNewsGB.ForeColor = SystemColors.ControlDarkDark;
        }
        private void OnMouseLeaveCloseNewsGB(object sender, EventArgs e)
        {
            closeNewsGB.BackColor = SystemColors.ControlDarkDark;
            closeNewsGB.ForeColor = SystemColors.ControlLightLight;
        }

        private void OnMouseEnterAttachFile(object sender, EventArgs e)
        {
            attachFile.BackColor = SystemColors.ControlLightLight;
            attachFile.ForeColor = SystemColors.ControlDarkDark;
        }
        private void OnMouseLeaveAttachFile(object sender, EventArgs e)
        {
            attachFile.BackColor = SystemColors.ControlDarkDark;
            attachFile.ForeColor = SystemColors.ControlLightLight;
        }

        private void OnMouseEnterSender(object senders, EventArgs e)
        {
            sender.BackColor = SystemColors.ControlLightLight;
            sender.ForeColor = SystemColors.ControlDarkDark;
        }
        private void OnMouseLeaveSender(object senders, EventArgs e)
        {
            sender.BackColor = SystemColors.ControlDarkDark;
            sender.ForeColor = SystemColors.ControlLightLight;
        }

        private void OnMouseEnterDarkMode(object senders, EventArgs e)
        {
            darkMode.BackColor = SystemColors.ControlLightLight;
            darkMode.ForeColor = SystemColors.ControlDarkDark;
        }
        private void OnMouseLeaveDarkMode(object senders, EventArgs e)
        {
            darkMode.BackColor = SystemColors.ControlDarkDark;
            darkMode.ForeColor = SystemColors.ControlLightLight;
        }

        private void OnMouseEnterViewPw(object senders, EventArgs e)
        {
            viewPw.BackColor = SystemColors.ControlLightLight;
            viewPw.ForeColor = SystemColors.ControlDarkDark;
        }
        private void OnMouseLeaveViewPw(object senders, EventArgs e)
        {
            viewPw.BackColor = SystemColors.ControlDarkDark;
            viewPw.ForeColor = SystemColors.ControlLightLight;
        }
        
        private string file = String.Empty;

        private void AutoMail_Load(object sender, EventArgs e)
        {
            
        }

        private void fileExpOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pathInput.Text = ofd.FileName;
            }
        }

        private void pathInput_TextChanged(object sender, EventArgs e)
        {

        }
        private string email;

        private void emailInput_TextChanged(object sender, EventArgs e)
        {
            DataManagment dataManagment = new DataManagment();
        }

        private async void pwInput_TextChanged(object sender, EventArgs e)
        {
            DataManagment dataManagment = new DataManagment();
            pwInput.PasswordChar = '●';
        }

        private void subjectInput_TextChanged(object sender, EventArgs e)
        {
            DataManagment dataManagment = new DataManagment();
        }

        private void msgInputRich_TextChanged(object sender, EventArgs e)
        {

        }

        private void sender_Click(object sender, EventArgs e)
        {
            DataManagment dataManagment = new DataManagment();

            dataManagment.Path = pathInput.Text;
            dataManagment.Email = emailInput.Text;
            dataManagment.Password = pwInput.Text;
            dataManagment.Subject = subjectInput.Text;
            dataManagment.Message = msgInputRich.Text;
            dataManagment.DelayTime = double.Parse(tDelayInput.Text);
            //dataManagment.Test();
            dataManagment.LoadData();
            dataManagment.SendEmail();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void githubProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/bialas0\r\n");
        }

        private void newsGB_Enter(object sender, EventArgs e)
        {

        }

        private void attachFile_Click(object sender, EventArgs e)
        {

        }

        bool isShown = false;
        private void viewPw_Click(object sender, EventArgs e)
        {
            if (!isShown)
            {
                pwInput.PasswordChar = '\0';
                viewPw.Text = "👁";
                isShown = true;
            }
            else
            {
                pwInput.PasswordChar = '●';
                viewPw.Text = "👁️‍🗨️";
                isShown = false;
            }
        }

        private void closeNewsGB_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(newsGB);
            msgInputRich.Size = new Size(951, 429); // x, y
        }

        private bool isDark = false;
        private void darkMode_Click(object sender, EventArgs e)
        {
            if (!isDark)
            {
                this.BackColor = ColorTranslator.FromHtml("#121212");
                darkMode.Text = "🌣";

                label1.ForeColor = SystemColors.ControlLight;
                label2.ForeColor = SystemColors.ControlLight;
                label3.ForeColor = SystemColors.ControlLight;
                label4.ForeColor = SystemColors.ControlLight;
                label5.ForeColor = SystemColors.ControlLight;
                label6.ForeColor = SystemColors.ControlLight;
                label7.ForeColor = SystemColors.ControlLight;
                label8.ForeColor = SystemColors.ControlLight;

                pathInput.BackColor = ColorTranslator.FromHtml("#A5C9CA");
                emailInput.BackColor = ColorTranslator.FromHtml("#A5C9CA");
                pwInput.BackColor = ColorTranslator.FromHtml("#A5C9CA");
                subjectInput.BackColor = ColorTranslator.FromHtml("#A5C9CA");
                msgInputRich.BackColor = ColorTranslator.FromHtml("#A5C9CA");
                msgInputRich.BackColor = ColorTranslator.FromHtml("#A5C9CA");
                tDelayInput.BackColor = ColorTranslator.FromHtml("#A5C9CA");

                newsGB.ForeColor = SystemColors.ControlLight;
                githubProfile.LinkColor = Color.FromArgb(192, 192, 255);

                isDark = true;
            }
            else
            {
                this.BackColor = SystemColors.ControlLightLight;
                darkMode.Text = "☾";

                label1.ForeColor = SystemColors.ControlText;
                label2.ForeColor = SystemColors.ControlText;
                label3.ForeColor = SystemColors.ControlText;
                label4.ForeColor = SystemColors.ControlText;
                label5.ForeColor = SystemColors.ControlText;
                label6.ForeColor = SystemColors.ControlText;
                label7.ForeColor = SystemColors.ControlText;
                label8.ForeColor = SystemColors.ControlText;

                pathInput.BackColor = Color.FromArgb(231, 246, 242);
                emailInput.BackColor = Color.FromArgb(231, 246, 242);
                pwInput.BackColor = Color.FromArgb(231, 246, 242);
                subjectInput.BackColor = Color.FromArgb(231, 246, 242);
                msgInputRich.BackColor = Color.FromArgb(231, 246, 242);
                msgInputRich.BackColor = Color.FromArgb(231, 246, 242);
                tDelayInput.BackColor = Color.FromArgb(231, 246, 242);

                newsGB.ForeColor = SystemColors.ControlText;
                githubProfile.LinkColor = Color.FromArgb(0, 0, 255);

                isDark = false;
            }
        }

        private void attachFile_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Attach files (Images, PDFs, Documents etc).", attachFile);
        }

        private void viewPw_MouseHover(object sender, EventArgs e)
        {
            if (!isShown)
            {
                toolTip1.Show("Show password.", viewPw);
            }
            else
            {
                toolTip1.Show("Hide password.", viewPw);
            }
        }

        private void fileExpOpen_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Find the text file\nthrough File Explorer.", fileExpOpen);
        }

        private void darkMode_MouseHover(object sender, EventArgs e)
        {
            if (!isDark)
            {
                toolTip1.Show("Switch to dark mode.", darkMode);
            }
            else
            {
                toolTip1.Show("Switch to light mode.", darkMode);
            }
        }

        private void sender_MouseHover(object senders, EventArgs e)
        {
            toolTip1.Show("Send emails to all emails\nincluded in the text file.", sender);
        }

        private void newsLable1_Click(object sender, EventArgs e)
        {

        }
    }
}
