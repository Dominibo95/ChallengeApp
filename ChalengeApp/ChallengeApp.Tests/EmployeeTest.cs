using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void TestOfStatisticMaxValue()
        {
            var employee = new Employee("Aaron", "Stone");
            //arrange
            employee.AddGrade(9);
            employee.AddGrade(-5);
            employee.AddGrade(10);
            employee.AddGrade(9);
            //act
            var statistic = employee.GetStatistics();
            //assert
            Assert.IsNotNull(statistic);
            Assert.That(statistic.Max, Is.EqualTo(10));
        }
        [Test]
        public void TestOfStatisticMinValue()
        {
            var employee = new Employee("Aaron", "Stone");
            //arrange
            employee.AddGrade(9);
            employee.AddGrade(2);
            employee.AddGrade(5);
            employee.AddGrade(7);
            //act
            var statistic = employee.GetStatistics();
            //assert
            Assert.That(statistic.Min, Is.EqualTo(2));
        }
        [Test]
        public void TestOfStatisticAverage()
        {
            var employee = new Employee("Aaron", "Stone");
            //arrange
            employee.AddGrade(9);
            employee.AddGrade(-5);
            employee.AddGrade(8);
            employee.AddGrade(2);
            //act
            var statistic = employee.GetStatistics();
            //assert
            Assert.That(statistic.Average, Is.EqualTo(3.5));
        }
    }
}