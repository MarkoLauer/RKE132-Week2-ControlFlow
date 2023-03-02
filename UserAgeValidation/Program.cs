// See https://aka.ms/new-console-template for more information


//rakendus küsib kasutaja vanust:
//kui kasutaja vanus on väikusem kui 13, siis konsoolis kuvatakse: "You are too young to use Instagram"
// muul juhul kuvatakse konsoolis: "Welcome to Instagram"

Console.WriteLine("Enter your age:");

int UserAge = Int32.Parse(Console.ReadLine()); //"13" - heap mälu, 13 - stack mälu, järelikult 13 mõistlikum salvestada arvu kujul

if (UserAge >= 13 )
{
    Console.WriteLine("Welcome to Instagram");
}
else //if (UserAge < 13) ; else if pole vaja kasutada
{
    Console.WriteLine("You are too young to use Instagram");
}

