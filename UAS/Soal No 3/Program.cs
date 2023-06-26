using System;

namespace Soal_No_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            string Nama;
            int TahunLahir;

                Console.WriteLine("");
                Console.WriteLine(">>>==========================================<<<");
                Console.WriteLine("  Selamat Datang Pada Pembuatan Tiket BIOSKOP ");
                Console.WriteLine(">>>==========================================<<<");
                Console.WriteLine("");

                Console.WriteLine("Nama Anda : ");
                Nama = Console.ReadLine();
                Console.WriteLine("Tahun Kelahiran anda  : ");
                TahunLahir = Convert.ToInt32(Console.ReadLine());

             if(2021 - TahunLahir < 10 || 2021 - TahunLahir > 60)
             {
                Console.WriteLine("|*****************************|");
                Console.WriteLine("|    ----- STUDIO 1 ----      |");
                Console.WriteLine("|Nama  :                  " + Nama+ "|");
                Console.WriteLine("|Harga :             10.000,00|");
                Console.WriteLine("|*****************************|");

            }else{

            if(2021 - TahunLahir > 10 || 2021 - TahunLahir < 60)
                Console.WriteLine("|*****************************|");
                Console.WriteLine("|    ----- STUDIO 2 ----      |");
                Console.WriteLine("|Nama  :                  " + Nama+ "|");
                Console.WriteLine("|Harga :             25.000,00|");
                Console.WriteLine("|*****************************|");
             }
        }
    }
}