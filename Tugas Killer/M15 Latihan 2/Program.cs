using System;
using System.IO;

namespace M15_Latihan_2
{
    class Program
    {
        static void Main(string[] args)
        {
            start :
            Console.WriteLine("");
            Console.WriteLine(">>>====================================================================<<<");
            Console.WriteLine("     *  *  *                                       *  *  *                ");
            Console.WriteLine("   *    * *  *           WELCOME TO              *  * * *  *              ");
            Console.WriteLine("  *   *  o  * *     SISTEM LOGIN SEDERHANA      *  *  O  *  *             ");
            Console.WriteLine("   *   *   *  *                                 *    *  *   *             ");
            Console.WriteLine("     *  *   *                                     *  *  *  *              ");
            Console.WriteLine(">>>====================================================================<<<");
            Console.WriteLine(" ");
            Console.WriteLine("Apakah Anda Sudah Punya Akun....?");
            Console.WriteLine("Jika Belum, silahkan ketik R untuk pergi ke Laman Registrasi terlebih dahulu");
            Console.WriteLine("Jika Sudah Memiliki Akun Silakan Enter Untuk Login Pada Akun Anda ");
            
            string input1 = Console.ReadLine();    
            if (input1 == "R")
            {
                registerUser();
            }
            Console.WriteLine(" ");
            loginUser();
            
            Console.WriteLine("Apakah anda masih ingin menggunakan SISTEM ini ??? ");
            Console.WriteLine("Jika ingin melanjutkan ketik ''iya'' ");
            Console.WriteLine("Jika ingin mengakhiri tekan ENTER");
            string input2 = Console.ReadLine();
            if (input2 == "iya")
            {
                goto start;
            }
            Console.WriteLine("================================================ ");
            Console.WriteLine("|| Terimakasih telah menggunakan layanan kami || ");
            Console.WriteLine("||          -By : Desi Maya Sari-            || ");
            Console.WriteLine("================================================ ");
            Console.WriteLine(" ");
            Console.WriteLine(">>>====================================================================<<<");
            Console.WriteLine("     *  *  *                                       *  *  *                ");
            Console.WriteLine("   *    * *  *           SEE YOU                *  * * *   *              ");
            Console.WriteLine("  *   *  o  * *         NEXT TIME              *   *  O  *  *             ");
            Console.WriteLine("   *   *   *  *                                 *    *  *   *             ");
            Console.WriteLine("     *  *   *                                     *  *  *  *              ");
            Console.WriteLine(">>>====================================================================<<<");

            
            
        }
        static void registerUser(){
            string userName;
            string userPassword;
            string lahir;
            string nim;
            string konsentrasi;

            regis:
            NAMA :
            //NAMA USER
            Console.WriteLine(" ");
            Console.WriteLine("Siapa Nama Anda ?");
            userName = Console.ReadLine();

            string userName2 = "Nama : "+userName+"\n";
            Console.WriteLine("Mohon konfirmasi Nama Anda (Tulis kembali Nama)");
            string nameUser = Console.ReadLine();
            if (nameUser != userName)
            {
                Console.WriteLine("MAAF,,, Nama anda tidak sama dengan Nama diawal ??? MOHON INPUT KEMBALI ");
                goto NAMA;
            }
            //CEK JIKA SUDAH ADA PENGGUNA DENGAN NAMA TSB
            if(File.Exists(nameUser+"data.txt"))
            {
                Console.WriteLine("MAAF,,,, Nama Pengguna Telah dipakai ");
                Console.WriteLine("Mohon gunakan ");
                goto regis;
            }
            //PASSWORD USER
            PASS :
            Console.WriteLine(" ");
            Console.WriteLine("Mohon buat password anda ");
            userPassword = Console.ReadLine();

            string userPassword2 = "Password : "+userPassword+"\n";  
            Console.WriteLine("Mohon konfirmasi password anda (Tulis kembali Password)");
            string passwordUser = Console.ReadLine();
            if (passwordUser != userPassword)
            {
                Console.WriteLine("MAAF,,, Password Anda tidak sama dengan Password diawal ??? MOHON INPUT KEMBALI ");
                goto PASS;
            }else if(passwordUser == nameUser){
                Console.WriteLine("PEMBERITAHUAN, Jangan samakan Password dengan user anda ");
                goto PASS;
            }

            //LAHIR SI USER
            Console.WriteLine(" ");
            Console.WriteLine("Tahun Berapa Anda Lahir ?");
            lahir = "TL : "+Console.ReadLine()+"\n";

            //NIM USER
            Console.WriteLine(" ");
            Console.WriteLine("Masukkan NIM Anda");
            nim = "NIM : "+Console.ReadLine()+"\n";

            //KONSENTRASI USER
            Console.WriteLine(" ");
            Console.WriteLine("Konsentrasi Jurusan Anda ?");
            konsentrasi = "Konsentrasi : "+Console.ReadLine()+"\n";

            File.WriteAllText(nameUser+"data.txt",userName2);
            File.AppendAllText(nameUser+"data.txt",userPassword2);
            File.AppendAllText(nameUser+"data.txt",lahir);
            File.AppendAllText(nameUser+"data.txt",nim);
            File.AppendAllText(nameUser+"data.txt",konsentrasi);
        }
        static void loginUser(){
            login:
            Console.WriteLine(" ");
            Console.WriteLine("Username : ");
            string userName = Console.ReadLine();

            Console.WriteLine(" ");
            Console.WriteLine("Password : ");
            string userPassword = Console.ReadLine();
            string nameUser = userName;

            string userData = File.ReadAllText(nameUser+"data.txt");
            
            if(userName == userPassword || userPassword == "" || userName == "")
            {
                Console.WriteLine("MAAF,,, Password  dan Username Anda tidak Sesuai ");
            }else if (userData.Contains(userPassword) && userData.Contains(userName))
            {
                Console.WriteLine(" ");
                Console.WriteLine("SELAMAT ANDA BERHASIL LOGIN !");
                Console.WriteLine("Selamat datang "+userName+" !");
                Console.WriteLine(" ");
                Console.WriteLine(userData);
            }else{
                Console.WriteLine("MAAF,,, Password  dan Username Anda tidak Sesuai ");
                goto login;
            }
        }
               
    }
}
