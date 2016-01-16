namespace WindowsFormsApplication1
{
    partial class frmRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistration));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblregno = new System.Windows.Forms.Label();
            this.lblregistration = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblother = new System.Windows.Forms.Label();
            this.txtother = new System.Windows.Forms.TextBox();
            this.lblphoneprefix = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.lblphone = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.cbostate = new System.Windows.Forms.ComboBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txtpermanemtaddress = new System.Windows.Forms.TextBox();
            this.lblstate = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblpermanentaddress = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblage = new System.Windows.Forms.Label();
            this.numericUpDownage = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerdob = new System.Windows.Forms.DateTimePicker();
            this.radiobtnfemale = new System.Windows.Forms.RadioButton();
            this.radiobtnmale = new System.Windows.Forms.RadioButton();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtfamilyname = new System.Windows.Forms.TextBox();
            this.lblsex = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.lblfamilyname = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownage)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblregno);
            this.panel2.Controls.Add(this.lblregistration);
            this.panel2.Controls.Add(this.btnclear);
            this.panel2.Controls.Add(this.btnclose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.btnsubmit);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(2, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 458);
            this.panel2.TabIndex = 1;
            // 
            // lblregno
            // 
            this.lblregno.AutoSize = true;
            this.lblregno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregno.Location = new System.Drawing.Point(162, 418);
            this.lblregno.Name = "lblregno";
            this.lblregno.Size = new System.Drawing.Size(41, 13);
            this.lblregno.TabIndex = 21;
            this.lblregno.Text = "label3";
            this.lblregno.Visible = false;
            // 
            // lblregistration
            // 
            this.lblregistration.AutoSize = true;
            this.lblregistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregistration.Location = new System.Drawing.Point(24, 418);
            this.lblregistration.Name = "lblregistration";
            this.lblregistration.Size = new System.Drawing.Size(137, 13);
            this.lblregistration.TabIndex = 20;
            this.lblregistration.Text = "Registeration Number :";
            this.lblregistration.Visible = false;
            // 
            // btnclear
            // 
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Location = new System.Drawing.Point(469, 363);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 19;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnclose
            // 
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Location = new System.Drawing.Point(637, 363);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 18;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(24, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Note: * indicates required field";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblother);
            this.groupBox2.Controls.Add(this.txtother);
            this.groupBox2.Controls.Add(this.lblphoneprefix);
            this.groupBox2.Controls.Add(this.txtphone);
            this.groupBox2.Controls.Add(this.lblphone);
            this.groupBox2.Controls.Add(this.txtemail);
            this.groupBox2.Controls.Add(this.lblemail);
            this.groupBox2.Controls.Add(this.cbostate);
            this.groupBox2.Controls.Add(this.txtcity);
            this.groupBox2.Controls.Add(this.txtpermanemtaddress);
            this.groupBox2.Controls.Add(this.lblstate);
            this.groupBox2.Controls.Add(this.lblCity);
            this.groupBox2.Controls.Add(this.lblpermanentaddress);
            this.groupBox2.Location = new System.Drawing.Point(27, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 190);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact Information";
            // 
            // lblother
            // 
            this.lblother.AutoSize = true;
            this.lblother.Location = new System.Drawing.Point(259, 87);
            this.lblother.Name = "lblother";
            this.lblother.Size = new System.Drawing.Size(33, 13);
            this.lblother.TabIndex = 22;
            this.lblother.Text = "Other";
            this.lblother.Click += new System.EventHandler(this.lblother_Click);
            // 
            // txtother
            // 
            this.txtother.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtother.Enabled = false;
            this.txtother.Location = new System.Drawing.Point(299, 84);
            this.txtother.Name = "txtother";
            this.txtother.Size = new System.Drawing.Size(100, 20);
            this.txtother.TabIndex = 21;
            // 
            // lblphoneprefix
            // 
            this.lblphoneprefix.AutoSize = true;
            this.lblphoneprefix.Location = new System.Drawing.Point(111, 150);
            this.lblphoneprefix.Name = "lblphoneprefix";
            this.lblphoneprefix.Size = new System.Drawing.Size(25, 13);
            this.lblphoneprefix.TabIndex = 20;
            this.lblphoneprefix.Text = "+91";
            // 
            // txtphone
            // 
            this.txtphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtphone.Location = new System.Drawing.Point(137, 146);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(203, 20);
            this.txtphone.TabIndex = 20;
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Location = new System.Drawing.Point(18, 149);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(42, 13);
            this.lblphone.TabIndex = 19;
            this.lblphone.Text = "*Phone";
            // 
            // txtemail
            // 
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtemail.Location = new System.Drawing.Point(137, 114);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(203, 20);
            this.txtemail.TabIndex = 18;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(18, 118);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(36, 13);
            this.lblemail.TabIndex = 17;
            this.lblemail.Text = "*Email";
            // 
            // cbostate
            // 
            this.cbostate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cbostate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbostate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbostate.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cbostate.FormattingEnabled = true;
            this.cbostate.Location = new System.Drawing.Point(136, 84);
            this.cbostate.Name = "cbostate";
            this.cbostate.Size = new System.Drawing.Size(105, 21);
            this.cbostate.TabIndex = 16;
            this.cbostate.SelectedIndexChanged += new System.EventHandler(this.cbostate_SelectedIndexChanged);
            // 
            // txtcity
            // 
            this.txtcity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcity.Location = new System.Drawing.Point(136, 55);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(203, 20);
            this.txtcity.TabIndex = 10;
            // 
            // txtpermanemtaddress
            // 
            this.txtpermanemtaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpermanemtaddress.Location = new System.Drawing.Point(136, 24);
            this.txtpermanemtaddress.Name = "txtpermanemtaddress";
            this.txtpermanemtaddress.Size = new System.Drawing.Size(203, 20);
            this.txtpermanemtaddress.TabIndex = 9;
            // 
            // lblstate
            // 
            this.lblstate.AutoSize = true;
            this.lblstate.Location = new System.Drawing.Point(18, 87);
            this.lblstate.Name = "lblstate";
            this.lblstate.Size = new System.Drawing.Size(32, 13);
            this.lblstate.TabIndex = 6;
            this.lblstate.Text = "State";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(20, 56);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 5;
            this.lblCity.Text = "City";
            // 
            // lblpermanentaddress
            // 
            this.lblpermanentaddress.AutoSize = true;
            this.lblpermanentaddress.Location = new System.Drawing.Point(19, 25);
            this.lblpermanentaddress.Name = "lblpermanentaddress";
            this.lblpermanentaddress.Size = new System.Drawing.Size(99, 13);
            this.lblpermanentaddress.TabIndex = 4;
            this.lblpermanentaddress.Text = "Permenant Address";
            // 
            // btnsubmit
            // 
            this.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubmit.Location = new System.Drawing.Point(553, 363);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 5;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btncompleteregisteration_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblage);
            this.groupBox1.Controls.Add(this.numericUpDownage);
            this.groupBox1.Controls.Add(this.dateTimePickerdob);
            this.groupBox1.Controls.Add(this.radiobtnfemale);
            this.groupBox1.Controls.Add(this.radiobtnmale);
            this.groupBox1.Controls.Add(this.txtlastname);
            this.groupBox1.Controls.Add(this.txtfirstname);
            this.groupBox1.Controls.Add(this.txtfamilyname);
            this.groupBox1.Controls.Add(this.lblsex);
            this.groupBox1.Controls.Add(this.lbldob);
            this.groupBox1.Controls.Add(this.lbllastname);
            this.groupBox1.Controls.Add(this.lblfirstname);
            this.groupBox1.Controls.Add(this.lblfamilyname);
            this.groupBox1.Location = new System.Drawing.Point(27, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 162);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Details";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(336, 100);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(30, 13);
            this.lblage.TabIndex = 17;
            this.lblage.Text = "*Age";
            // 
            // numericUpDownage
            // 
            this.numericUpDownage.Location = new System.Drawing.Point(387, 100);
            this.numericUpDownage.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDownage.Name = "numericUpDownage";
            this.numericUpDownage.Size = new System.Drawing.Size(67, 20);
            this.numericUpDownage.TabIndex = 16;
            // 
            // dateTimePickerdob
            // 
            this.dateTimePickerdob.Location = new System.Drawing.Point(137, 100);
            this.dateTimePickerdob.Name = "dateTimePickerdob";
            this.dateTimePickerdob.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerdob.TabIndex = 15;
            // 
            // radiobtnfemale
            // 
            this.radiobtnfemale.AutoSize = true;
            this.radiobtnfemale.Location = new System.Drawing.Point(191, 133);
            this.radiobtnfemale.Name = "radiobtnfemale";
            this.radiobtnfemale.Size = new System.Drawing.Size(59, 17);
            this.radiobtnfemale.TabIndex = 14;
            this.radiobtnfemale.TabStop = true;
            this.radiobtnfemale.Text = "Female";
            this.radiobtnfemale.UseVisualStyleBackColor = true;
            // 
            // radiobtnmale
            // 
            this.radiobtnmale.AutoSize = true;
            this.radiobtnmale.Location = new System.Drawing.Point(137, 133);
            this.radiobtnmale.Name = "radiobtnmale";
            this.radiobtnmale.Size = new System.Drawing.Size(48, 17);
            this.radiobtnmale.TabIndex = 13;
            this.radiobtnmale.TabStop = true;
            this.radiobtnmale.Text = "Male";
            this.radiobtnmale.UseVisualStyleBackColor = true;
            // 
            // txtlastname
            // 
            this.txtlastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlastname.Location = new System.Drawing.Point(137, 74);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(151, 20);
            this.txtlastname.TabIndex = 11;
            // 
            // txtfirstname
            // 
            this.txtfirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfirstname.Location = new System.Drawing.Point(137, 48);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(151, 20);
            this.txtfirstname.TabIndex = 10;
            // 
            // txtfamilyname
            // 
            this.txtfamilyname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfamilyname.Location = new System.Drawing.Point(137, 19);
            this.txtfamilyname.Name = "txtfamilyname";
            this.txtfamilyname.Size = new System.Drawing.Size(151, 20);
            this.txtfamilyname.TabIndex = 9;
            // 
            // lblsex
            // 
            this.lblsex.AutoSize = true;
            this.lblsex.Location = new System.Drawing.Point(25, 133);
            this.lblsex.Name = "lblsex";
            this.lblsex.Size = new System.Drawing.Size(29, 13);
            this.lblsex.TabIndex = 8;
            this.lblsex.Text = "*Sex";
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Location = new System.Drawing.Point(19, 100);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(69, 13);
            this.lbldob.TabIndex = 7;
            this.lbldob.Text = "*Date of birth";
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Location = new System.Drawing.Point(21, 74);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(56, 13);
            this.lbllastname.TabIndex = 6;
            this.lbllastname.Text = "Last name";
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Location = new System.Drawing.Point(21, 48);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(59, 13);
            this.lblfirstname.TabIndex = 5;
            this.lblfirstname.Text = "*First name";
            // 
            // lblfamilyname
            // 
            this.lblfamilyname.AutoSize = true;
            this.lblfamilyname.Location = new System.Drawing.Point(19, 19);
            this.lblfamilyname.Name = "lblfamilyname";
            this.lblfamilyname.Size = new System.Drawing.Size(69, 13);
            this.lblfamilyname.TabIndex = 4;
            this.lblfamilyname.Text = "*Family name";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(926, 24);
            this.menuStrip2.TabIndex = 8;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.aboutToolStripMenuItem.Text = "Menu";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.printToolStripMenuItem.Text = "Export to Excel";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click_1);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToUseToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.howToUseToolStripMenuItem.Text = "Application Support";
            this.howToUseToolStripMenuItem.Click += new System.EventHandler(this.howToUseToolStripMenuItem_Click);
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 485);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistration";
            this.Text = "Patient Registration";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownage)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerdob;
        private System.Windows.Forms.RadioButton radiobtnfemale;
        private System.Windows.Forms.RadioButton radiobtnmale;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtfamilyname;
        private System.Windows.Forms.Label lblsex;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label lblfamilyname;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.TextBox txtpermanemtaddress;
        private System.Windows.Forms.Label lblstate;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblpermanentaddress;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.ComboBox cbostate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.NumericUpDown numericUpDownage;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label lblphoneprefix;
        private System.Windows.Forms.Label lblother;
        private System.Windows.Forms.TextBox txtother;
        private System.Windows.Forms.Label lblregno;
        private System.Windows.Forms.Label lblregistration;
    }
}