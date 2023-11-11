Employee employee1 = new Employee("Aron", "Stone", 27);
Employee employee2 = new Employee("Slawomir", "Peszko", 38);
Employee employee3 = new Employee("Marcin", "Najman", 44);

employee1.AddScore(8);
employee1.AddScore(9);
employee1.AddScore(6);
employee1.AddScore(4);
employee1.AddScore(2);

employee2.AddScore(5);
employee2.AddScore(3);
employee2.AddScore(6);
employee2.AddScore(4);
employee2.AddScore(2);

employee3.AddScore(1);
employee3.AddScore(2);
employee3.AddScore(1);
employee3.AddScore(3);
employee3.AddScore(2);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee bestEmployee = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        bestEmployee = employee;
        maxResult = employee.Result;
    }
}

Console.WriteLine("Najlepszy wynik ma  " + bestEmployee.Name + " " + bestEmployee.Surname);

class Employee
{
    private List<int> score = new List<int>();
    public Employee(string name, string surname, int age)
    {
        this.Name = name;
        this.Surname = surname;
        this.Age = age;
    }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public int Result
    {
        get
        {
            return this.score.Sum();
        }
    }
    public void AddScore(int number)
    {
        this.score.Add(number);
    }
}
