using System;

namespace MyAdventureGame_DesiMayaSari
{
    class Swordman : Player
    {
        public int Rage { get; set; }
        public static int stunDuration = 3;

        public Swordman(){
            Health = 500;
            attackPower = 8;
            Rage = 0;
        }

        public override void Skill(Enemy enemy)
        {
            Console.WriteLine("Skill : Heavy Attack");
            if(Rage >=3){
                stunDuration = 3;
                Console.WriteLine("BASH!!!");
                Console.WriteLine(enemy.Name+" is being stunned for "+stunDuration+"seconds");
                enemy.isStunned = true;
                enemy.GetHit(3*attackPower);
                Rage = 0;
            }else{
                Console.WriteLine("Rage : "+Rage);
                Console.WriteLine("You do not enough rage..."); 
            }
        }

        public override void Defend()
        {
            base.Defend();
            Console.WriteLine("Generation rage...");
            Rage++;
        }
    }
}