using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate_Event_smallprogram
{
    
     public class NumberReahedEventArgs : EventArgs
    {
        private int _reached;
        public NumberReahedEventArgs(int num)
        {
            this._reached = num;
        }
        public int ReachedNumber
        {
            get
            {
                return _reached;
            }
        }
    }
    public class counter
    {
        public delegate void NumberReachedEventhandler(object sender, NumberReahedEventArgs e);
        public event NumberReachedEventhandler NumberReahed;
        public counter()
        {

        }
        public void CountTo(int CountTo, int ReachableNum)
        {
            if(CountTo<ReachableNum)
            
                throw new ArgumentException("Reachable number should be less than the ");
                for (int ctr=0;ctr<=CountTo;ctr++)
                {
                    if(ctr==ReachableNum)
                    {
                        NumberReahedEventArgs e = new NumberReahedEventArgs(ReachableNum);
                    OnNumberReached(e);
                    return;
                    }
                }
            
          }
      protected virtual void OnNumberReached(NumberReahedEventArgs e)
        {
             if (NumberReahed != null)
             {
                NumberReahed(this, e);//Raise the event
              }
    }
     
        
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
