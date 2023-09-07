using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectConsole
{
    class DL : IProduct
    {
        public string InsertProduct()
        {
            string value = "Ninject Dependency Injection";
            Console.WriteLine(value);
            return value;
        }
    }
}
