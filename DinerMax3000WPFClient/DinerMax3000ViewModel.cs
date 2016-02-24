using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinerMax3000.Business;

namespace DinerMax3000.WPFClient
{
    public class DinerMax3000ViewModel
    {
        public List<Menu> AllMenus
        {
            get
            {
                return Menu.GetAllMenus();
            }
        }
    }
}
