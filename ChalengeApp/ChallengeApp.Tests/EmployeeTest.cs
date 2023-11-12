using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeGetScore_ShouldReturnSumAsResu()
        {
            //arrange
            var employee = new Employee("Arron", "Stone", 36);
            employee.AddScore(5);
            employee.AddScore(10);
            employee.AddScore(1);
            employee.AddScore(3);
            employee.AddScore(4);

            //act

            var result = employee.Result;
            //assert

            Assert.IsNotNull(result);
            Assert.AreEqual(23, result);
        }
        [Test]
        public void WhenEmployeeGetMinusScore_ShouldReturnSumAsResu()
        {
            //arrange
            var employee = new Employee("Arron", "Stone", 36);
            employee.AddScore(-5);
            employee.AddScore(-10);
            employee.AddScore(-1);
            employee.AddScore(-3);

            //act

            var result = employee.Result;
            //assert

            Assert.IsNotNull(result);
            Assert.AreEqual(-19, result);
        }
    }
}