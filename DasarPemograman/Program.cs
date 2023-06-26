using System;

namespace DasarPemograman_DESIMAYASARI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
           Kalkulator kal = new Kalkulator();
           Console.Write("Input angka pertama : ");
           string angkaPertama = Console.ReadLine();
           Console.Write("input angka kedua : ");
           string angkaKedua = Console.ReadLine();
           Console.WriteLine("Pilih Jenis operasi");
           Console.WriteLine("1. Tambah ");
           Console.WriteLine("2. Kurang ");
           Console.WriteLine("3. Kali ");
           Console.WriteLine("4. Bagi ");
           string operasi = Console.ReadLine();
            double hasil = 0;


           switch (operasi)
           {
               case "1" : 
               hasil = kal.Tambah(int.Parse(angkaPertama), int.Parse(angkaKedua));
               if(hasil <= 0){
                  hasil = 0;
              }
               Console.WriteLine($"{angkaPertama} + {angkaKedua} = {hasil}");
              break;
              case "2" : 
              hasil = kal.Kurang(int.Parse(angkaPertama), int.Parse(angkaKedua));
              if(hasil <= 0){
                  hasil = 0;
              }
              Console.WriteLine($"{angkaPertama} - {angkaKedua} = {hasil}");
              break;
              case "3" : 
              hasil = kal.Kali(int.Parse(angkaPertama), int.Parse(angkaKedua));
              if(hasil <= 0){
                  hasil = 0;
              }
              Console.WriteLine($"{angkaPertama} * {angkaKedua} = {hasil}");
              break;
              case "4" : 
              hasil = kal.Bagi(double.Parse(angkaPertama), double.Parse(angkaKedua));
              if(hasil <= 0){
                  hasil = 0;
              }
              Console.WriteLine($"{angkaPertama} / {angkaKedua} = {hasil}");
              break;
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

    class Kalkulator{

        public Kalkulator(){
            Console.WriteLine("Ini adalah Kalkulator Sederhana");
        }

        public int Tambah(int a, int b){
            return a + b;
        }

        public int Kurang(int a, int b){
            return a - b;
        }

        public int Kali(int a, int b){
            return a * b;
        }

        public double Bagi(double a, double b){
            return a / b;
        }
    }
}
