namespace AdministracionDeEmpleados
{
    partial class AddEmployee
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.comBActive = new System.Windows.Forms.ComboBox();
            this.lbRegistre = new System.Windows.Forms.Label();
            this.comBAdmin = new System.Windows.Forms.ComboBox();
            this.InpCedula = new System.Windows.Forms.TextBox();
            this.InpPassword = new System.Windows.Forms.TextBox();
            this.InpEmail = new System.Windows.Forms.TextBox();
            this.InpName = new System.Windows.Forms.TextBox();
            this.InpPosition = new System.Windows.Forms.TextBox();
            this.InpLastName = new System.Windows.Forms.TextBox();
            this.InpSalary = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InpPhone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(605, 479);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(151, 44);
            this.btn_Save.TabIndex = 59;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // comBActive
            // 
            this.comBActive.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.comBActive.FormattingEnabled = true;
            this.comBActive.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comBActive.Location = new System.Drawing.Point(171, 268);
            this.comBActive.Name = "comBActive";
            this.comBActive.Size = new System.Drawing.Size(217, 33);
            this.comBActive.TabIndex = 58;
            // 
            // lbRegistre
            // 
            this.lbRegistre.AutoSize = true;
            this.lbRegistre.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.lbRegistre.ForeColor = System.Drawing.Color.White;
            this.lbRegistre.Location = new System.Drawing.Point(562, 218);
            this.lbRegistre.Name = "lbRegistre";
            this.lbRegistre.Size = new System.Drawing.Size(194, 25);
            this.lbRegistre.TabIndex = 57;
            this.lbRegistre.Text = "N. Registre_Text";
            // 
            // comBAdmin
            // 
            this.comBAdmin.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.comBAdmin.FormattingEnabled = true;
            this.comBAdmin.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comBAdmin.Location = new System.Drawing.Point(171, 215);
            this.comBAdmin.Name = "comBAdmin";
            this.comBAdmin.Size = new System.Drawing.Size(217, 33);
            this.comBAdmin.TabIndex = 56;
            // 
            // InpCedula
            // 
            this.InpCedula.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.InpCedula.Location = new System.Drawing.Point(171, 325);
            this.InpCedula.Name = "InpCedula";
            this.InpCedula.Size = new System.Drawing.Size(217, 35);
            this.InpCedula.TabIndex = 55;
            // 
            // InpPassword
            // 
            this.InpPassword.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.InpPassword.Location = new System.Drawing.Point(567, 380);
            this.InpPassword.Name = "InpPassword";
            this.InpPassword.Size = new System.Drawing.Size(217, 35);
            this.InpPassword.TabIndex = 54;
            // 
            // InpEmail
            // 
            this.InpEmail.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.InpEmail.Location = new System.Drawing.Point(567, 325);
            this.InpEmail.Name = "InpEmail";
            this.InpEmail.Size = new System.Drawing.Size(217, 35);
            this.InpEmail.TabIndex = 53;
            // 
            // InpName
            // 
            this.InpName.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.InpName.Location = new System.Drawing.Point(171, 155);
            this.InpName.Name = "InpName";
            this.InpName.Size = new System.Drawing.Size(217, 35);
            this.InpName.TabIndex = 52;
            // 
            // InpPosition
            // 
            this.InpPosition.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.InpPosition.Location = new System.Drawing.Point(171, 390);
            this.InpPosition.Name = "InpPosition";
            this.InpPosition.Size = new System.Drawing.Size(217, 35);
            this.InpPosition.TabIndex = 51;
            // 
            // InpLastName
            // 
            this.InpLastName.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.InpLastName.Location = new System.Drawing.Point(566, 155);
            this.InpLastName.Name = "InpLastName";
            this.InpLastName.Size = new System.Drawing.Size(217, 35);
            this.InpLastName.TabIndex = 50;
            // 
            // InpSalary
            // 
            this.InpSalary.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.InpSalary.Location = new System.Drawing.Point(566, 266);
            this.InpSalary.Name = "InpSalary";
            this.InpSalary.Size = new System.Drawing.Size(217, 35);
            this.InpSalary.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(416, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 25);
            this.label11.TabIndex = 48;
            this.label11.Text = "N. Registre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(51, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 25);
            this.label10.TabIndex = 47;
            this.label10.Text = "CC:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(51, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 25);
            this.label9.TabIndex = 46;
            this.label9.Text = "Admin:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(416, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 25);
            this.label8.TabIndex = 45;
            this.label8.Text = "Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(51, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 44;
            this.label7.Text = "Active:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(416, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "Salary:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(51, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "Position:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(416, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 41;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(416, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(253, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 50);
            this.label1.TabIndex = 60;
            this.label1.Text = "Add Employee";
            // 
            // InpPhone
            // 
            this.InpPhone.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.InpPhone.Location = new System.Drawing.Point(171, 453);
            this.InpPhone.Name = "InpPhone";
            this.InpPhone.Size = new System.Drawing.Size(217, 35);
            this.InpPhone.TabIndex = 62;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(51, 456);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 25);
            this.label12.TabIndex = 61;
            this.label12.Text = "Phone:";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(841, 559);
            this.Controls.Add(this.InpPhone);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.comBActive);
            this.Controls.Add(this.lbRegistre);
            this.Controls.Add(this.comBAdmin);
            this.Controls.Add(this.InpCedula);
            this.Controls.Add(this.InpPassword);
            this.Controls.Add(this.InpEmail);
            this.Controls.Add(this.InpName);
            this.Controls.Add(this.InpPosition);
            this.Controls.Add(this.InpLastName);
            this.Controls.Add(this.InpSalary);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox comBActive;
        private System.Windows.Forms.Label lbRegistre;
        private System.Windows.Forms.ComboBox comBAdmin;
        private System.Windows.Forms.TextBox InpCedula;
        private System.Windows.Forms.TextBox InpPassword;
        private System.Windows.Forms.TextBox InpEmail;
        private System.Windows.Forms.TextBox InpName;
        private System.Windows.Forms.TextBox InpPosition;
        private System.Windows.Forms.TextBox InpLastName;
        private System.Windows.Forms.TextBox InpSalary;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InpPhone;
        private System.Windows.Forms.Label label12;
    }
}