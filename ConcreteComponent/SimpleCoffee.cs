/******************************************************************************
* Filename    = SimpleCoffee.cs
*
* Author      = T Lakshmi Sagar
*
* Product     = SoftwareDesignPatterns
* 
* Project     = DecoratorDemo
*
* Description = Concrete component implementing the ICoffee interface. 
*               Represents a simple coffee with a base description and cost.
*****************************************************************************/

using Component;

namespace ConcreteComponent
{
    /// <summary>
    /// Concrete implementation of the ICoffee interface. 
    /// Represents a basic coffee with a fixed description and cost.
    /// </summary>
    public class SimpleCoffee : ICoffee
    {
        public string GetDescription()
        {
            return "Simple Coffee";
        }

        public double GetCost()
        {
            return 5.0;
        }
    }
}
