using System;

namespace MyAdventureGame_DesiMayaSari
{
    class MonsterLord : Enemy
    {
        public MonsterLord(){
            Health = 1000;
            attackPower = 100;
            Name = "BEAST LORD MONSTER";
            Console.WriteLine(Name+" is bloking your way!");
            Console.WriteLine(Name+" this is the end, human!");
            Console.WriteLine("PREPARET TO die");
        }

        public override void Skill(Player player)
        {
            Console.WriteLine("METEOR STROM!!");
            player.GetHit((int) 0.33 * player.Health);
        }


        public override void BossSkill(Player player)
        {
            player.GetHit(player.Health);
        }
    }
}