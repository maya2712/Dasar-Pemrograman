using System;

namespace MyAdventureGame_DesiMayaSari
{
    class Thief : Player
    {
        public int comboPoint { get; set;}

        public Thief(){
            Health = 300;
            attackPower = 5;
            comboPoint = 0;
        }

        public override void Skill(Enemy enemy)
        {
            if(comboPoint >= 3){
                Console.WriteLine("Skill : Assasination");
                for(int i=0;i<=comboPoint;i++){
                    Console.WriteLine("SLASH!!!");
                    enemy.GetHit(attackPower + rnd.Next(3,10));
                }
                comboPoint = 0 ;
            }else{
                Console.WriteLine("Combo Point : "+comboPoint);
                Console.WriteLine("You need more to generatin more combo point");
            }
        }
        
        public override void Defend()
        {
            base.Defend();
            Console.WriteLine("Generation combo point ...");
            comboPoint++;
        }
    }
}