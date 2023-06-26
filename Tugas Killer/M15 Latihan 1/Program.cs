using System;
using System.IO;

namespace M15_Latihan_1_DESIMAYASARI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Data Nilai Desimal :");
            Console.WriteLine("2.3");
            Console.WriteLine("22.52");
            Console.WriteLine("12.3");
            Console.WriteLine("1.9");
            Console.WriteLine("3.35");
            Console.WriteLine("4.5");
            Console.WriteLine("17.3");
            Console.WriteLine("23.1");
            Console.WriteLine("6.25");
            Console.WriteLine("8.18");
            Console.WriteLine("2.9");
            Console.WriteLine("10.2");
            Console.WriteLine("Operasi Aritmatika dari File Data Nilai Desimal Min, Max dan AVG ");
            Console.WriteLine("Tekan Enter untuk Menampilkan");
            Console.ReadLine();

            min("desimal.txt");
            max("desimal.txt");
            avg("desimal.txt");
            
        }
        //Method dibawah ini digunakan untuk menemukan nilai rata rata dari file berisi desimal
        static float avg(string namaFile)
        {
            int panjang = 0;
            float total = 0;
            foreach(string p in File.ReadAllLines(namaFile))
            {
                float price;
                if(float.TryParse(p, out price))
                {
                    total += price;
                    panjang++;
                }
                
            }
            Console.WriteLine("Rata rata dari semua nilai adalah : "+total/panjang);
            Console.WriteLine("");
            return total;
            
        }
        //Method dibawah ini digunakan untuk menemukan nilai min dari file berisi desimal
        static double min(string namaFile)
        {
            string[] Score = File.ReadAllLines(namaFile);
            double[] Angka = new double[12];
            int p = 0;
            foreach (string item in Score){
                Angka[p++] = Convert.ToDouble(item);
            }
            double min = Angka[0];
            for(int i = 1; i < Angka.Length; i++)
            {
                if (Angka[i] < min)
                {
                    min = Angka[i];
                }
            }
            Console.WriteLine("Nilai paling kecil : {0}", min);
            return min;
        }
        //Method dibawah ini digunakan untuk menemukan nilai max dari file berisi desimal
        static double max(string namaFile)
        {
            //Masukkan semua line dari file kedalam sebuah array
            string[] Score = File.ReadAllLines(namaFile);
            //initiate array untuk menampung string yang diubah jadi double
            double[] Angka = new double[Score.Length];
            int p = 0;
            foreach (string item in Score)
            {
                Angka[p++] = Convert.ToDouble(item);
            }
            double max = Angka[0];
            for(int i = 1; i < Angka.Length; i++)
            {
                if (Angka[i] > max)
                {
                    max = Angka[i];
                }
            }
            Console.WriteLine("Nilai paling besar : {0}", max);
            return max;
        }
    }
}