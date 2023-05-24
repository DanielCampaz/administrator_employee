using AdministracionDeEmpleados.Models;
using AdministracionDeEmpleados.Repositories;
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
    public partial class SeeEmployeeSearch : Form
    {

        EmployeeCollection collection = new EmployeeCollection();

        public SeeEmployeeSearch()
        {
            InitializeComponent();
            lbInpu.Text= "Ingrese Aqui:";
            
        }

        private void comboSearchHow_SelectedIndexChanged(object sender, EventArgs e)
        {
            string slect = comboSearchHow.SelectedItem.ToString();
            lbInpu.Text = $"Ingrese Aqui {slect}:";
        }

        
        private List<Employee> searchEmployeeByEmail(string email)
        {
            return collection.GetEmployeeByEmail(email);
        }

        private List<Employee> searchEmployeeByCC(Int64 CC)
        {
            return collection.GetEmployeeByCC(CC);
        }

        private List<Employee> searchEmployeeById(string id)
        {
            return collection.GetEmployeeById(id);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Employee> empl = new List<Employee>();

            string search = searchTxt.Text;

            string slect = comboSearchHow.SelectedItem.ToString();
            if (slect == "Id")
            {
                empl = searchEmployeeById(search);
            }
            else if (slect == "Email")
            {
                empl = searchEmployeeByEmail(search);
            }
            else if (slect == "CC")
            {
                Int64 cedula = Convert.ToInt64(search);
                empl = searchEmployeeByCC(cedula);
            }

            Console.WriteLine(empl);

            inpCC.Text = empl[0].CC.ToString();
            inpEmail.Text = empl[0].Email.ToString();
            inpLastName.Text = empl[0].LastName.ToString();
            inpName.Text = empl[0].Name.ToString();
            inpPassword.Text = empl[0].Password.ToString();
            inpPhone.Text = empl[0].Phone.ToString();
            inpPosition.Text = empl[0].Position.ToString();
            inpSalary.Text = empl[0].Salary.ToString();
            cmbActives.SelectedItem = empl[0].Active.ToString();
            cmbAdmins.SelectedItem = empl[0].Admin.ToString();
            lbRegistre.Text = empl[0].NRegistre.ToString();
            string id = empl[0].Id.ToString();
            lbID.Text = $"ID: {id}";
        }
    }
}
