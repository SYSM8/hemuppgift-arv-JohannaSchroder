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

            //Ett litet välkomstmeddelande
            Console.WriteLine("Välkommen till ett mycket enkelt spel!");
            Console.WriteLine($"Du får ta 1-2pinnar");
            Console.WriteLine("Den som tar den sista pinnen förlorar. Lycka till!");

            //så spelet fortsätter tills kravet uppfylls om 1 eller färre pinnar är kvar på bordet
            while (board.NoPins >= 1)
            {
                bool InteOkejInmatning = false;//Kollar så inmatning blir rätt

                while (!InteOkejInmatning)//så loopen fortsätter tills rätt inmatning gjorts
                {
                    Console.WriteLine("Hur många pinnar vill du ta?");
                    int PinnarUser = Convert.ToInt32(Console.ReadLine());
                    InteOkejInmatning = board.takePins(PinnarUser);
                    //kontrollerar med takepins metoden så rätt antal pinnar tas och spelet går vidare.
                }

                board.GetNoPins();//Hur många pinnar som finns kvar

                if(board.NoPins < 1)
                { 
                    Console.WriteLine("Spelet är slut! Datorn vinner!");
                    break;
                    //Datorn vinner
                }

                Random random = new Random();
                int PinnarDator = random.Next(1, 3);//för att slumpa tal mellan 1-2

                Console.WriteLine($"Datorn har tagit {PinnarDator} antal pinnar.");//datorn tar pinnar
                board.takePins(PinnarDator);
                board.GetNoPins();//hur många pinnar som finns kvar

                if (board.NoPins < 1)
                {
                    Console.WriteLine("Spelet är slut! Du vinner!");
                    break;
                    //spelaren vinner
                }

            }



        }

    }
}
