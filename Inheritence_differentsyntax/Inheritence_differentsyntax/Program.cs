using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//System.Windows.Forms;

namespace Inheritence_differentsyntax
{
    public class BaseClassA
    {
        private A m_outer;
        public BaseClassA(A outer)
        {
            m_outer = A;
        }
        public void DoSomething() { }
    }

    public class A 
    {
        private BaseClassA m_del;

        public BaseClassA vas;

        public A()
        {
            m_del = new BaseClassA(this);
        }
        public A()
        {
            m_del = new BaseClassA(this);
        }
        public void DoSomething()
        {
            m_del.DoSomething();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
