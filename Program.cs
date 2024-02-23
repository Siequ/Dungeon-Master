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
string specialAbility="";
int playerHealth = 0;
int playerMana = 0;
int playerBaseDmg = 0;
string? playerAttack="";
int specialLimit = 1;
int castDmg = 60;

Random randomDmg = new Random();

Console.Clear();
if(choosedClassOption == 1){
specialAbility="Dodge";

playerHealth = playerHealth+450;
Console.WriteLine($"You selected Rogue, your health is: {playerHealth} and your special ability is {specialAbility}");
}
else if(choosedClassOption == 2 ){
    specialAbility="Double Attack";
    
    playerHealth = playerHealth+600;
    Console.WriteLine($"You selected Barbarian, your health is: {playerHealth} and your special ability is {specialAbility}");
}
else {
    specialAbility="Cast";
    playerHealth = playerHealth+350;
    playerMana = playerMana+60;
    
    Console.WriteLine($"You selected Mage, your health is: {playerHealth}, your mana: {playerMana} and your special ability is {specialAbility}");
}
    int ratAttack;
    int ratBossLife = 300;
        
    Console.WriteLine("\nYou've entered small dungeon, after exploring it, a big, mutated rat apperead - it seems like you have to fight for your life! \n ");
    
    Console.ReadLine();
    Console.Clear();
    do{

    switch(choosedClassOption){

        case 1:
        playerBaseDmg = randomDmg.Next(20,28);
        break;

        case 2:
        playerBaseDmg = randomDmg.Next(30,40);
        break;

        case 3:
        playerBaseDmg = randomDmg.Next(18,25);
        break;

    }

    ratAttack = randomDmg.Next(15,20);
    
    
    specialAbility = specialAbility.ToLower();
    if(ratBossLife>0){
        Console.WriteLine("\ntype 'attack' to hit with basic attack/spell "+(choosedClassOption==2 && specialLimit>0 || choosedClassOption==3 && specialLimit>0 ? "or type '"+specialAbility+"' to use your ability" : ""));
        Console.WriteLine("\n Rat's hp:"+ratBossLife+" Your hp: "+playerHealth+(choosedClassOption==3 ? "Your Mana: "+playerMana : ""));
        playerAttack = Console.ReadLine()?.ToLower().Trim();

        

        if(playerAttack=="attack"){
            Console.Clear();
            
    ratBossLife= ratBossLife-playerBaseDmg;
    playerHealth= playerHealth-ratAttack;

    Console.WriteLine($"\nYou dealt {playerBaseDmg} damage to the rat, you recived {ratAttack} damage");

    }
    else if(playerAttack=="double attack"){
        Console.Clear();
        ratBossLife = ratBossLife-(playerBaseDmg+playerBaseDmg);
        playerHealth= playerHealth-ratAttack;
        Console.WriteLine($"\nYou dealt {playerBaseDmg*2} damage (double attack!) to the rat, you recived {ratAttack} damage");
        specialLimit-=1;
    }
    

    }
   
    
   

     if(ratBossLife<=0){
        Console.Clear();
        Console.WriteLine("You killed a rat!");
        
    }
     else if(playerHealth<0){
        Console.WriteLine("You died!");
    
    }
    }while(ratBossLife>=0 && playerHealth>=0); 


Console.ReadLine();