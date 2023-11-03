using Decorator.Interface;

namespace Decorator
{
    // Base Decorator
    public class CarroDecorator : ICarro
    {
        private readonly ICarro _carro;
        public CarroDecorator(ICarro carro) 
        {
            this._carro = carro;
        }
        public  virtual string BuscarModeloCarro()
        {
            var carro = _carro.BuscarModeloCarro();
            return carro;
        }
    }
}
