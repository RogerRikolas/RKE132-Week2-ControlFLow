// Rakendus küsib kasutajal sisestada vanus
// Kui kasutaja vanus on väiksem kui 13, siis konsoolis:
// "You are too young to use this app"
// muul juhul konsoolis kuvatakse "Welcome to the app"
Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();
int userAgeNum = 0;

//boolean - true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

//int userAge = Int32.Parse(Console.ReadLine());

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

if (isAgeNumber)
{
    if(userAgeNum >=13)
    {
        Console.WriteLine("Welcome to the App!");
    }
    else
    {
        Console.WriteLine("You are too young to use this App!");
    }
}
else
{
    Console.WriteLine("Could not read your age!");
}
