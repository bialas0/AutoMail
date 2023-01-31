using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Diagnostics;

namespace AutoMail
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AutoMail());
        }
    }

    class DataManagment
    {
        StreamReader r; StreamWriter w;

        private string path;

        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        private Queue<string> validEmailsQ = new Queue<string>();
        private Queue<string> invalidEmailsQ = new Queue<string>();

        public void LoadData()
        {
            string email;
            bool vaild;
            try
            {
                r = new StreamReader(Path);
                while (!r.EndOfStream)
                {
                    email = r.ReadLine();
                    //vaild = IsValidEmail(email);

                    //if (vaild)
                    //{
                    //    validEmailsQ.Enqueue(email);
                    //}
                    //else
                    //{
                    //    invalidEmailsQ.Enqueue(email);
                    //}
                    validEmailsQ.Enqueue(email);
                }
                r.Close();
            }
            catch(IOException)
            {
                throw new Exception("ERROR [001]: Select a readable text file.");
            }
        }
        //private bool IsValidEmail(string email)
        //{
        //    var trimmedEmail = email.Trim();

        //    if (trimmedEmail.EndsWith("."))
        //    {
        //        return false;
        //    }
        //    try
        //    {
        //        var addr = new System.Net.Mail.MailAddress(email);
        //        return addr.Address == trimmedEmail;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        private SmtpClient smtpClient = new SmtpClient();
        private MailMessage msg = new MailMessage();

        private string email, password, subject, message, currentReceiver;
        private double delayTime = 1.25;

        private bool isDouble = false;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        public double DelayTime
        {
            get { return delayTime; }
            set 
            {
                isDouble = double.TryParse(DelayTime.ToString(), out delayTime);
                if (isDouble)
                {
                    delayTime = value;
                }
                delayTime = 1.25;
            }
        }

        public void Test()
        {
            w = new StreamWriter(path);
            foreach (string x in validEmailsQ)
            {
                w.WriteLine(x);
            }
            w.Close();
        }

        public async void SendEmail()
        {
            currentReceiver = "temp";

            try
            {
                foreach (string validEmail in validEmailsQ)
                {
                    MailAddress from = new MailAddress(Email);

                    if (currentReceiver == "temp")
                    {
                        currentReceiver = validEmail;
                    }

                    MailAddress to = new MailAddress(currentReceiver);

                    MailMessage email = new MailMessage(from, to);
                    email.Subject = Subject;
                    email.Body = Message;

                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.Credentials = new NetworkCredential(Email, Password);
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.EnableSsl = true;

                    smtp.Send(email);
                    await Task.Delay(TimeSpan.FromSeconds(DelayTime));

                    if (validEmail == "end")
                    {
                        break;
                    }
                    currentReceiver = validEmail;
                    to = new MailAddress(currentReceiver);
                }
            }
            catch (SmtpException ex)
            {
                throw new Exception($"ERROR [002]: Email could not be sent." +
                    $"\nSMTP MSG:\n{ex}");
            }
        }
    }
}
