using System;
class HelloWorld
{
    static void Main()
    {

        int temp;
        int getHuruf;
        Console.Write("Teks : ");
        string kata = Console.ReadLine();
        string kataBaru = "";
    
        for (int i = 0; i < kata.Length; i++) 
        {      
            temp = -1;
            getHuruf = -2;
            if(Char.IsLetter(kata[i]))
            {
                for (char huruf = 'a'; huruf <= 'z'; huruf++)
                {
                    if(huruf == kata[i])
                    {
                        getHuruf = temp + 3;
                    }
               
                    if(getHuruf == temp)
                    {
                        kataBaru = kataBaru + Char.ToString(huruf);
                    }              
                    temp++;
                } 
            }
            else 
            {
                kataBaru += " ";
            }       
        }  
        Console.WriteLine("Hasil Enskripsi : " +kataBaru);
    }
}

