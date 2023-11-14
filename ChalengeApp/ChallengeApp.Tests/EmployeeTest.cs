using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void TestOfStatisticMaxValueWithStringAndIntegerAsInput()
        {
            var employee = new Employee("Aaron", "Stone");
            //arrange
            employee.AddGrade("A");
            employee.AddGrade(-5);
            employee.AddGrade(10);
            employee.AddGrade(9);
            //act
            var statistic = employee.GetStatistics();
            //assert
            Assert.IsNotNull(statistic);
            Assert.That(statistic.Max, Is.EqualTo(100.0f));
        }
        [Test]
        public void TestOfStatisticMinValueWithCharAsInput()
        {
            var employee = new Employee("Aaron", "Stone");
            //arrange
            employee.AddGrade("A");
            employee.AddGrade('B');
            employee.AddGrade('c');
            employee.AddGrade(100);
            //act
            var statistic = employee.GetStatistics();
            //assert
            Assert.That(statistic.Min, Is.EqualTo(60.0F));
        }
        [Test]
        public void TestOfStatisticAverage()
        {
            var employee = new Employee("Aaron", "Stone");
            //arrange
            employee.AddGrade('a');
            employee.AddGrade("B");
            employee.AddGrade(80);
            employee.AddGrade(20);
            //act
            var statistic = employee.GetStatistics();
            //assert
            Assert.That(statistic.Average, Is.EqualTo(70.0f));
        }
        [Test]
        public void TestOfStatisticAverageLetter()
        {
            var employee = new Employee("Aaron", "Stone");
            //arrange
            employee.AddGrade("A");
            employee.AddGrade('B');
            employee.AddGrade('C');
            //act
            var statistic = employee.GetStatistics();
            //assert
            Assert.That(statistic.AverageLetter, Is.EqualTo('A'));
        }
    }
}