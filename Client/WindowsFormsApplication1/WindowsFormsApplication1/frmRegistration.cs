using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using EMRPresentationEntity;
using EMRServiceAgent;

namespace WindowsFormsApplication1
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
            loadstateDropdown();
        }
       
        private void btncompleteregisteration_Click(object sender, EventArgs e)
        {
            Boolean validationerror;
            validationerror = validatecontrol();
            if (!validationerror.Equals(true))
            {
                StringBuilder message = new StringBuilder();
                Registration registration = populateDataObject();
                ServiceBroker servicebroker = new ServiceBroker();
                registration = servicebroker.CreateAccount(registration);
                DisableControl();
                message.Append("Registration Successfull!!!");
                message.AppendLine("");
                message.AppendLine("User ID: " + registration.userid);
                message.AppendLine("Password: " + registration.password);
                message.AppendLine("Please consider changing your password immediately");
                MessageBox.Show(message.ToString(), "Alert");
                lblregistration.Visible = true;
                lblregno.Text = registration.userid;
                lblregno.Visible = true;
            }
        }
      
        private bool validatecontrol()
        {
            int errorcnt = 0;
            Boolean Iserror = false;
            StringBuilder errormessage = new StringBuilder();
            errormessage.Append("Following fields cannot be empty");
            if (txtfirstname.Text == "")
            {
                errorcnt++;
                errormessage.AppendLine("");
                errormessage.Append(errorcnt + ":Firstname");
                Iserror = true;
            }
            if (txtphone.Text == "")
            {
                errorcnt++;
                errormessage.AppendLine("");
                errormessage.Append(errorcnt + ":Phone");
                Iserror = true;
            }
            else if (!CheckPhoneNumber(txtphone.Text))
            {
                errorcnt++;
                errormessage.AppendLine("");
                errormessage.Append(errorcnt + ":Phone number is invalid");
                Iserror = true;
            }
            if (txtemail.Text == "" || !txtemail.Text.Contains("@"))
            {
                errorcnt++;
                errormessage.AppendLine("");
                errormessage.Append(errorcnt + ":Email cannot be empty or invalid");
                Iserror = true;
            }
            if (numericUpDownage.Value == 0)
            {
                errorcnt++;
                errormessage.AppendLine("");
                errormessage.Append(errorcnt + ":Age");
                Iserror = true;
            }
            if (radiobtnfemale.Checked == false && radiobtnmale.Checked == false)
            {
                errorcnt++;
                errormessage.AppendLine("");
                errormessage.Append(errorcnt + ":Sex");
                Iserror = true;
            }
            if (Iserror == true)
            {
                MessageBox.Show(errormessage.ToString(),"Required!!!");
            }
            return Iserror;
        }
        public bool CheckPhoneNumber(string strPhoneNumber)
        {
            string MatchPhoneNumberPattern = "^\\d{10}$";
         if (strPhoneNumber!= null) return Regex.IsMatch(strPhoneNumber, MatchPhoneNumberPattern );
         else return false;
         }
        private Registration populateDataObject()
        {
            Registration registration = new Registration();
            registration.familyName = txtfamilyname.Text;
            registration.firstName = txtfirstname.Text;
            registration.lastName = txtlastname.Text;
            registration.phone = txtphone.Text;
            registration.address = txtpermanemtaddress.Text;
            registration.sex = radiobtnfemale.Checked? "F":"M";
            registration.dob = dateTimePickerdob.Value;
            registration.email = txtemail.Text;
            registration.city = txtcity.Text;
            registration.age = numericUpDownage.Value.ToString();
            registration.state = (!txtother.Enabled)?cbostate.SelectedItem.ToString():txtother.Text;
            return registration;
        }
        private void DisableControl()
        {
            txtfamilyname.Enabled = false;
            txtfirstname.Enabled = false;
            txtlastname.Enabled = false;
            radiobtnfemale.Enabled = false;
            radiobtnmale.Enabled = false;
            dateTimePickerdob.Enabled = false;
            numericUpDownage.Enabled = false;
            txtpermanemtaddress.Enabled = false;
            txtcity.Enabled = false;
            txtother.Enabled = false;
            cbostate.Enabled = false;
            txtemail.Enabled = false;
            txtphone.Enabled = false;
            btnsubmit.Enabled = false;
            
        }
        private void EnableControl()
        {
            txtfamilyname.Enabled = true;
            txtfirstname.Enabled = true;
            txtlastname.Enabled = true;
            radiobtnfemale.Enabled = true;
            radiobtnmale.Enabled = true;
            dateTimePickerdob.Enabled = true;
            numericUpDownage.Enabled = true;
            txtpermanemtaddress.Enabled = true;
            txtcity.Enabled = true;
            cbostate.Enabled = true;
            txtemail.Enabled = true;
            txtphone.Enabled = true;
            btnsubmit.Enabled = true;

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Clearcontrol();
            EnableControl();
            
        }
        private void Clearcontrol()
        {
            txtfamilyname.ResetText();
            txtfirstname.ResetText();
            txtlastname.ResetText();
            radiobtnfemale.Checked = false;
            radiobtnmale.Checked = false;
            txtother.Enabled = false;
            txtother.ResetText();
            dateTimePickerdob.ResetText();
            numericUpDownage.Value = 0;
            txtpermanemtaddress.ResetText();
            txtcity.ResetText();
            cbostate.ResetText();
            txtemail.ResetText();
            txtphone.ResetText();
            lblregno.ResetText();
            lblregno.Visible = false;
            lblregistration.Visible = false;
           
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void informationOnEMRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clearcontrol();
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder message = new StringBuilder();
            message.AppendLine("For Application Support  Please contact Helpdesk");
            message.AppendLine("");
            message.Append("+919743576753");
            MessageBox.Show(message.ToString(), "Help");
        }

        private void closeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void loadstateDropdown()
        {
            List<string> statelist = new List<string>();
            statelist.Add("");
            statelist.Add("KA");
            statelist.Add("TN");
            statelist.Add("MH");
            statelist.Add("AP");
            statelist.Add("GJ");
            statelist.Add("MP");
            statelist.Add("CH");
            statelist.Add("HR");
            statelist.Add("PB");
            statelist.Add("GA");
            statelist.Add("JK");
            statelist.Add("WB");
            statelist.Add("NL");
            statelist.Add("OR");
            statelist.Add("KL");
            statelist.Add("RJ");
            statelist.Add("NCR");
            statelist.Add("PY");
            statelist.Add("HP");
            statelist.Add("UP");
            statelist.Add("BR");
            statelist.Add("UL");
            statelist.Add("Other");
            cbostate.DataSource = statelist;
        }

        private void lblother_Click(object sender, EventArgs e)
        {

        }

        private void cbostate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbostate.SelectedItem.ToString().ToUpper().Equals("OTHER"))
            {
                txtother.Enabled = true;
            }
        }

       

       
       
    }
}
