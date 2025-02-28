namespace Classroom_Management_System
{
    partial class Calendar
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
            calendarControl1 = new CalendarControl();
            SuspendLayout();
            // 
            // calendarControl1
            // 
            calendarControl1.Location = new Point(3, 12);
            calendarControl1.Name = "calendarControl1";
            calendarControl1.Size = new Size(1009, 460);
            calendarControl1.TabIndex = 0;
            calendarControl1.Load += calendarControl1_Load;
            // 
            // Calendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 524);
            Controls.Add(calendarControl1);
            Name = "Calendar";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private CalendarControl calendarControl1;
    }
}