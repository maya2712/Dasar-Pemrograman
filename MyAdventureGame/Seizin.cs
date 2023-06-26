using System;

namespace MyAdventureGame_DesiMayaSari
{
    class Seizin : Enemy
    {
     public Seizin(){
         Health = 100;
         attackPower = 10;
         Name = "MONSTER SEI-ZIN";
         Console.WriteLine(Name+" is blocking you way!");
     }

     public override void Skill(Player player)
     {
         Console.WriteLine("STOPPP!!!");
         base.Skill(player);
     }
    }
}