using System;

namespace MyAdventureGame_DesiMayaSari
{
    class MaohZuuh : Enemy
    {
        public MaohZuuh(){
            Health = 200;
            attackPower = 30;
            Name = "MONSTER MAOH-ZUUH";
            Console.WriteLine(Name+" is bloking your way");
        }

        public override void Skill(Player player)
        {
            Console.WriteLine("GIANT CRUSH!!!");
            player.GetHit(4 * attackPower);
        }
    }
}