using System;

namespace MyAdventureGame_DesiMayaSari
{
    class Shouzun : Enemy
    {
        public Shouzun(){
            Health = 150;
            attackPower = 20;
            Name = "MONSTER SHOU-ZUN";
            Console.WriteLine(Name+" is blocking your way!");      
        }

        public override void Skill(Player player)
        {
            Console.WriteLine("BONE BOOM");
            player.GetHit(3 * attackPower);
        }
        }       
    }