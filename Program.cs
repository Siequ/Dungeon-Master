Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Welcome to the game!");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\nUse up and down arrow keys to choose your class");
Console.ResetColor();
while (true)
{
Console.WriteLine("Rogue");
Console.WriteLine("Barbarian");
Console.WriteLine("Mage");

var userKey = Console.ReadKey(true);
}