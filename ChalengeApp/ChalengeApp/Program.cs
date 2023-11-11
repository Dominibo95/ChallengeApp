var name = "Dominik";
int age = 16;
bool isWoman = true;

if (age == 33 && name == "Ewa" && isWoman == true)
{
    Console.WriteLine("Ewa , lat 33");
}
else if (age < 18 && isWoman == false)
{
    Console.WriteLine("Niepełnoletni Mezczyzna");
}
else if (age < 30 && isWoman == true)
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}
else
{
    Console.WriteLine("Dane nie pasują");
}
