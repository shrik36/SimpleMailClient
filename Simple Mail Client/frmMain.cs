using System;
using System.ComponentModel;
using System.Configuration;
using System.Net.Mail;
using System.Windows.Forms;

namespace Simple_Mail_Client
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        string select = "<Select>";

        void SendMail(string SendTo, string Subject, String Body, string Attachment)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(ConfigurationManager.AppSettings["SMTPServer"]);
                mail.From = new MailAddress(ConfigurationManager.AppSettings["SMTPFromEmailId"]);
                mail.To.Add(SendTo);
                mail.Subject = Subject;
                mail.Body = Body;
                mail.Priority = MailPriority.High;

                if (Attachment.Trim().Length != 0)
                {
                    Attachment attachment = new Attachment(Attachment);
                    mail.Attachments.Add(attachment);
                }

                SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Port = Convert.ToInt32(ConfigurationManager.AppSettings["SMTPPort"]);
                SmtpServer.Credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["SMTPUserId"], ConfigurationManager.AppSettings["SMTPPassword"]);
                SmtpServer.EnableSsl = Convert.ToBoolean(ConfigurationManager.AppSettings["IsSSLEnabled"]);

                SmtpServer.Send(mail);
                MessageBox.Show("Email sent successfully", "Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email:" + ex.Message, "Email not Sent");
            }
        }

        bool Validation()
        {
            if (txtTo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Enter Send-to email (comma separated for multiple receipents) to continue.", "Validation");
                txtTo.Focus();
                return false;
            }
            if (txtCandidateName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Enter the name of candidate to continue.", "Validation");
                txtCandidateName.Focus();
                return false;
            }

            if (ddlHourInterview.SelectedIndex == 0)
            {
                MessageBox.Show("select valid Hour to continue.", "Validation");
                ddlHourInterview.Focus();
                return false;
            }
            if (ddlMinuteInterview.SelectedIndex == 0)
            {
                MessageBox.Show("select valid Minutes to continue.", "Validation");
                ddlMinuteInterview.Focus();
                return false;
            }
            if (ddlAMPMInterview.SelectedIndex == 0)
            {
                MessageBox.Show("select valid AM/PM to continue.", "Validation");
                ddlAMPMInterview.Focus();
                return false;
            }

            if (txtPosition.Text.Trim().Length == 0)
            {
                MessageBox.Show("Enter the position of candidate to continue.", "Validation");
                txtPosition.Focus();
                return false;
            }

            return true;
        }

        void LoadAllDropDowns()
        {
            ddlHourInterview.Items.Clear();
            ddlHourInterview.Items.Add(select);
            for (int i = 1; i <= 12; i++)
            {
                ddlHourInterview.Items.Add(i.ToString("00"));
            }

            ddlMinuteInterview.Items.Clear();
            ddlMinuteInterview.Items.Add(select);
            for (int i = 0; i <= 60; i++)
            {
                ddlMinuteInterview.Items.Add(i.ToString("00"));
            }

            ddlAMPMInterview.Items.Clear();
            ddlAMPMInterview.Items.Add(select);
            ddlAMPMInterview.Items.Add("AM");
            ddlAMPMInterview.Items.Add("PM");
        }

        void ClearControls(Control objCtrl)
        {
            try
            {
                if (objCtrl is TextBox)
                {
                    TextBox objTXT = (TextBox)objCtrl;
                    objTXT.Text = string.Empty;
                }

                if (objCtrl is ComboBox)
                {
                    ComboBox objCMB = (ComboBox)objCtrl;
                    objCMB.Text = string.Empty;
                    if (objCMB.Items.Count > 0)
                        objCMB.SelectedIndex = 0;
                }

                if (objCtrl is DateTimePicker)
                {
                    DateTimePicker objDTP = (DateTimePicker)objCtrl;
                    objDTP.Value = DateTime.Now;
                }

                if ((objCtrl.HasChildren))
                {
                    foreach (Control CurrentChildControl in objCtrl.Controls)
                        ClearControls(CurrentChildControl);
                }
                else
                {
                    txtSubject.Text = ConfigurationManager.AppSettings["MailSubject"];
                    txtTo.Text = ConfigurationManager.AppSettings["To"];
                    progressBar1.MarqueeAnimationSpeed = 30;
                    progressBar1.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("problem clearing all controls (" + objCtrl.Name + "):" + ex.Message.ToString(), "Exception occurred");
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtSubject.ReadOnly = Convert.ToBoolean(ConfigurationManager.AppSettings["IsSubectReadOnly"]);
            LoadAllDropDowns();
            ClearControls(gbMain);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls(gbMain);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if (backgroundWorker1.IsBusy)
                {
                    MessageBox.Show("Current mail in progress, try again after sometime.", "Wait to finish current task");
                }
                else
                {
                    progressBar1.Visible = true;
                    Application.DoEvents();
                    backgroundWorker1.RunWorkerAsync();
                }
            }
        }

        private void txtCandidateName_TextChanged(object sender, EventArgs e)
        {
            //if (txtCandidateName.Text.Trim().Length == 0)
            //{
            //    txtSubject.Text = ConfigurationManager.AppSettings["MailSubject"];
            //}
            //else
            //    txtSubject.Text += txtCandidateName.Text;

            //Application.DoEvents();
        }

        private void dtpDateInterview_ValueChanged(object sender, EventArgs e)
        {
            //txtSubject.Text += ", " + dtpDateInterview.Value.ToShortDateString();
        }

        private void btnClickToBrowse_Click(object sender, EventArgs e)
        {
            //ofdAttachment.InitialDirectory = @"C:\";
            ofdAttachment.Title = "Browse All Files";

            ofdAttachment.Multiselect = false;
            ofdAttachment.CheckFileExists = true;
            ofdAttachment.CheckPathExists = true;
            ofdAttachment.RestoreDirectory = true;
            ofdAttachment.ReadOnlyChecked = true;
            ofdAttachment.ShowReadOnly = true;

            if (ofdAttachment.ShowDialog() == DialogResult.OK)
            {
                txtAttachment.Text = ofdAttachment.FileName;
            }
        }

        private void txtSubject_Enter(object sender, EventArgs e)
        {
            txtSubject.Text = GetSubject();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string body = "";

            body = $@"Interview schedule:

Candidate: {txtCandidateName.Text}
Phone: {txtPhone.Text}
Date: {dtpDateInterview.Value.ToString("dd-MMM-yyyy hh")}
Position: {txtPosition.Text}";

            string subject = GetSubject();
            SendMail(txtTo.Text, subject, body, txtAttachment.Text);
        }

        private string GetTimeString()
        {
            return ddlHourInterview.SelectedItem.ToString() + ":" + ddlMinuteInterview.SelectedItem.ToString() + " " + ddlAMPMInterview.SelectedItem.ToString();
        }

        private string GetSubject()
        {
            return ConfigurationManager.AppSettings["MailSubject"] + txtCandidateName.Text + " - " + dtpDateInterview.Value.ToString("dd-MM-yyyy")
                        + " " + ddlHourInterview.SelectedItem.ToString() + ":" + ddlMinuteInterview.SelectedItem.ToString() + " " + ddlAMPMInterview.SelectedItem.ToString()
                        + " - " + txtPosition.Text.Trim();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                progressBar1.Visible = false;
            }
            catch (Exception)
            {

            }
        }
    }
}
