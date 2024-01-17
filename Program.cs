Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Welcome to the game!");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\nUse up and down arrow keys to choose your class");
Console.ResetColor();

ConsoleKeyInfo userKey;
int choosedClassOption = 1;
bool isSelected = false;

while (!isSelected)
{
    Console.WriteLine("Rogue");
    Console.WriteLine("Barbarian");
    Console.WriteLine("Mage");

    userKey = Console.ReadKey(true);

    switch (userKey.Key)
    {
        case ConsoleKey.DownArrow:
        choosedClassOption++;
        break;

        case ConsoleKey.UpArrow:
            choosedClassOption--;
        break;

        case ConsoleKey.Enter:
        isSelected = true;
        break;


    }
    
}

Console.WriteLine($"You selected {choosedClassOption} ");
Console.ReadLine();