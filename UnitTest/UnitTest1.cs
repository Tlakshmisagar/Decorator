using Component;
using ConcreteComponent;
using ConcreteDecoratorA;
using ConcreteDecoratorB;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SimpleCoffee_ShouldHaveCorrectDescriptionAndCost()
        {
            // Arrange
            ICoffee coffee = new SimpleCoffee();

            // Act
            var description = coffee.GetDescription();
            var cost = coffee.GetCost();

            // Assert
            Assert.AreEqual("Simple Coffee", description);
            Assert.AreEqual(5.0, cost);
        }

        [TestMethod]
        public void MilkDecorator_ShouldAddMilkAndIncreaseCost()
        {
            // Arrange
            ICoffee coffee = new SimpleCoffee();
            coffee = new MilkDecorator(coffee);

            // Act
            var description = coffee.GetDescription();
            var cost = coffee.GetCost();

            // Assert
            Assert.AreEqual("Simple Coffee, Milk", description);
            Assert.AreEqual(8.0, cost);
        }

        [TestMethod]
        public void SugarDecorator_ShouldAddSugarAndIncreaseCost()
        {
            // Arrange
            ICoffee coffee = new SimpleCoffee();
            coffee = new SugarDecorator(coffee);

            // Act
            var description = coffee.GetDescription();
            var cost = coffee.GetCost();

            // Assert
            Assert.AreEqual("Simple Coffee, Sugar", description);
            Assert.AreEqual(7.0, cost);
        }

        [TestMethod]
        public void MultipleDecorators_ShouldAddMultipleFeaturesAndIncreaseCost()
        {
            // Arrange
            ICoffee coffee = new SimpleCoffee();
            coffee = new MilkDecorator(coffee);
            coffee = new SugarDecorator(coffee);

            // Act
            var description = coffee.GetDescription();
            var cost = coffee.GetCost();

            // Assert
            Assert.AreEqual("Simple Coffee, Milk, Sugar", description);
            Assert.AreEqual(10.0, cost);
        }
    }
}