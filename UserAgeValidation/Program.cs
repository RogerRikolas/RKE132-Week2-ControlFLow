
//rakendus küsib kasutaja sugu (M/F)
//rakendus küsib kasutaja perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, MIster [kasutaja perekonnanimi] / Welcome, Ms.[kasutaja perekonnanimi]

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //Loeb konsoolist maha andmeid string (sõne) formaadis
Console.WriteLine("Please enter your last name:");
string LastName = Console.ReadLine();
if(userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {LastName}!");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {LastName}!");
}
else
{
    Console.WriteLine($"Welcome {LastName}!");
}

