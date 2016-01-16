using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            ValidateLogInControl();
            //
            MessageBox.Show("Application under maintainance");
        }
        private void ValidateLogInControl()
        {
            //validation
            if (txtuserid.Text == "")
            {
                epuserid.SetError(txtuserid, "Please enter your user id");               
            }
            else
            {
                epuserid.SetError(txtuserid, "");
            }
            if (txtpassword.Text == "")
            {
                epuserid.SetError(txtpassword, "Please enter your password");              
            }
            else
            {
                epuserid.SetError(txtpassword, "");
                
            }          
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            frmRegistration registrationform = new frmRegistration();
            registrationform.Show();
        }

      

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder message = new StringBuilder();
            message.AppendLine("For Application Support  Please contact Helpdesk");
            message.AppendLine("");
            message.Append("+919743576753");
            MessageBox.Show(message.ToString(), "Help");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void applicationVersionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("R12014","Version");
        }

        private void informationOnEMRToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // System.Diagnostics.Process.Start(@"E:\IIITB\Semester-1\DBIS\company_handout.pdf");
            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            System.Diagnostics.Process.Start(path + "\\EMR.pdf");
        }
      
    }
}
