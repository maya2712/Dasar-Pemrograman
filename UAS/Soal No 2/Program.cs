using System;

namespace Soal_No_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Konversi kon = new Konversi();
                Console.WriteLine("Rate UDS to RP : ");
                string angkaPertama = Console.ReadLine();
                Console.WriteLine("Jumlah USD : ");
                string angkaKedua = Console.ReadLine();

                decimal hasil = 0;
           
                {
                    hasil = kon.Kali(decimal.Parse(angkaPertama), decimal.Parse(angkaKedua));
                    if(hasil <= 0)
                    {
                        hasil = 0;
                    }
                    Console.WriteLine($"Hasil Konversi = {hasil} ");
                    
                }
            }
            
                catch(System.DivideByZeroException)
                {
                    Console.WriteLine(" TIDAK BISA DIBAGI DENGAN 0");
                }
                catch(System.FormatException)
                {
                    Console.WriteLine(" TIDAK BISA MEMASUKAN HURUF ");
                }  
                catch(System.Exception)
                {
                    Console.WriteLine(" MAAF ADA KESELAHAN");
                }         
        }
    }

    class Konversi
    {

        public Konversi()
        {
            Console.WriteLine("");
            Console.WriteLine(">>>>=========================================<<<<");
            Console.WriteLine("    Sistem pemrograman mengkonversi Mata Uang    ");
            Console.WriteLine(">>>>=========================================<<<<");
            Console.WriteLine("");
        }

        public decimal Kali(decimal a, decimal b){
            return a * b;
        }
    }
}
