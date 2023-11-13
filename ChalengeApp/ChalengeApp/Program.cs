using ChallengeApp;

var employee = new Employee("Aron", "Stone");
employee.AddGrade("ser");
employee.AddGrade("9000");
employee.AddGrade(2);
employee.AddGrade(61f);
employee.AddGrade(7.2);
var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2} ");
Console.WriteLine($"Max: {statistics.Max} ");
Console.WriteLine($"Min: {statistics.Min} ");
