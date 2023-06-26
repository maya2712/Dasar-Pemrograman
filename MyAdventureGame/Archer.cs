using System;

namespace MyAdventureGame_DesiMayaSari
{
    class Archer : Player
    {
        public int Energy { get; set; }

        public Archer(){
            Health = 300;
            attackPower = 10;
            Energy = 0;
        }

        public override void Skill(Enemy enemy)
        {
            if(Energy>=10){
                Console.WriteLine("SKILL : Multi Snipe");
                for(int i=0;i<=Energy;i+=2){
                    Console.WriteLine("HEADSHOT!!!");
                }
                enemy.GetHit(5 * attackPower);
                Energy = 0;
            }else{
                Console.WriteLine("Energy : "+Energy);
                Console.WriteLine("You need more energy");
            }
        }

        public override void Defend()
        {
            base.Defend();
            Console.WriteLine("Generation energy...");
            Energy+=5;
        }
    }
}