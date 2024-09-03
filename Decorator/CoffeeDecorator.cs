/******************************************************************************
* Filename    = CoffeeDecorator.cs
*
* Author      = T Lakshmi Sagar
*
* Product     = SoftwareDesignPatterns
* 
* Project     = DecoratorDemo
*
* Description = Abstract decorator class implementing the ICoffee interface.
*               Wraps an ICoffee object and allows for additional functionalities.
*****************************************************************************/

using Component;

namespace Decorator
{
    /// <summary>
    /// Abstract decorator class that implements the ICoffee interface.
    /// Wraps an ICoffee object and allows derived classes to add additional
    /// functionalities such as adding ingredients.
    /// </summary>
    public abstract class CoffeeDecorator : ICoffee
    {
        protected ICoffee _coffee;

        public CoffeeDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public virtual string GetDescription()
        {
            return _coffee.GetDescription();
        }

        public virtual double GetCost()
        {
            return _coffee.GetCost();
        }
    }
}
