using System;

namespace Tugas_Modul_14_Latihan2_DESIMAYASARI
{
    class DataMahasiswa
    {
        string Nama ;
        int NIM;
        public string Konsentrasi;
        string Angkatan;

        public DataMahasiswa(string nama,int nim, string konsentrasi,string angkatan)
        {
            Nama = nama;
            NIM = nim;
            Konsentrasi = konsentrasi;
            Angkatan = angkatan;
        }
        public void printRPL()
        {
                if(Konsentrasi == "RPL")
                {
                    Console.WriteLine("Nama : "+Nama);
                    Console.WriteLine("NIM : "+NIM);
                    Console.WriteLine("Konsent : "+Konsentrasi);
                    Console.WriteLine("ANGKATAN : "+Angkatan);
                    Console.WriteLine();
                }
        }
        public void printKCV()
        {
            if(Konsentrasi == "KCV")
            {
                    Console.WriteLine("Nama : "+Nama);
                    Console.WriteLine("NIM : "+NIM);
                    Console.WriteLine("Konsent : "+Konsentrasi);
                    Console.WriteLine("ANGKATAN : "+Angkatan);
                    Console.WriteLine();
            }
        }
        public void printKBJ()
        {
            if(Konsentrasi == "KBJ")
            {
                    Console.WriteLine("Nama : "+Nama);
                    Console.WriteLine("NIM : "+NIM);
                    Console.WriteLine("Konsent : "+Konsentrasi);
                    Console.WriteLine("ANGKATAN : "+Angkatan);
                    Console.WriteLine();
            }
        }
    }
    class MahasiswaDetail
    {
        static void Main(string[] args)
        {
            DataMahasiswa[] Data = new DataMahasiswa[10];
            string Nama;
            int NIM;
            string Konsentrasi;
            string Angkatan;

            for(int a = 0; a < Data.Length; a++)
            {
                Console.WriteLine("");
                Console.WriteLine("Data Mahasiswa Teknik Informatika Universitas Riau ");
                Console.WriteLine("");
                Console.WriteLine("Silahkan Input Data Detail Mahasiswa {0} ",a+1);
                Console.Write("NAMA : ");
                Nama = Console.ReadLine();
                Console.Write("NIM : ");
                NIM = Convert.ToInt32(Console.ReadLine());
                Console.Write("Konsentrasi : ");
                Konsentrasi = Console.ReadLine();
                Console.Write("ANGKATAN : ");
                Angkatan = Console.ReadLine();
                Console.WriteLine();

                Data[a] = new DataMahasiswa(Nama,NIM, Konsentrasi, Angkatan);
            }

            Console.Clear();
            Console.WriteLine("=======================================================");
            Console.WriteLine();
            for(int a = 0; a < Data.Length; a++)
            {
                Data[a].printKCV();
            }
            Console.WriteLine("=======================================================");
            Console.WriteLine();
            for(int a = 0; a < Data.Length; a++)
            {
                Data[a].printKBJ();
            }
            Console.WriteLine("=======================================================");
        }
    }
}