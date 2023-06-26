using System;

namespace Modul_13_latiahan_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Data Nilai UAS Siswa/i SMAN 1 BANGKO PUSAKO Kelas XII ANGKATAN TAHUN 2021");
            Console.WriteLine("");
            decimal[] values = { 7.37m, 7.10m, 6.05m, 8.05m, 7.53m };
            Console.WriteLine(" Nilai Rata-rata      Nilai Tertinggi        Nilai Terndah\n");

            foreach (decimal value in values)
            {
            Console.WriteLine("{0,9} {1,20} {2,20}", 
                                value,  Math.Ceiling(value),  Math.Floor(value));                     
            }
        }    
    }
}                    

// the example display the following output to the console:
//          Nilai Rata-rata              Nilai Tertinggi          Nilai Terndah
  
//              7.37                            8                       7
//              7.10                            8                       7
//              6.05                            7                       6
//              8.05                            9                       8
//              7.53                            8                       7
