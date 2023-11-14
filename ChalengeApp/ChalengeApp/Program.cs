using ChallengeApp;

var employee = new Employee("Aron", "Stone");


employee.AddGrade(6f);
employee.AddGrade(5);
employee.AddGrade(-2);
employee.AddGrade(3);
employee.AddGrade(6);

var statistics = employee.GetStatistics();


Console.WriteLine("Wyniki dla Metody GetStatistics: ");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
