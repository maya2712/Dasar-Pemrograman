using System;
using System.Linq;


namespace M13_Latihan_3_DESIMAYASARI
{
    class Program
    {
        static int[] Harga_HandphoneMerkOppo = {1000000, 1500000, 2000000, 2800000, 3500000, 5000000};
        static int[] Harga_HandphoneMerkVivo   = {800000, 1500000, 1800000, 2200000, 3400000, 4000000};
        static int[] Harga_HandphoneMerkReadmi = {700000, 1000000, 1300000, 1700000, 2000000, 2500000};

        static void Main(string[] args)
        {
           Console.WriteLine(" ");
           Console.WriteLine("SELAMAT DATANG.....");
           Console.WriteLine("Silahkan dichek untuk Data Produk dari Elektronik Kami !!! ");
           Console.ReadLine();

           Console.WriteLine("Data Harga Handphone Termurah : ");
           hitungMin(Harga_HandphoneMerkOppo, "Handphone Merk Oppo");
           hitungMin(Harga_HandphoneMerkVivo, "Handphone Merk Vivo");           
           hitungMin(Harga_HandphoneMerkReadmi, "HandPhone Merk Readmi");
           Console.WriteLine(" ");

           Console.WriteLine("Data Harga Handphone TerMahal : ");
           hitungMax(Harga_HandphoneMerkOppo, "Handphone Merk Oppo");           
           hitungMax(Harga_HandphoneMerkVivo, "Handphone Merk Vivo");           
           hitungMax(Harga_HandphoneMerkReadmi, "HandPhone Merk Readmi");
           Console.WriteLine(" ");

           hitungRata2(Harga_HandphoneMerkOppo, "Handphone Merk Oppo");
           hitungRata2(Harga_HandphoneMerkVivo, "Handphone Merk Vivo");
           hitungRata2(Harga_HandphoneMerkReadmi, "HandPhone Merk Readmi");
           Console.WriteLine(" ");

           Console.WriteLine("Data Harga Handphone Termurah : ");
           hitungMin2(Harga_HandphoneMerkOppo, "Handphone Merk Oppo");
           hitungMin2(Harga_HandphoneMerkVivo, "Handphone Merk Vivo");           
           hitungMin2(Harga_HandphoneMerkReadmi, "HandPhone Merk Readmi");
           Console.WriteLine(" ");

           Console.WriteLine("Data Harga Handphone TerMahal : ");
           hitungMax2(Harga_HandphoneMerkOppo, "Handphone Merk Oppo");           
           hitungMax2(Harga_HandphoneMerkVivo, "Handphone Merk Vivo");           
           hitungMax2(Harga_HandphoneMerkReadmi, "HandPhone Merk Readmi");
           Console.WriteLine(" ");

           Console.WriteLine("Data Harga Handphone RAta-rata : ");
           hitungRata3(Harga_HandphoneMerkOppo, "Handphone Merk Oppo");
           hitungRata3(Harga_HandphoneMerkVivo, "Handphone Merk Vivo");
           hitungRata3(Harga_HandphoneMerkReadmi, "HandPhone Merk Readmi");
           Console.WriteLine(" ");

        }

        static void hitungMin(int[] harga, string tipe){
            int min = harga[0];
            for (int i = 0; i < harga.Length; i++)
            {
                if (harga[i] < min)
                {
                    min = harga[i];
                }
                
            }
            Console.WriteLine("Harga Termurah Untuk {1} adalah Rp.{0}", min, tipe);
        }
        static void hitungMax(int[] harga, string tipe){
            int max = harga[0];
            for (int i = 0; i < harga.Length; i++)
            {
                if (harga [i] > max)
                {
                    max = harga[i];
                }
            }
            Console.WriteLine("Harga Termahal Untuk {1} adalah Rp.{0}", max, tipe);
        }
        static void hitungRata2(int[] harga, string tipe){
            double avg = harga.Average();
            for (int i = 0; i < harga.Length; i++)
            {
                avg = harga.Average();
            }
            Console.WriteLine("Harga  rata - rata untuk {1} adalah Rp.{0}", avg, tipe);
        }

         static double hitungMin2(int[] harga, string tipe){
            int min = harga[0];
            for (int i = 0; i < harga.Length; i++)
            {
                if (harga[i] < min)
                {
                    min = harga[i];
                }
                
            }
            Console.WriteLine("Harga Termurah Untuk {1} adalah Rp.{0}", min, tipe);
            return min;
        }
        static double hitungMax2(int[] harga, string tipe){
            int max = harga[0];
            for (int i = 0; i < harga.Length; i++)
            {
                if (harga [i] > max)
                {
                    max = harga[i];
                }
            }
            Console.WriteLine("Harga Termahal Untuk {1} adalah Rp.{0}", max, tipe);
            return max;
        }
        static double hitungRata3(int[] harga, string tipe){
            double avg = harga.Average();
            for (int i = 0; i < harga.Length; i++)
            {
                avg = harga.Average();
            }
            Console.WriteLine("Harga  rata - rata untuk {1} adalah Rp.{0}", avg, tipe);
            return avg;
        }
    }
}
