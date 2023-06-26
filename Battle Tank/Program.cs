using System;

namespace BattleTank_DesiMayaSari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarasi dan inisialisasi variabel
            int dessertLength = 5;
            char tank = 't';
            char sand = '~';
            char hit = 'X';
            char miss = '0';
            int tankTotal = 3;

            //Buat Array 2D untuk penempatan tank
            char[,] dessert = createDessert(dessertLength, sand, tank, tankTotal);

            //Print Array 2D ke console
            printDessert(dessert, sand, tank);

            //Jumlah tank yang tersembunyi
            int unknownTankDetected = tankTotal;

            //game play
            while (unknownTankDetected > 0) {
                int[] guessCoordinates =getUserCoordinate(dessertLength);
                char locationViewUpdate = verifyGuessAndTarget(guessCoordinates, dessert, tank, sand, hit, miss);
                if (locationViewUpdate == hit) {
                    unknownTankDetected--;
                }
                dessert = updateDessert(dessert, guessCoordinates, locationViewUpdate);
                printDessert(dessert, sand, tank);
            }

            Console.WriteLine("Game over, Goodbye...");
            Console.WriteLine("see you....");
        }

        //Print Array2D ke layar console 
        private static void printDessert(char[,] dessert, char sand, char tank){
            Console.Write(" ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + 1 + " ");
            }
            Console.WriteLine();

            for (int row = 0; row < 5; row++)
            {
                Console.Write(row + 1 + " ");
                for (int  column = 0; column < 5; column++)
                {
                    char position = dessert[row,column];
                    if(position == tank) {
                        Console.Write(sand + " ");
                    }else{
                        Console.Write(position + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        //Cek validasi Tebakan User (miss/kena/sudah hancur)
        private static char verifyGuessAndTarget(int[] guessCoordinates, char[,] dessert, char tank, char sand, char hit, char miss){
            string message;
            int row = guessCoordinates[0];
            int column = guessCoordinates[1];
            char target = dessert[row, column];

            if (target == tank){
                message = "TANK DOWN!!!";
                target = hit;
            }else if (target == sand){
                message =  "YOU MISSED!!!";
                target = miss;
            }else{
                message = "THIS AREA IS CLEAR!!!";
            }

            Console.WriteLine(message);
            return target;
        }

        //Update tampilan Array2D berdasarkan hasil tebakan user 
        private static char[,] updateDessert(char[,] dessert, int[] guessCoordinates, char locationViewUpdate){
            int row = guessCoordinates[0];
            int column = guessCoordinates[1];
            dessert[row, column] = locationViewUpdate;
            return dessert;
        }

        //Tebakan User (UserInput)
        private static int[] getUserCoordinate(int dessertLength){
            int row;
            int column;

            do{
                Console.Write("Select Row : ");
                row = Convert.ToInt32(Console.ReadLine());
            }while(row < 0 || row > dessertLength + 1);

            do{
                Console.Write("Select Coumn : ");
                column = Convert.ToInt32(Console.ReadLine());
            }while(column < 0 || column > dessertLength + 1);

            return new[]{row - 1, column - 1};
        }

        //Buat Array2D
        private static char[,] createDessert(int dessertLength, char sand, char tank, int tankTotal){
            char[,] dessert = new char[dessertLength, dessertLength];
            for (int row = 0; row < dessertLength; row++)
            {
                for (int coloumn = 0; coloumn < dessertLength; coloumn++)
                {
                    dessert[row,coloumn] = sand;
                }
            }
            return placeTank(dessert, tankTotal, sand, tank);
        }

        //Meletakkan 3 buah Tank didalam Array2D
        private static char[,] placeTank(char[,] dessert, int tankTotal, char sand, char tank){
            int placedTanks = 0;
            int dessertLength = 5;

            while(placedTanks < tankTotal){
                int[] tankLocation = generateTankcoordinate(dessertLength);
                char positionOk = dessert[tankLocation[0], tankLocation[1]];

                if(positionOk == sand){
                    dessert[tankLocation[0], tankLocation[1]] = tank;
                    placedTanks++;
                }
            }
            return dessert;
        }

        //Generate Random Position di dalam Array 2D
        private static int[] generateTankcoordinate(int dessertLength){
           Random rnd = new Random() ;
           int[] coordinates = new int[2];
           for(int i = 0; i < coordinates.Length; i++){
               coordinates[i] = rnd.Next(dessertLength);
           }
           return coordinates;
        }
    }
}