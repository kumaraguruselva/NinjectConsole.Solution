using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectConsole
{
    class BL
    {
        IProduct objIpro;
        public BL(IProduct objectIproduct)
        {
            objIpro = objectIproduct;
        }
        public void Insert()
        {
            objIpro.InsertProduct();
        }
    }
}
