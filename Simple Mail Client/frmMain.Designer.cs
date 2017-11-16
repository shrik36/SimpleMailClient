namespace Simple_Mail_Client
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTo = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtCandidateName = new System.Windows.Forms.TextBox();
            this.lblCandidateName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAttachment = new System.Windows.Forms.Label();
            this.dtpDateInterview = new System.Windows.Forms.DateTimePicker();
            this.ddlHourInterview = new System.Windows.Forms.ComboBox();
            this.ddlMinuteInterview = new System.Windows.Forms.ComboBox();
            this.ddlAMPMInterview = new System.Windows.Forms.ComboBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAttachment = new System.Windows.Forms.TextBox();
            this.btnClickToBrowse = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ofdAttachment = new System.Windows.Forms.OpenFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(84, 28);
            this.lblTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(45, 18);
            this.lblTo.TabIndex = 0;
            this.lblTo.Text = "To (s):";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(131, 25);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(788, 26);
            this.txtTo.TabIndex = 0;
            // 
            // txtCandidateName
            // 
            this.txtCandidateName.Location = new System.Drawing.Point(131, 62);
            this.txtCandidateName.Name = "txtCandidateName";
            this.txtCandidateName.Size = new System.Drawing.Size(788, 26);
            this.txtCandidateName.TabIndex = 1;
            this.txtCandidateName.TextChanged += new System.EventHandler(this.txtCandidateName_TextChanged);
            // 
            // lblCandidateName
            // 
            this.lblCandidateName.AutoSize = true;
            this.lblCandidateName.Location = new System.Drawing.Point(14, 64);
            this.lblCandidateName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCandidateName.Name = "lblCandidateName";
            this.lblCandidateName.Size = new System.Drawing.Size(115, 18);
            this.lblCandidateName.TabIndex = 2;
            this.lblCandidateName.Text = "Candidate Name:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(9, 100);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(120, 18);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date of Interview:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Time of Interview:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Position:";
            // 
            // lblAttachment
            // 
            this.lblAttachment.AutoSize = true;
            this.lblAttachment.Location = new System.Drawing.Point(40, 279);
            this.lblAttachment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttachment.Name = "lblAttachment";
            this.lblAttachment.Size = new System.Drawing.Size(85, 18);
            this.lblAttachment.TabIndex = 7;
            this.lblAttachment.Text = "Attachment:";
            // 
            // dtpDateInterview
            // 
            this.dtpDateInterview.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateInterview.Location = new System.Drawing.Point(131, 98);
            this.dtpDateInterview.Name = "dtpDateInterview";
            this.dtpDateInterview.Size = new System.Drawing.Size(167, 26);
            this.dtpDateInterview.TabIndex = 2;
            this.dtpDateInterview.ValueChanged += new System.EventHandler(this.dtpDateInterview_ValueChanged);
            // 
            // ddlHourInterview
            // 
            this.ddlHourInterview.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlHourInterview.FormattingEnabled = true;
            this.ddlHourInterview.Location = new System.Drawing.Point(131, 135);
            this.ddlHourInterview.Name = "ddlHourInterview";
            this.ddlHourInterview.Size = new System.Drawing.Size(77, 26);
            this.ddlHourInterview.TabIndex = 3;
            // 
            // ddlMinuteInterview
            // 
            this.ddlMinuteInterview.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMinuteInterview.FormattingEnabled = true;
            this.ddlMinuteInterview.Location = new System.Drawing.Point(239, 134);
            this.ddlMinuteInterview.Name = "ddlMinuteInterview";
            this.ddlMinuteInterview.Size = new System.Drawing.Size(77, 26);
            this.ddlMinuteInterview.TabIndex = 4;
            // 
            // ddlAMPMInterview
            // 
            this.ddlAMPMInterview.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlAMPMInterview.FormattingEnabled = true;
            this.ddlAMPMInterview.Location = new System.Drawing.Point(349, 134);
            this.ddlAMPMInterview.Name = "ddlAMPMInterview";
            this.ddlAMPMInterview.Size = new System.Drawing.Size(77, 26);
            this.ddlAMPMInterview.TabIndex = 5;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(131, 170);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(788, 26);
            this.txtPosition.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Hr";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 139);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "AM/PM";
            // 
            // txtAttachment
            // 
            this.txtAttachment.Location = new System.Drawing.Point(131, 276);
            this.txtAttachment.Name = "txtAttachment";
            this.txtAttachment.ReadOnly = true;
            this.txtAttachment.Size = new System.Drawing.Size(788, 26);
            this.txtAttachment.TabIndex = 9;
            // 
            // btnClickToBrowse
            // 
            this.btnClickToBrowse.Location = new System.Drawing.Point(920, 276);
            this.btnClickToBrowse.Name = "btnClickToBrowse";
            this.btnClickToBrowse.Size = new System.Drawing.Size(114, 26);
            this.btnClickToBrowse.TabIndex = 8;
            this.btnClickToBrowse.Text = "Click to Browse";
            this.btnClickToBrowse.UseVisualStyleBackColor = true;
            this.btnClickToBrowse.Click += new System.EventHandler(this.btnClickToBrowse_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(297, 347);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(185, 39);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(497, 347);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(185, 39);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.txtPhone);
            this.gbMain.Controls.Add(this.lblPhone);
            this.gbMain.Controls.Add(this.txtSubject);
            this.gbMain.Controls.Add(this.label7);
            this.gbMain.Controls.Add(this.txtTo);
            this.gbMain.Controls.Add(this.lblTo);
            this.gbMain.Controls.Add(this.btnClickToBrowse);
            this.gbMain.Controls.Add(this.lblCandidateName);
            this.gbMain.Controls.Add(this.txtAttachment);
            this.gbMain.Controls.Add(this.txtCandidateName);
            this.gbMain.Controls.Add(this.label6);
            this.gbMain.Controls.Add(this.lblDate);
            this.gbMain.Controls.Add(this.label4);
            this.gbMain.Controls.Add(this.label1);
            this.gbMain.Controls.Add(this.txtPosition);
            this.gbMain.Controls.Add(this.label2);
            this.gbMain.Controls.Add(this.ddlAMPMInterview);
            this.gbMain.Controls.Add(this.lblAttachment);
            this.gbMain.Controls.Add(this.ddlMinuteInterview);
            this.gbMain.Controls.Add(this.dtpDateInterview);
            this.gbMain.Controls.Add(this.ddlHourInterview);
            this.gbMain.Controls.Add(this.label5);
            this.gbMain.Location = new System.Drawing.Point(13, 0);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(1041, 338);
            this.gbMain.TabIndex = 0;
            this.gbMain.TabStop = false;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(131, 205);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(788, 26);
            this.txtPhone.TabIndex = 7;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(77, 208);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(52, 18);
            this.lblPhone.TabIndex = 19;
            this.lblPhone.Text = "Phone:";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(131, 240);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.ReadOnly = true;
            this.txtSubject.Size = new System.Drawing.Size(788, 26);
            this.txtSubject.TabIndex = 8;
            this.txtSubject.Enter += new System.EventHandler(this.txtSubject_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 242);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Subject:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(793, 344);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(261, 16);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 3;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(1071, 395);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSend);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Client By SS";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtCandidateName;
        private System.Windows.Forms.Label lblCandidateName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAttachment;
        private System.Windows.Forms.DateTimePicker dtpDateInterview;
        private System.Windows.Forms.ComboBox ddlHourInterview;
        private System.Windows.Forms.ComboBox ddlMinuteInterview;
        private System.Windows.Forms.ComboBox ddlAMPMInterview;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAttachment;
        private System.Windows.Forms.Button btnClickToBrowse;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.OpenFileDialog ofdAttachment;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

