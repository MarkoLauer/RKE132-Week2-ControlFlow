// See https://aka.ms/new-console-template for more information


//rakendus küsib kasutaja sugu (m/f)
//rakendus kpsib kasutaja perekonnanime 
//lähtudes kasutaj avalikust, tervitab rakendus kasutajat järgmiselt:
//"Welcome, Mr. (kasutaja perekonnanimi)" / "Welcome, Ms. (kasutaja perekonnanimi)"

Console.WriteLine("Please select your gender (m/f)");
char UserGender = char.Parse(Console.ReadLine()); //loeb konsoolist andmed string (sõne) formaadis  
Console.WriteLine("Please enter your lastname:");
string UserLastname = Console.ReadLine();

if(UserGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {UserLastname}!");
}
else if(UserGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {UserLastname}!");
}
else
{
    Console.WriteLine("Welcome!");
}

Console.WriteLine($"Welcome, {UserGender}");


