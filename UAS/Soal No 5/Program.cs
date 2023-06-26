using System;
using System.Collections.Generic;
using System.IO;


namespace Percobaan_desi
{
    class Program
    {
        static void Main()
        {
            string[] Katakata = File.ReadAllLines("Kata.txt");
            Random rnd = new Random();
            string kata = Katakata[rnd.Next(1,14)];
            int kesempatan = 5;
            List<string> hurufTebakanUser = new List<string>{};

            Console.WriteLine("");
            Console.WriteLine(">>>===============================================<<<");
            Console.WriteLine("   | Selamat datang, mari bermain Game Tebak Kata |  ");
            Console.WriteLine(">>>===============================================<<<");

            while (true){
                Console.WriteLine("");
                Console.Write("Apakah huruf tebakan mu? ");
                string input = Console.ReadLine();

                hurufTebakanUser.Add(input);
                if(cekKata(kata,hurufTebakanUser)){
                    Console.WriteLine(">>>===============================================<<<");
                    Console.WriteLine("                 **CONGRATULATION**                  ");
                    Console.WriteLine("     Anda berhasil, Tebakannya adalah... ["+kata+"]   ");
                    Console.WriteLine(">>>===============================================<<<");
                    break;
                }else if(kata.Contains(input)){
                    Console.WriteLine("Selamat tebakan huruf mu benar ");
                    Console.WriteLine(cekHuruf(kata, hurufTebakanUser));
                }else{
                    Console.WriteLine("MAAF tebakan huruf kamu salah :( ");
                    kesempatan = kesempatan - 1;
                    Console.WriteLine("Kesempatan kamu tersisah "+kesempatan);
                    Console.WriteLine("");
                }
                
                if(kesempatan == 0){
                    Console.WriteLine("");
                    Console.WriteLine(">>>===============================================<<<");
                    Console.WriteLine("  |     Game Over, tebakannya adalah ["+kata+"   |   ");
                    Console.WriteLine("  |             Sampai jumpa dahhhh...           |   ");
                    Console.WriteLine(">>>===============================================<<<");
                    Console.WriteLine("");
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
                    return status = false;

                }
            }
            return status;   
        }
    }
}