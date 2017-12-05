using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritenceusingwindows
{
    public class A : System.Windows.Forms.Form
    {
        private BaseClassA m_del;
        public A()
        {
            m_del = new BaseClassA(this);
        }
        public static implicit operator BaseClassA(A type)
        {
            return (type.m_del);
        }
            public void Dosomething()
        {
            m_del.Dosomething();
        }
    }
    public class BaseClassA
        {
            private A m_outer;
            public BaseClassA(A outer)
            {
                m_outer = a;
                
            }
        public static explicit operator A(BaseClassA type)
        {
            return (type.m_outer);
        }
        public void Dosomething()
        {
            
        }

        }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
