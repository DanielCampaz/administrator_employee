using AdministracionDeEmpleados.Models;
using AdministracionDeEmpleados.Session;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AdministracionDeEmpleados.Resource
{
    public class XmlManipulation
    {
        XmlDocument docXml = new XmlDocument();
        
        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Permanete.xml");

        string id;
        bool isLogin;
        string a;

        public XmlManipulation() { }

        public void AddFielXmlLogin(returnboolstring returnLogin)
        {

            docXml.Load(this.path);

            int index = 0;
            foreach (XmlNode xmlNode in docXml.DocumentElement.ChildNodes[0].ChildNodes)
            {
                if (index == 0)
                {
                   if(xmlNode.InnerText == "null")
                    {
                        xmlNode.InnerText =  returnLogin.employee.Id.ToString();
                    }
                }
                else if (index == 1)
                {
                    if (xmlNode.InnerText == "null")
                    {
                        xmlNode.InnerText = returnLogin.isonot.ToString();
                    }
                }
                index = +1;
            }

            docXml.Save(path);

            /*XmlNode login = docXml.CreateElement("Login");

            XmlNode dataEmpleado = docXml.CreateElement("Data-Employee-Admin");

            XmlNode Id = docXml.CreateElement("Id");
            Id.InnerText = returnLogin.employee.Id.ToString();

            dataEmpleado.AppendChild(Id);

            XmlNode isLogin = docXml.CreateElement("Is-Login");
            isLogin.InnerText = returnLogin.isonot.ToString();

            login.AppendChild(dataEmpleado);
            login.AppendChild(isLogin);

            XmlNode nodoraiz = docXml.DocumentElement;
            nodoraiz.InsertAfter(login, nodoraiz.LastChild);
            docXml.Save("permanete.xml");*/
        }

        public returnxmlformat ReadFieldXml()
        {
            docXml.Load(this.path);
            int index = 0;
            foreach (XmlNode xmlNode in docXml.DocumentElement.ChildNodes[0].ChildNodes)
            {
                if(index== 0)
                {
                    this.id= xmlNode.InnerText;
                }
                else if(index== 1)
                {
                    if (xmlNode.InnerText != "null")
                    {
                        this.isLogin = Convert.ToBoolean(xmlNode.InnerText);
                    }
                    else
                    {
                        this.isLogin = false;
                    }
                }
                this.a = " " + this.a + " " + xmlNode.InnerText;
                index =+ 1;
            }

            return new returnxmlformat() { id = this.id, isLogin = this.isLogin };
        }

        public void DeleteLoginXml()
        {
            docXml.Load(this.path);

            int index = 0;
            foreach (XmlNode xmlNode in docXml.DocumentElement.ChildNodes[0].ChildNodes)
            {
                if (index == 0)
                {
                    xmlNode.InnerText = "null";
                }
                else if (index == 1)
                {
                    xmlNode.InnerText = "null";
                }
                index = +1;
            }

            docXml.Save(path);
        }

    }

    public class returnxmlformat
    {
        public string id;
        public bool isLogin;
    }
}


