namespace AdministracionDeEmpleados
{
    partial class SeeEmployeeSearch
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboSearchHow = new System.Windows.Forms.ComboBox();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbInpu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.inpSalary = new System.Windows.Forms.TextBox();
            this.inpLastName = new System.Windows.Forms.TextBox();
            this.inpPosition = new System.Windows.Forms.TextBox();
            this.inpName = new System.Windows.Forms.TextBox();
            this.inpEmail = new System.Windows.Forms.TextBox();
            this.inpPassword = new System.Windows.Forms.TextBox();
            this.inpCC = new System.Windows.Forms.TextBox();
            this.cmbAdmins = new System.Windows.Forms.ComboBox();
            this.lbRegistre = new System.Windows.Forms.Label();
            this.cmbActives = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.inpPhone = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(159, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search How:";
            // 
            // comboSearchHow
            // 
            this.comboSearchHow.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.comboSearchHow.FormattingEnabled = true;
            this.comboSearchHow.Items.AddRange(new object[] {
            "Email",
            "Id",
            "CC"});
            this.comboSearchHow.Location = new System.Drawing.Point(381, 25);
            this.comboSearchHow.Name = "comboSearchHow";
            this.comboSearchHow.Size = new System.Drawing.Size(284, 33);
            this.comboSearchHow.TabIndex = 1;
            this.comboSearchHow.SelectedIndexChanged += new System.EventHandler(this.comboSearchHow_SelectedIndexChanged);
            // 
            // searchTxt
            // 
            this.searchTxt.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.searchTxt.Location = new System.Drawing.Point(448, 95);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(217, 35);
            this.searchTxt.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(557, 147);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 34);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbInpu
            // 
            this.lbInpu.AutoSize = true;
            this.lbInpu.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.lbInpu.ForeColor = System.Drawing.Color.White;
            this.lbInpu.Location = new System.Drawing.Point(159, 98);
            this.lbInpu.Name = "lbInpu";
            this.lbInpu.Size = new System.Drawing.Size(0, 25);
            this.lbInpu.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(409, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(409, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(44, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Position:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(409, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Salary:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(44, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Active:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(409, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Password:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(44, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Admin:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(44, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "CC:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(409, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "N. Registre:";
            // 
            // inpSalary
            // 
            this.inpSalary.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.inpSalary.Location = new System.Drawing.Point(559, 306);
            this.inpSalary.Name = "inpSalary";
            this.inpSalary.Size = new System.Drawing.Size(217, 35);
            this.inpSalary.TabIndex = 25;
            // 
            // inpLastName
            // 
            this.inpLastName.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.inpLastName.Location = new System.Drawing.Point(559, 195);
            this.inpLastName.Name = "inpLastName";
            this.inpLastName.Size = new System.Drawing.Size(217, 35);
            this.inpLastName.TabIndex = 27;
            // 
            // inpPosition
            // 
            this.inpPosition.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.inpPosition.Location = new System.Drawing.Point(164, 420);
            this.inpPosition.Name = "inpPosition";
            this.inpPosition.Size = new System.Drawing.Size(217, 35);
            this.inpPosition.TabIndex = 28;
            // 
            // inpName
            // 
            this.inpName.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.inpName.Location = new System.Drawing.Point(164, 195);
            this.inpName.Name = "inpName";
            this.inpName.Size = new System.Drawing.Size(217, 35);
            this.inpName.TabIndex = 31;
            // 
            // inpEmail
            // 
            this.inpEmail.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.inpEmail.Location = new System.Drawing.Point(560, 365);
            this.inpEmail.Name = "inpEmail";
            this.inpEmail.Size = new System.Drawing.Size(217, 35);
            this.inpEmail.TabIndex = 32;
            // 
            // inpPassword
            // 
            this.inpPassword.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.inpPassword.Location = new System.Drawing.Point(560, 420);
            this.inpPassword.Name = "inpPassword";
            this.inpPassword.Size = new System.Drawing.Size(217, 35);
            this.inpPassword.TabIndex = 33;
            // 
            // inpCC
            // 
            this.inpCC.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.inpCC.Location = new System.Drawing.Point(164, 365);
            this.inpCC.Name = "inpCC";
            this.inpCC.Size = new System.Drawing.Size(217, 35);
            this.inpCC.TabIndex = 34;
            // 
            // cmbAdmins
            // 
            this.cmbAdmins.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.cmbAdmins.FormattingEnabled = true;
            this.cmbAdmins.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cmbAdmins.Location = new System.Drawing.Point(164, 255);
            this.cmbAdmins.Name = "cmbAdmins";
            this.cmbAdmins.Size = new System.Drawing.Size(217, 33);
            this.cmbAdmins.TabIndex = 35;
            // 
            // lbRegistre
            // 
            this.lbRegistre.AutoSize = true;
            this.lbRegistre.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.lbRegistre.ForeColor = System.Drawing.Color.White;
            this.lbRegistre.Location = new System.Drawing.Point(555, 258);
            this.lbRegistre.Name = "lbRegistre";
            this.lbRegistre.Size = new System.Drawing.Size(194, 25);
            this.lbRegistre.TabIndex = 36;
            this.lbRegistre.Text = "N. Registre_Text";
            // 
            // cmbActives
            // 
            this.cmbActives.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.cmbActives.FormattingEnabled = true;
            this.cmbActives.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cmbActives.Location = new System.Drawing.Point(164, 308);
            this.cmbActives.Name = "cmbActives";
            this.cmbActives.Size = new System.Drawing.Size(217, 33);
            this.cmbActives.TabIndex = 37;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(598, 491);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 44);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.lbID.ForeColor = System.Drawing.Color.White;
            this.lbID.Location = new System.Drawing.Point(44, 150);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(39, 25);
            this.lbID.TabIndex = 39;
            this.lbID.Text = "ID";
            // 
            // inpPhone
            // 
            this.inpPhone.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.inpPhone.Location = new System.Drawing.Point(164, 479);
            this.inpPhone.Name = "inpPhone";
            this.inpPhone.Size = new System.Drawing.Size(217, 35);
            this.inpPhone.TabIndex = 41;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(44, 482);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 25);
            this.label14.TabIndex = 40;
            this.label14.Text = "Phone:";
            // 
            // SeeEmployeeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(841, 559);
            this.Controls.Add(this.inpPhone);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbActives);
            this.Controls.Add(this.lbRegistre);
            this.Controls.Add(this.cmbAdmins);
            this.Controls.Add(this.inpCC);
            this.Controls.Add(this.inpPassword);
            this.Controls.Add(this.inpEmail);
            this.Controls.Add(this.inpName);
            this.Controls.Add(this.inpPosition);
            this.Controls.Add(this.inpLastName);
            this.Controls.Add(this.inpSalary);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbInpu);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.comboSearchHow);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeeEmployeeSearch";
            this.Text = "SeeEmployeeSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboSearchHow;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbInpu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox inpSalary;
        private System.Windows.Forms.TextBox inpLastName;
        private System.Windows.Forms.TextBox inpPosition;
        private System.Windows.Forms.TextBox inpName;
        private System.Windows.Forms.TextBox inpEmail;
        private System.Windows.Forms.TextBox inpPassword;
        private System.Windows.Forms.TextBox inpCC;
        private System.Windows.Forms.ComboBox cmbAdmins;
        private System.Windows.Forms.Label lbRegistre;
        private System.Windows.Forms.ComboBox cmbActives;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox inpPhone;
        private System.Windows.Forms.Label label14;
    }
}