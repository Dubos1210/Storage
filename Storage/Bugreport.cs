using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Storage
{
    public partial class Bugreport : Form
    {
        public Bugreport()
        {
            InitializeComponent();
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("no-reply.dubos@yandex.ru");
                mail.To.Add(new MailAddress("software.dubos@yandex.ru"));
                mail.Subject = "Dubos Storage Manager";
                mail.Body = usertxt.Text + " (" + emailtxt.Text + ")\nМодуль: " + modulecombo.Text + "\nВерсия ПО: v" + Properties.Settings.Default.Version + "\n" + abouttxt.Text;
                SmtpClient client = new SmtpClient();
                client.Host = "smtp.yandex.ru";
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("no-reply.dubos@yandex.ru".Split('@')[0], "dubos2017");
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(mail);
                mail.Dispose();
            }
            catch (Exception)
            {
            }
            this.Close();
        }
    }
}
