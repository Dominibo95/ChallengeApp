﻿using ChallengeApp;


Console.WriteLine("Witamy w programie do oceny pracownikow");
Console.WriteLine();
Console.WriteLine("Podaj ocene pracownika:");

var employee = new EmployeeInFile("Aron", "Stone");
//var employee = new EmployeeInMemory("Aron", "Stone");
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}


while (true)
{
    var input = Console.ReadLine();
    Console.WriteLine("Podaj kolejną ocene pracownika:");
    Console.WriteLine("Użyj q aby zakonczyć dodawanie ocen ");
    
    if (input == "q")
    {
        break;
    }
    else
    {
        try
        {
            employee.AddGrade(input);
        }

        catch (Exception e)
        {
            Console.WriteLine($"Exception catched: {e.Message}");
        }

    }
}


var statistics = employee.GetStatistics();
Console.WriteLine($"Imię: {employee.Name}");
Console.WriteLine($"Nazwisko: {employee.Surname}");
Console.WriteLine($"AVG: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"MAX: {statistics.Max}");
Console.WriteLine($"End Grade: {statistics.AverageLetter}");
Console.WriteLine($"Count : {statistics.Count}");