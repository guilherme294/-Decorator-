using Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ICarro carro = new Carro();
            ICarro xcarrodecorator = new XCarroDecorator(carro);
            ICarro xwcarrodecorator = new XWCarroDecorator(xcarrodecorator);
            ICarro xwzcarrodecorator = new XWZCarroDecorator(xwcarrodecorator);

            Console.WriteLine(xwzcarrodecorator.BuscarModeloCarro());
            Console.WriteLine();
            
        }
    }
}
