using Decorator.Component;

namespace Decorator.ConcreteComponent
{
    // ConcreteComponent
    public class CompactCar : Car
    {
        public CompactCar()
        {
            Description = "Compact Car";
        }

        public override double GetCarPrice() => 10000.00;
        public override string GetDescription() => Description;
    }
}
