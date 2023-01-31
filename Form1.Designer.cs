namespace AutoMail
{
    partial class AutoMail
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoMail));
            this.label1 = new System.Windows.Forms.Label();
            this.pathInput = new System.Windows.Forms.TextBox();
            this.fileExpOpen = new System.Windows.Forms.Button();
            this.sender = new System.Windows.Forms.Button();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.subjectInput = new System.Windows.Forms.TextBox();
            this.pwInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.newsGB = new System.Windows.Forms.GroupBox();
            this.newsLable1 = new System.Windows.Forms.Label();
            this.newsLabel = new System.Windows.Forms.Label();
            this.closeNewsGB = new System.Windows.Forms.Button();
            this.githubProfile = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.attachFile = new System.Windows.Forms.Button();
            this.darkMode = new System.Windows.Forms.Button();
            this.viewPw = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.msgInputRich = new System.Windows.Forms.RichTextBox();
            this.tDelayInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.newsGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text File:";
            // 
            // pathInput
            // 
            this.pathInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.pathInput.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathInput.Location = new System.Drawing.Point(101, 18);
            this.pathInput.Name = "pathInput";
            this.pathInput.Size = new System.Drawing.Size(817, 27);
            this.pathInput.TabIndex = 1;
            this.pathInput.TextChanged += new System.EventHandler(this.pathInput_TextChanged);
            // 
            // fileExpOpen
            // 
            this.fileExpOpen.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fileExpOpen.FlatAppearance.BorderSize = 0;
            this.fileExpOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileExpOpen.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileExpOpen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileExpOpen.Location = new System.Drawing.Point(924, 18);
            this.fileExpOpen.Name = "fileExpOpen";
            this.fileExpOpen.Size = new System.Drawing.Size(43, 27);
            this.fileExpOpen.TabIndex = 2;
            this.fileExpOpen.Text = "...";
            this.fileExpOpen.UseVisualStyleBackColor = false;
            this.fileExpOpen.Click += new System.EventHandler(this.fileExpOpen_Click);
            this.fileExpOpen.MouseHover += new System.EventHandler(this.fileExpOpen_MouseHover);
            // 
            // sender
            // 
            this.sender.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sender.FlatAppearance.BorderSize = 0;
            this.sender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sender.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sender.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sender.Location = new System.Drawing.Point(854, 541);
            this.sender.Name = "sender";
            this.sender.Size = new System.Drawing.Size(113, 50);
            this.sender.TabIndex = 3;
            this.sender.Text = "📨";
            this.sender.UseVisualStyleBackColor = false;
            this.sender.Click += new System.EventHandler(this.sender_Click);
            this.sender.MouseHover += new System.EventHandler(this.sender_MouseHover);
            // 
            // emailInput
            // 
            this.emailInput.AllowDrop = true;
            this.emailInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.emailInput.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailInput.Location = new System.Drawing.Point(101, 51);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(182, 27);
            this.emailInput.TabIndex = 5;
            this.emailInput.TextChanged += new System.EventHandler(this.emailInput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Message:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(590, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Subject:";
            // 
            // subjectInput
            // 
            this.subjectInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.subjectInput.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectInput.Location = new System.Drawing.Point(672, 51);
            this.subjectInput.Name = "subjectInput";
            this.subjectInput.Size = new System.Drawing.Size(246, 27);
            this.subjectInput.TabIndex = 9;
            this.subjectInput.Text = " ";
            this.subjectInput.TextChanged += new System.EventHandler(this.subjectInput_TextChanged);
            // 
            // pwInput
            // 
            this.pwInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.pwInput.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwInput.Location = new System.Drawing.Point(391, 51);
            this.pwInput.Name = "pwInput";
            this.pwInput.Size = new System.Drawing.Size(164, 27);
            this.pwInput.TabIndex = 11;
            this.pwInput.TextChanged += new System.EventHandler(this.pwInput_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(291, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password:";
            // 
            // newsGB
            // 
            this.newsGB.Controls.Add(this.newsLable1);
            this.newsGB.Controls.Add(this.newsLabel);
            this.newsGB.Controls.Add(this.closeNewsGB);
            this.newsGB.Controls.Add(this.githubProfile);
            this.newsGB.Controls.Add(this.label6);
            this.newsGB.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsGB.Location = new System.Drawing.Point(565, 105);
            this.newsGB.Name = "newsGB";
            this.newsGB.Size = new System.Drawing.Size(402, 429);
            this.newsGB.TabIndex = 12;
            this.newsGB.TabStop = false;
            this.newsGB.Text = "What\'s new? 0.0.1";
            this.newsGB.Enter += new System.EventHandler(this.newsGB_Enter);
            // 
            // newsLable1
            // 
            this.newsLable1.AutoSize = true;
            this.newsLable1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsLable1.Location = new System.Drawing.Point(17, 86);
            this.newsLable1.Name = "newsLable1";
            this.newsLable1.Size = new System.Drawing.Size(50, 19);
            this.newsLable1.TabIndex = 4;
            this.newsLable1.Text = "label7";
            this.newsLable1.Click += new System.EventHandler(this.newsLable1_Click);
            // 
            // newsLabel
            // 
            this.newsLabel.AutoSize = true;
            this.newsLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsLabel.Location = new System.Drawing.Point(10, 81);
            this.newsLabel.Name = "newsLabel";
            this.newsLabel.Size = new System.Drawing.Size(0, 19);
            this.newsLabel.TabIndex = 3;
            // 
            // closeNewsGB
            // 
            this.closeNewsGB.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.closeNewsGB.FlatAppearance.BorderSize = 0;
            this.closeNewsGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeNewsGB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.closeNewsGB.Location = new System.Drawing.Point(369, 15);
            this.closeNewsGB.Name = "closeNewsGB";
            this.closeNewsGB.Size = new System.Drawing.Size(30, 30);
            this.closeNewsGB.TabIndex = 2;
            this.closeNewsGB.Text = "✖️";
            this.closeNewsGB.UseVisualStyleBackColor = false;
            this.closeNewsGB.Click += new System.EventHandler(this.closeNewsGB_Click);
            // 
            // githubProfile
            // 
            this.githubProfile.AutoSize = true;
            this.githubProfile.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.githubProfile.Location = new System.Drawing.Point(11, 55);
            this.githubProfile.Name = "githubProfile";
            this.githubProfile.Size = new System.Drawing.Size(117, 16);
            this.githubProfile.TabIndex = 1;
            this.githubProfile.TabStop = true;
            this.githubProfile.Text = "My Github Profile";
            this.githubProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubProfile_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Initial version release (Github Version)";
            // 
            // attachFile
            // 
            this.attachFile.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.attachFile.FlatAppearance.BorderSize = 0;
            this.attachFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attachFile.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attachFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.attachFile.Location = new System.Drawing.Point(16, 540);
            this.attachFile.Name = "attachFile";
            this.attachFile.Size = new System.Drawing.Size(50, 50);
            this.attachFile.TabIndex = 13;
            this.attachFile.Text = "📁";
            this.attachFile.UseVisualStyleBackColor = false;
            this.attachFile.Click += new System.EventHandler(this.attachFile_Click);
            this.attachFile.MouseHover += new System.EventHandler(this.attachFile_MouseHover);
            // 
            // darkMode
            // 
            this.darkMode.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.darkMode.FlatAppearance.BorderSize = 0;
            this.darkMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.darkMode.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkMode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.darkMode.Location = new System.Drawing.Point(505, 540);
            this.darkMode.Name = "darkMode";
            this.darkMode.Size = new System.Drawing.Size(50, 50);
            this.darkMode.TabIndex = 14;
            this.darkMode.Text = "☾";
            this.darkMode.UseVisualStyleBackColor = false;
            this.darkMode.Click += new System.EventHandler(this.darkMode_Click);
            this.darkMode.MouseHover += new System.EventHandler(this.darkMode_MouseHover);
            // 
            // viewPw
            // 
            this.viewPw.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.viewPw.FlatAppearance.BorderSize = 0;
            this.viewPw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewPw.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPw.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewPw.Location = new System.Drawing.Point(562, 51);
            this.viewPw.Name = "viewPw";
            this.viewPw.Size = new System.Drawing.Size(27, 27);
            this.viewPw.TabIndex = 15;
            this.viewPw.Text = "👁️";
            this.viewPw.UseVisualStyleBackColor = false;
            this.viewPw.Click += new System.EventHandler(this.viewPw_Click);
            this.viewPw.MouseHover += new System.EventHandler(this.viewPw_MouseHover);
            // 
            // msgInputRich
            // 
            this.msgInputRich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.msgInputRich.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgInputRich.Location = new System.Drawing.Point(16, 105);
            this.msgInputRich.Name = "msgInputRich";
            this.msgInputRich.Size = new System.Drawing.Size(539, 428);
            this.msgInputRich.TabIndex = 16;
            this.msgInputRich.Text = "";
            this.msgInputRich.TextChanged += new System.EventHandler(this.msgInputRich_TextChanged);
            // 
            // tDelayInput
            // 
            this.tDelayInput.AllowDrop = true;
            this.tDelayInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.tDelayInput.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDelayInput.Location = new System.Drawing.Point(762, 556);
            this.tDelayInput.Name = "tDelayInput";
            this.tDelayInput.Size = new System.Drawing.Size(63, 27);
            this.tDelayInput.TabIndex = 17;
            this.tDelayInput.Text = "1.25";
            this.tDelayInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(704, 558);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Delay:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(831, 558);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "s";
            // 
            // AutoMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(979, 603);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tDelayInput);
            this.Controls.Add(this.msgInputRich);
            this.Controls.Add(this.viewPw);
            this.Controls.Add(this.darkMode);
            this.Controls.Add(this.attachFile);
            this.Controls.Add(this.newsGB);
            this.Controls.Add(this.pwInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.subjectInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.sender);
            this.Controls.Add(this.fileExpOpen);
            this.Controls.Add(this.pathInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AutoMail";
            this.Text = "AutoMail";
            this.Load += new System.EventHandler(this.AutoMail_Load);
            this.newsGB.ResumeLayout(false);
            this.newsGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathInput;
        private System.Windows.Forms.Button fileExpOpen;
        private System.Windows.Forms.Button sender;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox subjectInput;
        private System.Windows.Forms.TextBox pwInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox newsGB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel githubProfile;
        private System.Windows.Forms.Button closeNewsGB;
        private System.Windows.Forms.Button attachFile;
        private System.Windows.Forms.Button darkMode;
        private System.Windows.Forms.Button viewPw;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RichTextBox msgInputRich;
        private System.Windows.Forms.Label newsLabel;
        private System.Windows.Forms.Label newsLable1;
        private System.Windows.Forms.TextBox tDelayInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

