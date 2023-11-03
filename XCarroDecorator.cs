using Decorator.Interface;

namespace Decorator
{
    public class XCarroDecorator : CarroDecorator
    {
        public XCarroDecorator(ICarro carro) : base(carro) 
        {
        }
        public override string BuscarModeloCarro()
        {
            string carro = base.BuscarModeloCarro();
            carro += "\r\n carro de modelo X, com comando de bordo e ar-condicionado";
            return carro;
        }
    }
}
