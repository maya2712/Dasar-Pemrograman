using System;

namespace MyAdventureGame_DesiMayaSari
{
    class Encounter
    {
        public Encounter(Player player, Enemy enemy){
            Console.WriteLine(player.Name+" is encountering "+enemy.Name);
            Console.WriteLine(enemy.Name+" attacking you,,,,");
            Console.WriteLine("Choose your action...???");
            Console.WriteLine("1. Single Attack");
            Console.WriteLine("2. Skill");
            Console.WriteLine("3. Defend");
            Console.WriteLine("4. Run Away");
            if(Swordman.stunDuration <= 0){
                enemy.isStunned = false;
            }
            while(!enemy.isDead && !player.isDead && !player.isRunningAway){
                Console.Write("Choose your action : ");
                string playerAction = Console.ReadLine();
                Random rnd = new Random();
                switch(playerAction){
                    case "1" :
                    Console.WriteLine("you are doing single attack");
                    enemy.GetHit(player.attackPower);
                    if(!enemy.isStunned){
                        player.GetHit(enemy.attackPower);
                    }
                    player.Exp+=0.3f;
                    Console.WriteLine("Player Health : "+player.Health+" | Enemy Healt : "+enemy.Health);
                    break;
                    case "2" :
                    player.Skill(enemy);
                    player.Exp+=0.9f;
                    Console.WriteLine("Player Health : "+player.Health+" | Enemy Healt : "+enemy.Health);
                    break;
                    case "3" :
                    player.Defend();
                    if(!enemy.isStunned){
                        if(rnd.Next(1,4)==2){
                        enemy.Skill(player);
                        }
                    }
                    player.Exp+= 0.2f;
                    Console.WriteLine("Player Health : "+player.Health+" | Enemy Healt : "+enemy.Health);
                    break;
                    case "4" :
                    player.isRunningAway = true;
                    Console.WriteLine("Your are attempt to run away");
                    player.Exp = 0;
                    Console.Read();
                    break;
                }
                if(enemy.isStunned){
                    Swordman.stunDuration--;
                }
            }
            if(enemy.isDead){
                Console.Write(" You get "+player.Exp+" Experience Poin....");
                Console.WriteLine("CONGRATULATION "+enemy.Name+" Already killed, let's move on to the next stage");
                Console.WriteLine(" Level UP");
                player.Health += 100;
                player.attackPower += 10;
                Console.WriteLine("Player Health : "+player.Health+" | Enemy Healt : "+enemy.Health);
            }else if(player.isDead){
                Console.WriteLine("OHHHHH NO, YOU'RE DEAD...... ");
                Console.WriteLine("You're a victim in this forest because you've been killed by that evil moster");
                Console.WriteLine();
                Console.WriteLine("Thank you for playing in this adventure Game, ");
                Console.WriteLine("While enjoing defeat because you have failed in this Game...");
                Console.WriteLine("FAILURE IS NOT DESTRUKCTION...");
                Console.WriteLine("See you...");
                Console.WriteLine("GAME OVERRRR...");
                Environment.Exit(0);
            }
        }
    }
}  