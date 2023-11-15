
namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public abstract void AddGrade(float grade);

        public virtual void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float value))
            {
                this.AddGrade(value);
            }
            else if (char.TryParse(grade, out char gradeIsChar))
            {
                this.AddGrade(gradeIsChar);
            }
            else
            {
                throw new Exception("String is not float or char");
            }
        }

        public virtual void AddGrade(int grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }

        public virtual void AddGrade(double grade)
        {
            var value = (int)grade;
            this.AddGrade(value);
        }

        public abstract void AddGrade(char grade);

        public abstract Statistics GetStatistics();
    }
}
