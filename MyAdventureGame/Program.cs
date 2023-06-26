using System;

namespace MyAdventureGame_DesiMayaSari
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Welcome to this challenging Game Desi Maya Sari");
           Console.WriteLine("This game will invite you to adventure with your abilities");
           Console.WriteLine("Play it carefully, kill all anemies so you can achieve victory...!!!");
           Console.WriteLine("GOOD LUCK");
           Console.WriteLine("What is your name???");
           Console.Read();
           Player player = new Player();
           player.Name = Console.ReadLine();
           Console.WriteLine("Hi, "+player.Name+" Are you ready to play this game??? [yes/no]");
           string bReady = Console.ReadLine();
           if(bReady=="yes"){
               Console.WriteLine("Hi, "+player.Name+" !! is entering the word...");
               Console.WriteLine("You and MELLKY are exploring The Forest....");
               Console.WriteLine();
               Console.WriteLine("You have entered this adventure world, ");
               Console.WriteLine("Where in this adventure world a forest controlled by evil monsters ");
               Console.WriteLine("Who will kill someone who is in this forest ");
               Console.WriteLine("So, you have to destroy those monsters ");
               Console.WriteLine("COME ON...........");
               Console.WriteLine("Suddenly, we met that monste, huahhhhhhhhhhh... ");
               Seizin seizin = new Seizin();
               Encounter encounter1 = new Encounter(player, seizin);
               player.ForceLevelling();
               while(player.JobPoint ==1 && !player.isRunningAway)
               {
                Console.WriteLine(player.Name+" You Sundenly found some Job's....");
                Console.WriteLine("choose the Job you right");
                Console.WriteLine("1.(Archer)");
                Console.WriteLine("2.(Mage)");
                Console.WriteLine("3.(Sworrman)");
                Console.WriteLine("4.(Thief)");
                Console.WriteLine("What is Your Job choice"+player.Name+" ???");
                string playerAction = Console.ReadLine();
                Random rnd = new Random();

                    switch(playerAction)
                    {
                    case "1" :
                    ArcherGameplay archerGameplay = new ArcherGameplay();
                    player.JobPoint--;
                    break;
                    case "2" :
                    MageGameplay mageGameplay = new MageGameplay();
                    player.JobPoint--;
                    break;
                    case "3" :
                    SwordmanGameplay swordmanGameplay = new SwordmanGameplay();
                    player.JobPoint--;
                    break;
                    case "4" :
                    ThiefGameplay thiefGameplay = new ThiefGameplay();
                    player.JobPoint--;
                    break;
                    }
               }
           }else{
               Console.WriteLine("Goodbye....");
               Console.Read();
           }
        }
    }
}