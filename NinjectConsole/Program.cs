// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using System.Reflection;

namespace NinjectConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardKernel _kernel = new StandardKernel();
            _kernel.Load(Assembly.GetExecutingAssembly());
            IProduct _objIPro = _kernel.Get<IProduct>();
            BL objbl = new BL(_objIPro);
            objbl.Insert();
            Console.ReadLine();
        }
    }
}
