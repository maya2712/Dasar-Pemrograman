using System;

namespace Soal_No_1

    // Dasar pemrograman :
    // Desi Maya Sari
    // 2107110665
    // Teknik Informatika Kelas A
{
    class Program
    {
        static void Main(string[] args)
        {

            string Nama;
            int NIM;
            string Konsentrasi;

            Console.WriteLine("");
            Console.WriteLine(">>>>====================================<<<");
            Console.WriteLine("    Silahkan Input Data Detail Mahasiswa");
            Console.WriteLine(">>>=====================================<<<");
            Console.WriteLine("");

            Console.WriteLine("NAMA : ");
            Nama = Console.ReadLine();
            Console.WriteLine("NIM : ");
            NIM = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Konsentrasi : ");
            Konsentrasi = Console.ReadLine();

            Console.WriteLine("|**************************|");
            Console.WriteLine("|NAMA :                " +Nama+ "|");
            Console.WriteLine("|                "+NIM+ "|");
            Console.WriteLine("|--------------------------|");
            Console.WriteLine("|                       "+Konsentrasi+ "|");
            Console.WriteLine("|**************************|");
        }

    }
}

