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
    public partial class AddEmployee : Form
    {
        EmployeeCollection collectionEmployee = new EmployeeCollection();
        NRegistroCollection collectionNRegistre = new NRegistroCollection();


        public AddEmployee()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            List<NRegistro> registro = collectionNRegistre.GetNRegistreById("6394f1ba3b4f96f511eca231");
            Int64 re = registro[0].count;
            re++;
            registro[0].count = re;
            collectionNRegistre.UpdateNRegistre(registro[0]);
            string name = InpName.Text;
            string lastname = InpLastName.Text;
            string admion = comBAdmin.SelectedItem.ToString();
            bool adminBool = Convert.ToBoolean(admion);
            string active = comBActive.SelectedItem.ToString();
            bool activeBool = Convert.ToBoolean(active);
            string cedula = InpCedula.Text;
            Int64 cedulaInt = Convert.ToInt64(cedula);
            string salary = InpSalary.Text;
            Int64 salaryInt = Convert.ToInt64(salary);
            string email = InpEmail.Text;
            string position = InpPosition.Text;
            string password = InpPassword.Text;
            Int64 phone = Convert.ToInt64(InpPhone.Text);
            Int64 nregistro = re;

            collectionEmployee.InsertEmployee(new Employee() { Name = name, LastName = lastname, Admin = adminBool, Active = activeBool, CC = cedulaInt, Salary = salaryInt, Email = email, Position = position, NRegistre = nregistro, Password = password, Phone = phone  });
            lbRegistre.Text = Convert.ToString(nregistro);
        }
    }
}
