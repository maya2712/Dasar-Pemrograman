using System;

namespace M14_Latihan_3_DESIMAYASARI
{
    class Program
    {
    
        static void Main(string[] args)
        {
            string kata1 = "Informatika";
			string kata2 = "Informasi";
			//Pengunaan String Compare
			int status = string.Compare(kata1, kata2);
			if(status == 0)
			{
				Console.WriteLine("Semua Huruf Diantara Kedua Kata Tersebut Sama ");
			}
			else
			{
				char[] char1 = kata1.ToCharArray();
				char[] char2 = kata2.ToCharArray();
				
				string hurufBeda1 = "";
				string hurufBeda2 = "";
				int totalSama = 0;
				int i = 0 ;
				while(true){
					try{
						if(char1[i] == char2[i]){
							totalSama++;
						}
						else{
							hurufBeda1 += char1[i];
							hurufBeda2 += char2[i];
						}
					}catch(Exception )
					{
						break;
					}
					i++;
				}
				for(int j=i; j<kata1.Length;j++){
					hurufBeda1 += char1[j];	
				}
				Console.WriteLine(char1[1]);
				Console.WriteLine("Total huruf sama : "  + totalSama);
				Console.WriteLine("huruf yang berbeda dari kata pertama dengan kedua : ");
				Console.WriteLine("huruf dari kata pertama :  " + hurufBeda1);
				Console.WriteLine("huruf dari kata kedua :  " + hurufBeda2);
			}
        }
    }
}