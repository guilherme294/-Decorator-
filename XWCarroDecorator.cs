using Decorator.Interface;

namespace Decorator
{
    internal class XWCarroDecorator : CarroDecorator
    {
        public XWCarroDecorator(ICarro carro) : base(carro)
        {
        }
        public override string BuscarModeloCarro()
        {
            string carro = base .BuscarModeloCarro();
            carro += "\r\n modelo XW, incluem rodas aro 15 e air-bags nos bancos traseiros";
            return carro;
        }
    }
}
