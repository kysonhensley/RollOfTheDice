namespace RollOfTheDice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create Random Object
            Random random = new Random();
            int[] results = new int[11];
            for (int i = 0; i < 1000; i++)
            {
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                int sum = dice1 + dice2;

                switch (sum)
                {
                    case 2: results[0]++; break;
                    case 3: results[1]++; break;
                    case 4: results[2]++; break;
                    case 5: results[3]++; break;
                    case 6: results[4]++; break;
                    case 7: results[5]++; break;
                    case 8: results[6]++; break;
                    case 9: results[7]++; break;
                    case 10: results[8]++; break;
                    case 11: results[9]++; break;
                    case 12: results[10]++; break;
                }
            }
            Display(results); //test display method



            //pause
            Console.Read();
        }

        static void Display(int[] results)
        {
            string currentLocation = "X";
            string[] header = { "Roll Of The Dice" };
            string[] possibleOutcomes = { " 2 ", "3 ", "4 ", "5 ", "6 ", "7 ", "8 ", "9 ", "10 ", "11 ", "12" };
            foreach (string letter in possibleOutcomes)
            {
                Console.Write(letter + " | ");
            }
            Console.WriteLine();
            //add 50 "-" to console
            Console.WriteLine(new string('-', 55));


            // Display user interface

            for (int i = 0; i < 11; i++)
            {
                Console.Write(results[i].ToString().PadLeft(3) + " | ");
            }
            Console.WriteLine();

        }

    }
}
