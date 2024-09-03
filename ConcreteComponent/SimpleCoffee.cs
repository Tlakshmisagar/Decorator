using Component;

namespace ConcreteComponent
{
    public class SimpleCoffee : ICoffee
    {
        public String GetDescription()
        {
            return "Simple Coffee";
        }

        public double GetCost()
        {
            return 5.0;
        }
    }
}
