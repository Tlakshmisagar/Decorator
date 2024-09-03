/******************************************************************************
* Filename    = ICoffee.cs
*
* Author      = T Lakshmi Sagar
*
* Product     = SoftwareDesignPatterns
* 
* Project     = DecoratorDemo
*
* Description = Contract for coffee objects providing description and cost.
*****************************************************************************/

namespace Component
{
    /// <summary>
    /// Interface defining the contract for coffee objects. 
    /// Provides methods to get the description and cost of a coffee.
    /// </summary>
    public interface ICoffee
    {
        string GetDescription();
        double GetCost();
    }
}
