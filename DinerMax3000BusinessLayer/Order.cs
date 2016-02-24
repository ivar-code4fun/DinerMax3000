using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000.Business
{
    public class Order
    {
        public List<MenuItem> items = new List<MenuItem>();
        double calculatedTotal = 0;
        
        public double Total
        {
            get
            {
                foreach (MenuItem item in items)
                {
                    calculatedTotal += item.Price;
                }
                return calculatedTotal;
            }

            set
            {
                calculatedTotal = value;
            }
        }

    }
}
