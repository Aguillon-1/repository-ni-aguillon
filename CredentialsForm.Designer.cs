namespace Classroom_Management_System
{
    partial class CredentialsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CredentialsForm));
            titleLabel = new Label();
            mainPanel = new Panel();
            verificationCredentials1 = new VerificationCredentials();
            credentials1 = new Credentials();
            personalInfoPanel1 = new personalInfoPanel();
            nextButton = new ClassroomManagementSystem.Custom.CustomButton();
            personalInformationLabel = new Label();
            roleConfirmationLabel = new Label();
            verificationLabel = new Label();
            no1Label = new Label();
            no2Label = new Label();
            no3Label = new Label();
            element1 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox14 = new PictureBox();
            pictureBox16 = new PictureBox();
            pictureBox17 = new PictureBox();
            pictureBox15 = new PictureBox();
            pictureBox18 = new PictureBox();
            pictureBox19 = new PictureBox();
            pictureBox20 = new PictureBox();
            backButton = new ClassroomManagementSystem.Custom.CustomButton();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)element1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(325, 22);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(253, 38);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "GETTING STARTED";
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.Transparent;
            mainPanel.BackgroundImage = Properties.Resources.container;
            mainPanel.Controls.Add(backButton);
            mainPanel.Controls.Add(verificationCredentials1);
            mainPanel.Controls.Add(credentials1);
            mainPanel.Controls.Add(personalInfoPanel1);
            mainPanel.Controls.Add(nextButton);
            mainPanel.Location = new Point(108, 192);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(690, 394);
            mainPanel.TabIndex = 1;
            // 
            // verificationCredentials1
            // 
            verificationCredentials1.BackgroundImage = (Image)resources.GetObject("verificationCredentials1.BackgroundImage");
            verificationCredentials1.BackgroundImageLayout = ImageLayout.Stretch;
            verificationCredentials1.Location = new Point(5, 3);
            verificationCredentials1.Name = "verificationCredentials1";
            verificationCredentials1.Size = new Size(682, 319);
            verificationCredentials1.TabIndex = 30;
            // 
            // credentials1
            // 
            credentials1.BackColor = Color.Transparent;
            credentials1.BackgroundImage = (Image)resources.GetObject("credentials1.BackgroundImage");
            credentials1.BackgroundImageLayout = ImageLayout.Stretch;
            credentials1.Location = new Point(3, 3);
            credentials1.Name = "credentials1";
            credentials1.Size = new Size(684, 336);
            credentials1.TabIndex = 2;
            // 
            // personalInfoPanel1
            // 
            personalInfoPanel1.BackgroundImage = (Image)resources.GetObject("personalInfoPanel1.BackgroundImage");
            personalInfoPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            personalInfoPanel1.Location = new Point(3, 3);
            personalInfoPanel1.Name = "personalInfoPanel1";
            personalInfoPanel1.Size = new Size(684, 336);
            personalInfoPanel1.TabIndex = 1;
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.FromArgb(30, 38, 51);
            nextButton.FlatAppearance.BorderColor = Color.White;
            nextButton.FlatAppearance.BorderSize = 0;
            nextButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 51);
            nextButton.FlatStyle = FlatStyle.Flat;
            nextButton.ForeColor = Color.White;
            nextButton.Location = new Point(564, 345);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(111, 36);
            nextButton.TabIndex = 0;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // personalInformationLabel
            // 
            personalInformationLabel.AutoSize = true;
            personalInformationLabel.BackColor = Color.White;
            personalInformationLabel.BorderStyle = BorderStyle.FixedSingle;
            personalInformationLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            personalInformationLabel.Location = new Point(108, 146);
            personalInformationLabel.Name = "personalInformationLabel";
            personalInformationLabel.Size = new Size(195, 30);
            personalInformationLabel.TabIndex = 2;
            personalInformationLabel.Text = "Personal Information";
            // 
            // roleConfirmationLabel
            // 
            roleConfirmationLabel.AutoSize = true;
            roleConfirmationLabel.BackColor = Color.White;
            roleConfirmationLabel.BorderStyle = BorderStyle.FixedSingle;
            roleConfirmationLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roleConfirmationLabel.ForeColor = SystemColors.AppWorkspace;
            roleConfirmationLabel.Location = new Point(309, 146);
            roleConfirmationLabel.Name = "roleConfirmationLabel";
            roleConfirmationLabel.Size = new Size(172, 30);
            roleConfirmationLabel.TabIndex = 3;
            roleConfirmationLabel.Text = "Role Confirmation";
            // 
            // verificationLabel
            // 
            verificationLabel.AutoSize = true;
            verificationLabel.BackColor = Color.White;
            verificationLabel.BorderStyle = BorderStyle.FixedSingle;
            verificationLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            verificationLabel.ForeColor = SystemColors.AppWorkspace;
            verificationLabel.Location = new Point(487, 146);
            verificationLabel.Name = "verificationLabel";
            verificationLabel.Size = new Size(112, 30);
            verificationLabel.TabIndex = 4;
            verificationLabel.Text = "Verification";
            // 
            // no1Label
            // 
            no1Label.AutoSize = true;
            no1Label.BackColor = Color.Transparent;
            no1Label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            no1Label.ForeColor = Color.DarkSlateGray;
            no1Label.Location = new Point(191, 103);
            no1Label.Name = "no1Label";
            no1Label.Size = new Size(24, 28);
            no1Label.TabIndex = 5;
            no1Label.Text = "1";
            // 
            // no2Label
            // 
            no2Label.AutoSize = true;
            no2Label.BackColor = Color.Transparent;
            no2Label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            no2Label.ForeColor = SystemColors.ControlDarkDark;
            no2Label.Location = new Point(384, 103);
            no2Label.Name = "no2Label";
            no2Label.Size = new Size(24, 28);
            no2Label.TabIndex = 6;
            no2Label.Text = "2";
            // 
            // no3Label
            // 
            no3Label.AutoSize = true;
            no3Label.BackColor = Color.Transparent;
            no3Label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            no3Label.ForeColor = SystemColors.ControlDarkDark;
            no3Label.Location = new Point(527, 103);
            no3Label.Name = "no3Label";
            no3Label.Size = new Size(24, 28);
            no3Label.TabIndex = 7;
            no3Label.Text = "3";
            // 
            // element1
            // 
            element1.BackColor = Color.Transparent;
            element1.BackgroundImage = (Image)resources.GetObject("element1.BackgroundImage");
            element1.BackgroundImageLayout = ImageLayout.Zoom;
            element1.Location = new Point(-3, -12);
            element1.Name = "element1";
            element1.Size = new Size(110, 49);
            element1.TabIndex = 8;
            element1.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.BackgroundImage = (Image)resources.GetObject("pictureBox8.BackgroundImage");
            pictureBox8.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox8.Location = new Point(206, 50);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(71, 39);
            pictureBox8.TabIndex = 13;
            pictureBox8.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Location = new Point(75, 103);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(47, 23);
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(793, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 49);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(672, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(71, 39);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(844, 220);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(71, 39);
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(653, 124);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(47, 23);
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(-3, 210);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(110, 49);
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox7.Location = new Point(804, 331);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(110, 49);
            pictureBox7.TabIndex = 20;
            pictureBox7.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.Transparent;
            pictureBox9.BackgroundImage = (Image)resources.GetObject("pictureBox9.BackgroundImage");
            pictureBox9.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox9.Location = new Point(410, 592);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(71, 39);
            pictureBox9.TabIndex = 21;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.Transparent;
            pictureBox10.BackgroundImage = (Image)resources.GetObject("pictureBox10.BackgroundImage");
            pictureBox10.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox10.Location = new Point(856, -3);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(47, 23);
            pictureBox10.TabIndex = 22;
            pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.Transparent;
            pictureBox11.BackgroundImage = (Image)resources.GetObject("pictureBox11.BackgroundImage");
            pictureBox11.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox11.Location = new Point(60, 374);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(47, 23);
            pictureBox11.TabIndex = 23;
            pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.BackColor = Color.Transparent;
            pictureBox12.BackgroundImage = (Image)resources.GetObject("pictureBox12.BackgroundImage");
            pictureBox12.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox12.Location = new Point(856, 571);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(47, 23);
            pictureBox12.TabIndex = 24;
            pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.BackColor = Color.Transparent;
            pictureBox13.BackgroundImage = (Image)resources.GetObject("pictureBox13.BackgroundImage");
            pictureBox13.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox13.Location = new Point(12, 514);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(47, 23);
            pictureBox13.TabIndex = 25;
            pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            pictureBox14.BackColor = Color.Transparent;
            pictureBox14.BackgroundImage = (Image)resources.GetObject("pictureBox14.BackgroundImage");
            pictureBox14.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox14.Location = new Point(64, 579);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(38, 18);
            pictureBox14.TabIndex = 26;
            pictureBox14.TabStop = false;
            // 
            // pictureBox16
            // 
            pictureBox16.BackColor = Color.Transparent;
            pictureBox16.BackgroundImage = (Image)resources.GetObject("pictureBox16.BackgroundImage");
            pictureBox16.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox16.Location = new Point(561, 62);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(71, 39);
            pictureBox16.TabIndex = 28;
            pictureBox16.TabStop = false;
            // 
            // pictureBox17
            // 
            pictureBox17.BackColor = Color.Transparent;
            pictureBox17.BackgroundImage = (Image)resources.GetObject("pictureBox17.BackgroundImage");
            pictureBox17.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox17.Location = new Point(410, 62);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(47, 23);
            pictureBox17.TabIndex = 29;
            pictureBox17.TabStop = false;
            // 
            // pictureBox15
            // 
            pictureBox15.BackColor = Color.Transparent;
            pictureBox15.BackgroundImage = (Image)resources.GetObject("pictureBox15.BackgroundImage");
            pictureBox15.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox15.Location = new Point(225, 600);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(38, 18);
            pictureBox15.TabIndex = 30;
            pictureBox15.TabStop = false;
            // 
            // pictureBox18
            // 
            pictureBox18.BackColor = Color.Transparent;
            pictureBox18.BackgroundImage = (Image)resources.GetObject("pictureBox18.BackgroundImage");
            pictureBox18.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox18.Location = new Point(540, 592);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(38, 18);
            pictureBox18.TabIndex = 31;
            pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            pictureBox19.BackColor = Color.Transparent;
            pictureBox19.BackgroundImage = (Image)resources.GetObject("pictureBox19.BackgroundImage");
            pictureBox19.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox19.Location = new Point(705, 613);
            pictureBox19.Name = "pictureBox19";
            pictureBox19.Size = new Size(38, 18);
            pictureBox19.TabIndex = 32;
            pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            pictureBox20.BackColor = Color.Transparent;
            pictureBox20.BackgroundImage = (Image)resources.GetObject("pictureBox20.BackgroundImage");
            pictureBox20.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox20.Location = new Point(831, 456);
            pictureBox20.Name = "pictureBox20";
            pictureBox20.Size = new Size(47, 23);
            pictureBox20.TabIndex = 33;
            pictureBox20.TabStop = false;
            // 
            // backButton
            // 
            backButton.BackColor = Color.FromArgb(30, 38, 51);
            backButton.FlatAppearance.BorderColor = Color.White;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 51);
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(32, 345);
            backButton.Name = "backButton";
            backButton.Size = new Size(111, 36);
            backButton.TabIndex = 31;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // CredentialsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = Properties.Resources.gradient1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 630);
            Controls.Add(pictureBox20);
            Controls.Add(pictureBox19);
            Controls.Add(pictureBox18);
            Controls.Add(pictureBox15);
            Controls.Add(pictureBox17);
            Controls.Add(pictureBox16);
            Controls.Add(pictureBox14);
            Controls.Add(pictureBox13);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox8);
            Controls.Add(element1);
            Controls.Add(no3Label);
            Controls.Add(no2Label);
            Controls.Add(no1Label);
            Controls.Add(verificationLabel);
            Controls.Add(roleConfirmationLabel);
            Controls.Add(personalInformationLabel);
            Controls.Add(mainPanel);
            Controls.Add(titleLabel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "CredentialsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)element1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Panel mainPanel;
        private Label personalInformationLabel;
        private Label roleConfirmationLabel;
        private Label verificationLabel;
        private Label no1Label;
        private Label no2Label;
        private Label no3Label;
        private PictureBox element1;
        private PictureBox pictureBox8;
        private PictureBox pictureBox6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox7;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox16;
        private PictureBox pictureBox17;
        private ClassroomManagementSystem.Custom.CustomButton nextButton;
        private personalInfoPanel personalInfoPanel1;
        private Credentials credentials1;
        private VerificationCredentials verificationCredentials1;
        private PictureBox pictureBox15;
        private PictureBox pictureBox18;
        private PictureBox pictureBox19;
        private PictureBox pictureBox20;
        private ClassroomManagementSystem.Custom.CustomButton backButton;
    }
}