using System;

namespace Dasar_Pemograman
{
    class Program
    {
        static void Intro(int level){
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui...");
            Console.WriteLine("Mulai Level "+level);
    }

        static bool MulaiMain(int level){

            Intro(level);
            // Deklarasi dan inisialisasi variabel
            // created by DESIMAYASARI

            Random rnd = new Random();

            int codeA = rnd.Next(level);//rnd.Next(5) = 0,1,2,3,4
            int codeB = rnd.Next(level);
            int codeC = rnd.Next(level);
            int codeD = rnd.Next(level);
            int hasilTambah = 0;
            int hasilKali = 0;

            hasilTambah = codeA + codeB + codeC + codeD;
            hasilKali = codeA * codeB * codeC * codeD;

            Console.WriteLine("+ Kode Password terdiri dari 4 angka");
            Console.WriteLine("+ Hasil Penjumlahan Kode = "+hasilTambah);
            Console.WriteLine("+ Hasil Perkalian Kode = "+hasilKali);
            Console.Write("Enter Kode Pertama : ");
            string tebakanA = Console.ReadLine();
            Console.Write("Enter Kode Kedua : ");
            string tebakanB = Console.ReadLine();
            Console.Write("Enter Kode Ketiga : ");
            string tebakanC = Console.ReadLine();
            Console.Write("Enter Kode Keempat : ");
            string tebakanD = Console.ReadLine();

            Console.WriteLine("Tebakan Anda : " + tebakanA + tebakanB + tebakanC + tebakanD);

            int tebakA = Convert.ToInt32(tebakanA);
            int tebakB = Convert.ToInt32(tebakanA);
            int tebakC = Convert.ToInt32(tebakanA);
            int tebakD = Convert.ToInt32(tebakanA);

            if (codeA == tebakA && codeB == tebakB && codeC == tebakC && codeD == tebakD){
                 Console.WriteLine("tebakan anda benar, Congratulation..");
                 return true;
            }else
            {
                 Console.WriteLine("tebakan anda salah, coba lagi...");
                 return false;
            } 
        }

        //Ini adalah main function Saya
        static void Main(string[] args)
        {
            int level = 1;
            int maxLevel = 5;
            while (level <= maxLevel){
                bool bGameSelesai = MulaiMain(level);

                if(bGameSelesai){
                    level++;
                }
            }
                 
            Console.WriteLine("Selamat anda sudah memecahkan semua kode, laporkan ASAP ke pusat komando..");
        }
    }
}


