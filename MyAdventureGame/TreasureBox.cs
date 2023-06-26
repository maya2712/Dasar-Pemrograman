using System;
using System.Collections.Generic;
namespace MyAdventureGame_DesiMayaSari
{
    class TreasureBox
    {
        public bool Correct { get; set; }
        public void treasureBox()
        {
            string kata = "lion";
            int kesempatan = 5;
            List<string> hurufTebakanUser = new List<string>{};

            Console.WriteLine("Welcome, Congrats you got a treasure");
            Console.WriteLine("to get the treasure let's you have to guess word, ");
            Console.WriteLine("Les's play guess the word...");
            Console.WriteLine($"You have {kesempatan} chance to guess ");
            Console.WriteLine("The clue is that the word is the name of a wild animal that lives in the forest");
            Console.WriteLine($"This word consists of {kata.Length} latter");

            while (true)
            {
                Console.Write("What is your latter???");
                string input = Console.ReadLine();

                hurufTebakanUser.Add(input);
                if(cekKata(kata,hurufTebakanUser)){
                    Console.WriteLine("CONGRATS you guessed it... ["+kata+"] ");
                    Console.WriteLine("OK....NEXT!!!!! ");
                    Console.WriteLine();
                    Correct = true;
                    break;
                }else if(kata.Contains(input)){
                    Console.WriteLine("CONGRATS you guess is correct... ");
                    Console.WriteLine(cekHuruf(kata, hurufTebakanUser));
                }else{
                    Console.WriteLine("SORRY, YOUR GUESS IS WRONG :( ");
                    kesempatan = kesempatan - 1;
                    Console.WriteLine("You chance is left "+kesempatan);
                }
                
                if(kesempatan == 0){
                    Console.WriteLine("The GAME OVER, The guess is ["+kata+" ");
                    Console.WriteLine("see you... ");
                    break;
                }
            }
        }

        static string cekHuruf(string kata_rahasia, List<string> tebakanUser){
            string output = "";
            for(int i=0 ; i<kata_rahasia.Length ; i++){
                string c = Convert.ToString(kata_rahasia[i]);
                if(tebakanUser.Contains (c)){
                    output = output + c;
                }else{
                    output = output + "  * ";

                }
            }
            return output;    
        }

         static bool cekKata(string kata_rahasia, List<string> tebakanUser){
            bool status = false;
            for(int i=0 ; i<kata_rahasia.Length ; i++){
                string c = Convert.ToString(kata_rahasia[i]);
                if(tebakanUser.Contains(c)){
                    status = true;
                }else{
                    status = false;

                }
            }
            return status;   
        }
    }
}
