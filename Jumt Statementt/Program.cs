using System;

namespace Jumt_Statement_DESIMAYASARI
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[,] dosen = new string[5,2];
            
            for(int i=0; i<5; i++){
                Console.WriteLine("Masukkan Nama Dosen : ");
                dosen[i,0] = Console.ReadLine();
                
                Console.WriteLine("Masukkan NIP Dosen : ");
                dosen[i,1] = Console.ReadLine();
            }
            
            for(int i=0; i<5; i++){
                int tahunLahir = getTahunLahir(dosen[i,1]);
                if(2021 - tahunLahir > 45){
                        continue;
                }
                Console.WriteLine("Data Dosen " + (i+1));
                Console.WriteLine("Nama : " + dosen[i,0]);
                Console.WriteLine("NIP : " + dosen[i,1] + "\n");
            }
        }
        
        static int getTahunLahir(string nip){
            char[] charNIP = nip.ToCharArray();
            string tahunLahir = "";
            for(int i=0; i<4; i++){
                tahunLahir += charNIP[i].ToString();
            }
            int tahun = int.Parse(tahunLahir);
            
            return tahun;        
        }
    }
}
