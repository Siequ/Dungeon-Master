using System.Security.Cryptography.X509Certificates;

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
int playerMana = 0;
Console.Clear();
if(choosedClassOption == 1){
playerHealth = playerHealth+450;
Console.WriteLine($"You selected Rogue, you have chance to dodge enemy's attack, your health is: {playerHealth}");
}
else if(choosedClassOption == 2 ){
    playerHealth = playerHealth+600;
    Console.WriteLine($"You selected Barbarian, you are able to attack twice, your health is: {playerHealth}");
}
else {
    playerHealth = playerHealth+350;
    playerMana = playerMana+60;
    Console.WriteLine($"You selected Mage, you are able to cast a huge spell, your health is: {playerHealth} and your mana: {playerMana} ");
    
}

    int ratBossLife = 300;
    Random randomDmg = new Random();

    

    Console.WriteLine("\nYou've entered small dungeon, after exploring it, a big, mutated rat apperead - it seems like you have to fight for your life! \n ");
    
    do{

    Random playerDmg = new Random();
    int playerAttack = randomDmg.Next(40,55);
    int ratAttack = randomDmg.Next(15,20);
    Console.Clear();
    
    
    if(ratBossLife>0){
        Console.WriteLine("attack!");
    Console.WriteLine($"\n Rat's hp:{ratBossLife} Your hp: {playerHealth}");
    }
   
    
    Console.ReadLine();
    ratBossLife= ratBossLife-playerAttack;
    playerHealth= playerHealth-ratAttack;
     if(ratBossLife<0){
        Console.WriteLine("You killed a rat!");
        
    }
    }while(ratBossLife>=0); 


Console.ReadLine();