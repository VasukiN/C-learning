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

namespace ReflectionWindowApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string typename = textBox1.Text;
            Type T = Type.GetType(typename);
            MethodInfo[] methods = T.GetMethods();
            foreach(MethodInfo method in methods)
            {
                lstMethods.Items.Add(method);
            }

        }

        
    }
}
