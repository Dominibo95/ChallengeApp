namespace ChallengeApp
{
    public class Employee : Person
    {
        private List<float> grades = new List<float>();


        public Employee(string name, string surname, string sex)
        : base(name, surname, sex)
        {
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);

            }
            else
            {
                throw new Exception("invalid grade value");
            }
        }
        public void AddGrade(short grade)
        {
            var value = (float)grade;
            this.AddGrade(value);
        }
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }
        public void AddGrade(long grade)
        {
            var value = (float)grade;
            this.AddGrade(value);
        }
        public void AddGrade(double grade)
        {
            var value = (int)grade;
            this.AddGrade(value);
        }
        public void AddGrade(string grade)
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

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var a when a >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var a when a >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var a when a >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var a when a >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }

    }
}
