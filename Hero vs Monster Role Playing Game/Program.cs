// Hero v Monster Role Playing Game
// David Lincoln

Random random = new Random();


String Hero = "Hero";
String Monster = "Monster";

int HeroHealth = 100;
int MonsterHealth = 100;    

int HeroAttack = random.Next(1, 15);
int MonsterAttack = random.Next(1, 15);

while (HeroHealth > 0 && MonsterHealth > 0)
{
    MonsterHealth -= HeroAttack;
    HeroHealth -= MonsterAttack;
    
    Console.WriteLine($"{Hero} attacks {Monster} for {HeroAttack} damage. {Monster} has {MonsterHealth} health remaining.");
    Console.WriteLine($"{Monster} attacks {Hero} for {MonsterAttack} damage. {Hero} has {HeroHealth} health remaining.");
    
    if (HeroHealth <= 0)
    {
        Console.WriteLine($"{Hero} has been defeated!");
    }
    else if (MonsterHealth <= 0)
    {
        Console.WriteLine($"{Monster} has been defeated!");
    }
    else
    {
        HeroAttack = random.Next(1, 15);
        MonsterAttack = random.Next(1, 15);
    }
}
