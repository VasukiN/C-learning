using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod_sample
{
    public interface IToyota
    {
        string DiscountPrice();
        
    }
  public class Toyota : Car ,IToyota
    {

        private   override double price()
        {
            return 130000.56;
        }
        public override int GetToAllSeat()
        {
            return 4;
        }
        public override string color()
        {
            return "grey";
        }

        public string DiscountPrice()
        {
            return "Discounts is provided upto 40%";
        }
}
}
