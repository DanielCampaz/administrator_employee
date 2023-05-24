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
    public partial class EmployeesSee : Form
    {
        public EmployeesSee()
        {
            InitializeComponent();
            addEmployee();
        }


        public void addEmployee()
        {
            for(int i = 0; i< 10; i++)
            {
                ChListBox.Items.Add("Daniel Campaz | Active | 1005705958", true);
            }
            
        }

    }
}
