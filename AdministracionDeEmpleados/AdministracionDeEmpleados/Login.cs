using AdministracionDeEmpleados.Resource;
using AdministracionDeEmpleados.Session;
using System;
using System.Windows.Forms;

namespace AdministracionDeEmpleados
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlManipulation xml = new XmlManipulation();
            string email = inputEmail.Text;
            string password = inputPassword.Text;
            Home home = new Home();
            LoginSesion loginin = new LoginSesion();
            returnboolstring verify = loginin.ConfirmLogin(email, password);
            if (verify.isonot == true)
            {
                xml.AddFielXmlLogin(verify);
                this.Close();
            }
            else
            {
                errorLabel.Text = verify.message;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /*private void btnVerify_Click(object sender, EventArgs e)
        {
            XmlManipulation xml = new XmlManipulation();
            string email = inputEmail.Text;
            string password = inputPassword.Text;
            Home home = new Home();
            LoginSesion loginin = new LoginSesion();
            returnboolstring verify = loginin.ConfirmLogin(email, password);
            if(verify.isonot == true)
            {
                xml.AddFielXmlLogin(verify);
                this.Close();
            }
            else
            {
                labelNotInc.Text = verify.message;
            }
        }*/
    }
}

/*
 * LoginSesion loginin = new LoginSesion();
   returnboolstring verify = loginin.ConfirmLogin("dscampaz3110@gmail.com", "Daniel2008b3");
   MessageBox.Show($"Accese: {verify.isonot}, Message: {verify.message}");
 */
