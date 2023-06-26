using System;

namespace Modul_14_Latihan_1_DESIMAYASARI
{
    class Mahasiswa
    {
     Mahasiswa(string Nama, int NIM , string Konsentrasi, double ipk, bool Lulus ) {

        Console.WriteLine("Nama : " + Nama);
        Console.WriteLine("Nim : " + NIM);
        Console.WriteLine("Konsentrasi : " + Konsentrasi);
        Console.WriteLine("ipk : " + ipk);
        if(Lulus)
        {
            Console.WriteLine("Telah Lulus");
        }
        else
        {
            Console.WriteLine("Belum Lulus");
        }
     
    }
        static void Main(string[] args) {
            Console.WriteLine();
            Mahasiswa mhs = new Mahasiswa("Desi Maya Sari", 2107110665, "RPL", 3.4, true);
            Console.WriteLine();
            Mahasiswa mhs1 = new Mahasiswa("Bukan Desi Maya Sari", 21071, "kcv", 3.4, false);
            Console.WriteLine();
            Mahasiswa mhs2 = new Mahasiswa("Bukan Desi Maya Sari", 2107110665, "kbj", 3.7, true);
            Console.WriteLine();
        }

    }
}