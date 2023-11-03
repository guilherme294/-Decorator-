using Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    internal class XWZCarroDecorator : CarroDecorator
    {
        public XWZCarroDecorator(ICarro carro) : base(carro)
        {
        }
        public override string BuscarModeloCarro()
        {
            string carro = base.BuscarModeloCarro();
            carro += "\r\n o modelo XWZ incruem bancos e paineis de couro branco e madeira";
            return carro;
        }
    }
}
