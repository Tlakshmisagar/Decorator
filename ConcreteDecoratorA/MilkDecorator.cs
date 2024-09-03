/******************************************************************************
* Filename    = MilkDecorator.cs
*
* Author      = T Lakshmi Sagar
*
* Product     = SoftwareDesignPatterns
* 
* Project     = DecoratorDemo
*
* Description = Concrete decorator adding milk to the coffee.
*               Enhances the coffee's description and increases its cost.
*****************************************************************************/

using Component;
using Decorator;

namespace ConcreteDecoratorA
{
    /// <summary>
    /// Concrete decorator class that adds milk to a coffee object.
    /// Modifies the description to include milk and increases the cost.
    /// </summary>
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Milk";
        }

        public override double GetCost()
        {
            return base.GetCost() + 3;
        }
    }
}
