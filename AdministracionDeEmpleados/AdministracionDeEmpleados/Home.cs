using AdministracionDeEmpleados.Resource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionDeEmpleados
{
    public partial class Home : Form
    {
        XmlManipulation xml = new XmlManipulation();
        private Form activeForm = null;
        public Home()
        {
            InitializeComponent();
            opendChildForm(new DashBoard());

        }


        private void opendChildForm(Form childFrom)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle= FormBorderStyle.None;
            childFrom.Dock= DockStyle.Fill;
            panelChildForm.Controls.Add(childFrom);
            panelChildForm.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            opendChildForm(new DashBoard());
        }

        private void settingsbtn_Click(object sender, EventArgs e)
        {
            opendChildForm(new Settings());
        }

        private void employeesbtn_Click(object sender, EventArgs e)
        {
            opendChildForm(new EmployeesSee());
        }

        private void employeebtn_Click(object sender, EventArgs e)
        {
            opendChildForm(new SeeEmployeeSearch());
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            opendChildForm(new AddEmployee());
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iniSeasonBtn_Click(object sender, EventArgs e)
        {
            Form login = new Login();
            login.ShowDialog();
        }
    }
}
