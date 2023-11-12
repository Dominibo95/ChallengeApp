
namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void ComperingFloatType()
        {
            // arrange
            float f1 = 2.2f;
            float f2 = 2.2f;

            // act

            //action
            Assert.AreEqual(f1, f2);
        }
        [Test]
        public void ComperingStringType()
        {
            // arrange
            string name1 = "Jim";
            string name2 = "Adam";

            // act

            //action
            Assert.AreNotEqual(name1, name2);
        }

        [Test]
        public void ComperingIntType()
        {
            // arrange
            int number1 = 2;
            int number2 = 2;

            // act

            //action
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void ComperingReferenceType()
        {
            //arrange
            var employee1 = GetEmployee("Jim", "Bean", 40);
            var employee2 = GetEmployee("Kane", "West", 44);
            //act

            //asserts
            Assert.AreNotEqual(employee1, employee2);

        }

        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
}
