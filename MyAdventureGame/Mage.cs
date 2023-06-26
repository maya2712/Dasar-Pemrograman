using System;

namespace MyAdventureGame_DesiMayaSari
{
    class Mage : Player
    {
        public int Mana { get; set; }

        public Mage(){
            Health = 200;
            attackPower = 15;
            Mana = 0;
        }

        public override void Skill(Enemy enemy)
        {
            if(Mana >= 10){
                Console.WriteLine("Skill : Thunder Bolt");
                Console.WriteLine("ZAAPP!!");
                enemy.GetHit(attackPower + 100);
                Mana = 0;
            }else{
                Console.WriteLine("Mana : "+Mana);
                Console.WriteLine("You dont have enouht mana");
            }
        }

        public override void Defend()
        {
            base.Defend();
            Console.WriteLine("Generation mana ...");
            Mana+=2;
        }
    }
}