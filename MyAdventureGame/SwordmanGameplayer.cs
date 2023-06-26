using System;

namespace MyAdventureGame_DesiMayaSari
{
    class SwordmanGameplay
    {
        public SwordmanGameplay()
        {   
            Archer player = new Archer();
            Shouzun shouzun = new Shouzun();
            MaohZuuh maohZuuh = new MaohZuuh();
            MonsterLord lod = new MonsterLord();
            Console.WriteLine();
            TreasureBox treasureBox = new TreasureBox();
            treasureBox.treasureBox();
            if(treasureBox.Correct)
            {
                player.attackPower = player.attackPower + 10;
            }
            
            
            Encounter encounter2 = new Encounter(player, shouzun);
            
            Encounter encounter3 = new Encounter(player, maohZuuh);
            
            Encounter bossEncounter = new Encounter(player, lod);
           }
        }
    }