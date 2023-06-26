using System;

namespace Jumt_Statement_DESIMAYASARI_Nim2102110665
{
    class Program
    {
        public static string[,] user = {{"Ery Safrianti,St.,MT.", "197402242000032000TE"},
            {"Noveri Iysberry M,ST., M.Sc", "197311271999032000TI"},
            {"Suwitno, ST., MT.", "196611021999031000TE"},
            {"Dr. Azriyenni, ST., M.Eng", "197304011999032000TE"},
            {"Budhi Anto, ST., MT.", "197208132000121000TE"},
            {"Feranita, ST., MT", "197302012005012000TE"},
            {"Linna Oktaviana Sari, ST., MT.", "197910152006042000TI"},
            {"Dr. Indra Yasri, ST., MT.", "197403072002121000TE"},
            {"Dr. Yusnita Rahayu,ST., M.Eng", "197511042005012000TE"},
            {"Dr. Fri Murdiya, MT.", "198002052003121000TE"},
            {"Dr. Iswadi HR, ST., MT.", "197807152003121000TE"},
            {"Dr. Feri Candra, MT.", "197404282002121000TI"},
            {"Dr. Dahliyusmanto, S.Kom., M.Sc", "197204222006041000TI"},
            {"Dr. Anhar, ST., MT", "197604092002121000TE"},
            {"Dr. Ir. Antonius Rajagukguk, MT", "196607311997021000TE"},
            {"Nurhalim, ST., MT", "197408202002121000TE"},
            {"Dian Yayan Sukma, ST., MT", "197803082003121000TE"},
            {"Eddy Hamdani, ST., MT", "196709081999031000TE"},
            {"Rahyul Amri, ST., MT", "196707231999031000TI"},
            {"Amir Hamzah, ST., MT", "197507052002121000TE"},
            {"Ir. Edy Ervianto, MT", "196412151997021000TE"},
            {"Firdaus, ST., MT", "197705102005011000TE"},
            {"Salhazan Nasution, MIT", "198611112009121000TI"},
            {"Dr. Dewi Nasien, M.Sc", null},
            {"Rahmat Rizal Andhi, ST., MT", "198312032019031000TI"},
            {"Irsan Taufik Ali, ST., MT", "198005102005011000TI"},
            {"Dr. Febrizal, ST., MT", "197802222002121000TE"},
            {"Edi Susilo, S.Pd., M.Kom., M.Eng", "199110292019031000TI"},
            {"T. Yudi Handiwandra, M.Kom", "197207122000121000TI"},
            {"Dian Ramadhani, ST., MT", "198805052020122000TI"}

        };

        static void Main(string[] args)
        {

            Console.WriteLine("Selamat datang pada sistem pendataan Dosen UNRI");
            Console.WriteLine("Pilih bagaimana kamu ingin melihat data-data Dosen di UNRI :");
            Console.WriteLine("1. Urut secara biasa");
            Console.WriteLine("2. Urut berdasarkan dosen yang Berumur dibawah 45 tahun");
            Console.WriteLine("3. Urut berdasarkan dosen-dosen yang mengajar di Prodi TEKNIK INFORMATIKA");
            Console.WriteLine("");

            string userInput = Console.ReadLine();
            switch(userInput)
            {
                case "1":
                dataDosen();
                break;
                case "2":
                dataDosenDiatas45();
                break;
                case "3":
                dataDosenPengajarTI();
                break;
            }

            Console.WriteLine("Goodbye");
            Console.ReadLine();
        }
        static void dataDosen()
        {
            for(int i = 0; i < user.Length/2; i++)
            {
                string tahunLahir = user[i, 1].Substring(0,4);
                int hasilAkhir = Convert.ToInt32(tahunLahir);


                int age = 2021 - hasilAkhir;
                if(age > 1000)
                {
                 string umur = Convert.ToString(age);
                    umur = "Data Tidak Ditemukan";
                    user[i,1] = "Data Tidak Ditemukan";
                    tahunLahir = "Data Tidak Ditemukan";
                    Console.WriteLine("");
                    Console.WriteLine("Nama : " + user[i,0]);
                    Console.WriteLine("NIP : " + user[i,1]);
                    Console.WriteLine("Tahun Lahir : " + tahunLahir);
                    Console.WriteLine("Umur : " + umur);
                    Console.WriteLine("");
                 continue;
                }
                else
                {
                Console.WriteLine("");
                Console.WriteLine("Nama : " + user[i,0]);
                Console.WriteLine("NIP : " + user[i,1].Substring(0,18));
                Console.WriteLine("Tahun Lahir : " + tahunLahir);
                Console.WriteLine("Umur : " + age);
                Console.WriteLine("");
                }
            }
        }
        static void dataDosenDiatas45()
        {
            for(int i = 0; i < user.Length/2; i++)
            {
                if(user[i,1]==null)
                {
                    continue;
                }
                string tahunLahir = user[i,1].Substring(0,4);
                int hasilAkhir = Convert.ToInt32(tahunLahir);

                int age = 2021 - hasilAkhir;

                  if(2021 - hasilAkhir > 45)
                  {
                   continue;
                  }

            
               Console.WriteLine("");
               Console.WriteLine("Nama : " + user[i,0]);
               Console.WriteLine("NIP : " + user[i,1].Substring(0,18));
               Console.WriteLine("Tahun Lahir : " + tahunLahir);
               Console.WriteLine("Umur : " + age);
               Console.WriteLine("");


            }
        }
        static void dataDosenPengajarTI()
        {
            for(int i = 0; i < user.Length/2; i++)
            {
                if(user[i,1]==null)
                {
                    continue;
                }
                string tahunLahir = user[i,1].Substring(0,4);
                int hasilAkhir = Convert.ToInt32(tahunLahir);

                string pengajarTI = user[i,1].Substring(18,2);
                int age = 2021 - hasilAkhir;

                if(pengajarTI == "TE")
                {
                    continue;
                }


                Console.WriteLine("");
                Console.WriteLine("Nama : " + user[i,0]);
                Console.WriteLine("NIP : " + user[i,1].Substring(0,18));
                Console.WriteLine("Tahun Lahir : " + tahunLahir);
                Console.WriteLine("Umur : " + age);
                Console.WriteLine("");
            }
        }
    }
}
