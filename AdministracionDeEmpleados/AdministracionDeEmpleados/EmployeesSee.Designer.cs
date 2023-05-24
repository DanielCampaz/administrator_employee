namespace AdministracionDeEmpleados
{
    partial class EmployeesSee
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
            this.ChListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // ChListBox
            // 
            this.ChListBox.FormattingEnabled = true;
            this.ChListBox.Location = new System.Drawing.Point(1, 107);
            this.ChListBox.Name = "ChListBox";
            this.ChListBox.Size = new System.Drawing.Size(841, 454);
            this.ChListBox.TabIndex = 0;
            // 
            // EmployeesSee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 559);
            this.Controls.Add(this.ChListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeesSee";
            this.Text = "Employees";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ChListBox;
    }
}