namespace Classroom_Management_System
{
    partial class Announcement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Announcement));
            userAnnouncementPanel = new ClassroomManagementSystem.Custom.GreyTransparentPanel();
            announcementDescription = new Label();
            profilePicture = new PictureBox();
            usernameLabel = new Label();
            announcementLabel = new Label();
            announcementContainerPanel = new Panel();
            userAnnouncementPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePicture).BeginInit();
            announcementContainerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // userAnnouncementPanel
            // 
            userAnnouncementPanel.BackColor = Color.White;
            userAnnouncementPanel.Controls.Add(announcementDescription);
            userAnnouncementPanel.Controls.Add(profilePicture);
            userAnnouncementPanel.Controls.Add(usernameLabel);
            userAnnouncementPanel.Location = new Point(33, 30);
            userAnnouncementPanel.Margin = new Padding(2, 1, 2, 1);
            userAnnouncementPanel.Name = "userAnnouncementPanel";
            userAnnouncementPanel.Size = new Size(937, 195);
            userAnnouncementPanel.TabIndex = 2;
            // 
            // announcementDescription
            // 
            announcementDescription.AutoSize = true;
            announcementDescription.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            announcementDescription.Location = new Point(81, 95);
            announcementDescription.Margin = new Padding(2, 0, 2, 0);
            announcementDescription.Name = "announcementDescription";
            announcementDescription.Size = new Size(828, 75);
            announcementDescription.TabIndex = 4;
            announcementDescription.Text = resources.GetString("announcementDescription.Text");
            // 
            // profilePicture
            // 
            profilePicture.BackColor = Color.Transparent;
            profilePicture.BackgroundImage = (Image)resources.GetObject("profilePicture.BackgroundImage");
            profilePicture.BackgroundImageLayout = ImageLayout.Center;
            profilePicture.Location = new Point(32, 12);
            profilePicture.Margin = new Padding(2, 1, 2, 1);
            profilePicture.Name = "profilePicture";
            profilePicture.Size = new Size(85, 69);
            profilePicture.TabIndex = 3;
            profilePicture.TabStop = false;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(121, 41);
            usernameLabel.Margin = new Padding(2, 0, 2, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(124, 29);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Username";
            // 
            // announcementLabel
            // 
            announcementLabel.AutoSize = true;
            announcementLabel.BackColor = Color.Transparent;
            announcementLabel.Font = new Font("Microsoft Sans Serif", 13.8749981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            announcementLabel.Location = new Point(24, 28);
            announcementLabel.Margin = new Padding(2, 0, 2, 0);
            announcementLabel.Name = "announcementLabel";
            announcementLabel.Size = new Size(221, 29);
            announcementLabel.TabIndex = 4;
            announcementLabel.Text = "ANNOUNCEMENT";
            announcementLabel.Click += label5_Click;
            // 
            // announcementContainerPanel
            // 
            announcementContainerPanel.BackgroundImage = Properties.Resources.gradientplaceholder;
            announcementContainerPanel.Controls.Add(userAnnouncementPanel);
            announcementContainerPanel.Location = new Point(46, 79);
            announcementContainerPanel.Margin = new Padding(2, 1, 2, 1);
            announcementContainerPanel.Name = "announcementContainerPanel";
            announcementContainerPanel.Size = new Size(1000, 537);
            announcementContainerPanel.TabIndex = 5;
            // 
            // Announcement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.container;
            Controls.Add(announcementContainerPanel);
            Controls.Add(announcementLabel);
            Margin = new Padding(2, 1, 2, 1);
            MaximumSize = new Size(1107, 645);
            MinimumSize = new Size(1107, 645);
            Name = "Announcement";
            Size = new Size(1107, 645);
            userAnnouncementPanel.ResumeLayout(false);
            userAnnouncementPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profilePicture).EndInit();
            announcementContainerPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ClassroomManagementSystem.Custom.GreyTransparentPanel userAnnouncementPanel;
        private Label usernameLabel;
        private Label announcementLabel;
        private Panel announcementContainerPanel;
        private Label announcementDescription;
        private PictureBox profilePicture;
    }
}
