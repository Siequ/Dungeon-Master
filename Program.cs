Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Welcome to the game!");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\nUse up and down arrow keys to choose your class");
Console.ResetColor();

ConsoleKeyInfo userKey;
int choosedClassOption = 1;
bool isSelected = false;
(int leftPosition, int topPosition) = Console.GetCursorPosition();
string currentOption = "*  ";

while (!isSelected)
{
    Console.SetCursorPosition(leftPosition, topPosition);
    Console.WriteLine($"{(choosedClassOption == 1 ? currentOption : "   ")}Rogue");
    Console.WriteLine($"{(choosedClassOption == 2 ? currentOption : "   ")}Barbarian");
    Console.WriteLine($"{(choosedClassOption == 3 ? currentOption : "   ")}Mage");

    userKey = Console.ReadKey(true);

    switch (userKey.Key)
    {
        case ConsoleKey.DownArrow:
        choosedClassOption = (choosedClassOption == 3 ? 3 : choosedClassOption + 1);
        break;

        case ConsoleKey.UpArrow:
            choosedClassOption = (choosedClassOption == 1 ? 1 : choosedClassOption - 1 );
        break;

        case ConsoleKey.Enter:
        isSelected = true;
        break;


    }
    
}
int playerHealth = 0;
Console.Clear();
if(choosedClassOption == 1){
Console.WriteLine($"You selected Rogue, you have chance to dodge enemy's attack");
playerHealth = playerHealth+450;
}
else if(choosedClassOption == 2 ){
    Console.WriteLine($"You selected Barbarian, you are able to attack twice");
    playerHealth = playerHealth+600;
}
else {
    Console.WriteLine($"You selected Mage, you are able to cast a spell ");
    playerHealth = playerHealth+350;
}


Console.ReadLine();