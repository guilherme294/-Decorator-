using Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class Carro : ICarro
    {
        public string BuscarModeloCarro()
        {
            var carro = "Este é um carro de modelo Basico";
            return carro;
        }
    }
}
