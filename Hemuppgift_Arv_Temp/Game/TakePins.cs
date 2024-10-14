using System.Security.Cryptography;

namespace Hemuppgift_Arv_Temp.Game
{
    internal class TakePins
    {
        //Här är main klassen där koden ska testas, lägg in i mappen
        static void Main(string[] args)
        {


            Board board = new Board();//hämtar Board-klassen 
            board.SetUp(10);//Väljer antal pinnar till spelet

            Console.WriteLine("Välkommen till ett mycket enkelt spel!");
            Console.WriteLine($"Du får ta 1-2pinnar");
            Console.WriteLine("Den som tar den sista pinnen förlorar. Lycka till!");

            while (board.NoPins >= 1)
            {
                bool InteOkejInmatning = false;

                while (!InteOkejInmatning)
                {
                    Console.WriteLine("Hur många pinnar vill du ta?");
                    int PinnarUser = Convert.ToInt32(Console.ReadLine());
                    InteOkejInmatning = board.takePins(PinnarUser);
                }

                board.GetNoPins();

                if(board.NoPins < 1)
                { 
                    Console.WriteLine("Spelet är slut! Du förlorade!");
                    break;
                }

                Random random = new Random();
                int PinnarDator = random.Next(1, 3);//för att slumpa tal mellan 1-2

                Console.WriteLine($"Datorn har tagit {PinnarDator} antal pinnar.");
                board.takePins(PinnarDator);
                board.GetNoPins();

                if (board.NoPins < 1)
                {
                    Console.WriteLine("Spelet är slut! Datorn förlorade!");
                    break;
                }

            }



        }

    }
}
