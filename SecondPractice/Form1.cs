using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
namespace SecondPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Typename = textBox1.Text;
                Type T = Type.GetType(Typename);
                MethodInfo[] methods = T.GetMethods();
                foreach (MethodInfo method in methods)
                {
                    lstmethods.Items.Add(method.ReturnType + " " + method.Name);
                }
                PropertyInfo[] Properties = T.GetProperties();
                foreach (PropertyInfo Property in Properties)
                {
                    lstProperties.Items.Add(Property.PropertyType.Name + " " + Property.Name);
                }
                ConstructorInfo[] Constructors = T.GetConstructors();
                foreach (ConstructorInfo Constructor in Constructors)
                {
                    lstConstructors.Items.Add(Constructor.ToString());
                }
            }
            catch(Exception E)
            {
                MessageBox.Show("Please enter the correct formatted input");
            }
            
        }

        private void lstProperties_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
