using System;
using System.Windows.Forms;
using MetroFramework.Forms;

using System.Net.Mail;


namespace PestControlManagement
{
    public partial class Mail : MetroForm
    {
        public DataGridViewRow dgvr;
        public Mail()
        {
            InitializeComponent();
        }

        private void mbtnSend_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                MailMessage message = new MailMessage();
                message.From = new MailAddress(mtxtYourEmail.Text);
                message.To.Add(mtxtReciverEmail.Text);
                message.Subject = mtxtSubject.Text;
                message.Body = mtxtBody.Text;
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
                mtxtAttach.Text = S1.ToString();
                if (S1 != null)
                {
                   foreach (string fileName in S1)// what u want to tell :: sry, wait a minut ill get headset ok
                    {
                        message.Attachments.Add(new System.Net.Mail.Attachment(fileName));
                    }                   
                }
               
                    client.Credentials = new System.Net.NetworkCredential(mtxtYourEmail.Text, mtxtpassword.Text);
                    client.Send(message);
                    message = null;
                    MessageBox.Show("Message Send Successfully");
                    //System.Diagnostics.Process.Start("www.google.com"); 
            }
            catch (Exception)
            {

                MessageBox.Show("Message Send Failed");
            }
        }
        string[] S1;
        private void mbtnBrowse_Click(object sender, EventArgs e)
        {
           if( openFileDialog1.ShowDialog()==DialogResult.OK)
           {
               S1 = openFileDialog1.FileNames;               
           }
            
        }

        private void Mail_Load(object sender, EventArgs e)
        {
            mtxtReciverEmail.Text = dgvr.Cells[2].Value.ToString();
        }
    }
}
