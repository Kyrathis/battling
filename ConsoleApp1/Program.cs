using ConsoleApp1.Classes;
using System.Runtime.CompilerServices;


//Checks to see if the hero and enemy is alive.
void CombatLoop(Hero playerHero, Enemy chosenEnemy)
{
    while (playerHero.IsAlive() == true && chosenEnemy.isAlive() == true)
    {
        if (playerHero.IsAlive() == true && chosenEnemy.isAlive() == true)
        {
            ChooseAction(playerHero, chosenEnemy);
        }
    }
}

//Asks what the player would like to do. Current choices are attack / defend. 
void ChooseAction(Hero playerHero, Enemy chosenEnemy)
{
    Console.WriteLine("What would you like to do? Attack / Defend?");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "Attack":
            PlayerAttack(playerHero, chosenEnemy);
            EnemyAttack(chosenEnemy, playerHero);
            break;
        case "Defend":
            playerBlock(playerHero, chosenEnemy);
            break;
    }
}

//Has the player pick their class.
Hero ChooseHero(string playerName)
{
    Hero chosenHero = null;
    Console.WriteLine("Choose your hero. Mage, Rogue, Warrior.");
    string optionChoice = Console.ReadLine();

    switch(optionChoice)
    {
        case "Mage":
            Hero mage = new(playerName, 8, 5, 2, 1, "Mage");
            chosenHero = mage;
            break;
        case "Rogue":
            Hero rogue = new(playerName, 9, 4, 3, 1, "Rogue");
            chosenHero = rogue;
            break;
        case "Warrior":
            Hero warrior = new(playerName, 10, 4, 4, 1, "Warrior");
            chosenHero = warrior;
            break;
    }

    return chosenHero;
}

//Enemy attack logic
void EnemyAttack(Enemy chosenEnemy, Hero playerHero)
{
    int EnemyDamage = chosenEnemy.EnemyAttack();
    int totalDamage = EnemyDamage - playerHero.DEF;

    if (totalDamage < 0)
    {
        totalDamage = 0;
    }

    Console.WriteLine($"{chosenEnemy.Name} has dealt {totalDamage} to {playerHero.Name}");
    playerHero.HP -= totalDamage;
    Console.WriteLine($"{playerHero.Name} has {playerHero.HP} hp remaining.");

}

//Asks the player what their name is.
string getPlayerName()
{
    string playerName = "";


    while (playerName == "")
    {
        Console.WriteLine("What is your name?");
        playerName = Console.ReadLine();
    }

    return playerName;
}

//Gonna be real. I don't know why I have a single function just to greet the player.
void greetPlayer(Hero playerHero)
{
    Console.WriteLine($"Hello there, {playerHero.Name}, you are playing as a {playerHero.ClassName}");
}

//main battle loop?  I think this is the main "index" function. I start the program through here. 
void MainLoop()
{
    string playerName = getPlayerName();
    Hero playerHero;
    playerHero = ChooseHero(playerName);
    greetPlayer(playerHero);
    Enemy chosenEnemy = PickEnemy();
    Console.WriteLine($"{chosenEnemy.Name} has appeared.");

    CombatLoop(playerHero, chosenEnemy);

    Console.ReadLine();

}

//Player attack logic
void PlayerAttack(Hero playerHero, Enemy chosenEnemy)
{
    int playerDamage;
    int totalDamage;

    playerDamage = playerHero.PlayerAttack();
    //enemy block
    totalDamage = playerDamage - chosenEnemy.DEF;

    if (totalDamage < 0) {
        totalDamage = 0;
    }

    Console.WriteLine($"{playerHero.Name} has dealt {totalDamage} to {chosenEnemy.Name}.");
    //subtract damage from enemy hp
    chosenEnemy.HP -= totalDamage;
    Console.WriteLine($"{chosenEnemy.Name} has {chosenEnemy.HP} hp remaining.");
}

//player block logic
void playerBlock(Hero playerHero, Enemy chosenEnemy)
{
    Random rnd = new Random();

    int playerblock = playerHero.DEF + rnd.Next(1, 4);
    int enemyDamage = chosenEnemy.EnemyAttack();
    int totalDamage = enemyDamage - playerblock;

    Console.WriteLine($"{chosenEnemy.Name} has dealt {totalDamage} to {playerHero.Name}");
}

//Generates a random enemy. 
//to do: Have multiple enemies. 
Enemy PickEnemy()
{
    Enemy chosenEnemy = null;
    Random rnd = new Random();
    int enemyPicker = rnd.Next(1, 3);

    switch (enemyPicker)
    {
        case 1:
            Enemy goblin = new("Goblin", 15, 3, 2);
            chosenEnemy = goblin;
            break;
        case 2:
            Enemy rickyKid = new("Ricky the Kid", 3, 50, 1);
            chosenEnemy = rickyKid;
            break;
        case 3:
            Enemy bigRicky = new("Big Ricky", 50, 2, 4);
            chosenEnemy = bigRicky;
            break;
    }

    return chosenEnemy;
}

//I was right. MainLoop is my "index" function.  The program starts from this.
MainLoop();