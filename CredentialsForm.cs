using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classroom_Management_System
{
    public partial class CredentialsForm : Form
    {
        public CredentialsForm()
        {
            InitializeComponent();
            personalInfoPanel1.BringToFront();
            backButton.Hide();
        }

        private int verifno = 1;

        private void nextButton_Click(object sender, EventArgs e)
        {
            
            
            verifno++;
            backButton.Show();

            if (verifno == 2)
            {
                personalInfoPanel1.Hide();
                credentials1.BringToFront();
                CredentialTwo();
            }

            else if (verifno == 3)
            {
                credentials1.Hide();
                verificationCredentials1.BringToFront();
                nextButton.Text = "Submit";
                CredentialThree();
            }

            else if (verifno == 4)
            {
                HomeForm home = new HomeForm();
                home.Show();
                this.Hide();
            }

        }

        private void CredentialOne()
        {
            personalInformationLabel.ForeColor = Color.Black;
            no1Label.ForeColor = Color.DarkSlateGray;
            roleConfirmationLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            no2Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
        }

        private void CredentialTwo()
        {
            personalInformationLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            no1Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            roleConfirmationLabel.ForeColor = Color.Black;
            no2Label.ForeColor = Color.DarkSlateGray;
        }

        private void CredentialThree()
        {
            roleConfirmationLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            no2Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            verificationLabel.ForeColor = Color.Black;
            no3Label.ForeColor = Color.DarkSlateGray;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            verifno--;
            
            if (verifno == 2) 
            {
                credentials1.BringToFront();
                CredentialTwo();
                verificationCredentials1.Hide();
            }

            if (verifno == 1) 
            {
                backButton.Hide();
                personalInfoPanel1.BringToFront();
                CredentialOne();
                credentials1.Hide();
            }

        }
    }
}
