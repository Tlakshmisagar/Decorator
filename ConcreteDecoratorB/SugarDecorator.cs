/******************************************************************************
* Filename    = SugarDecorator.cs
*
* Author      = T Lakshmi Sagar
*
* Product     = SoftwareDesignPatterns
* 
* Project     = DecoratorDemo
*
* Description = Concrete decorator adding sugar to the coffee.
*               Enhances the coffee's description and increases its cost.
*****************************************************************************/

using Component;
using Decorator;

namespace ConcreteDecoratorB
{
    /// <summary>
    /// Concrete decorator class that adds sugar to a coffee object.
    /// Modifies the description to include sugar and increases the cost.
    /// </summary>
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Sugar";
        }

        public override double GetCost()
        {
            return base.GetCost() + 2;
        }
    }
}
