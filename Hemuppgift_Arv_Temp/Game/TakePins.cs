using System.Security.Cryptography;

namespace Hemuppgift_Arv_Temp.Game
{
    internal class TakePins
    {
        //Här är main klassen där koden ska testas, lägg in i mappen
        static void Main(string[] args)
        {

            Board board = new Board();//hämtar Board-klassen 

            ComputerPlayer computerPlayer = new ComputerPlayer("Allan");//här kan man byta namn på datorn

            //Ett litet välkomstmeddelande
            Console.WriteLine($"Välkommen till ett mycket enkelt spel!");
            Console.WriteLine($"Du kommer få spela mot {computerPlayer.GetUserId()}. Vad heter du?");
            string PlayerName = Console.ReadLine();//spelaren kan mata in sitt namn.
            HumanPlayer humanPlayer = new HumanPlayer(PlayerName);//Lägger in det valda namnet

            Console.WriteLine();//Lite mellanrum

            Console.WriteLine($"Hej {PlayerName}!");
            board.SetUp(11);//Väljer antal pinnar till spelet
            Console.WriteLine("Du får ta 1 eller 2 pinnar.");//förklarar spelets regler
            Console.WriteLine("Den som tar den sista pinnen förlorar. Lycka till!");

            Console.WriteLine();//Lite mellanrum

            //så spelet fortsätter tills kravet uppfylls om 1 eller färre pinnar är kvar på bordet
            while (board.NoPins >= 1)
            {
                int PinnarPlayer = humanPlayer.TakePins(board);
                board.takePins(PinnarPlayer);//tar bort spelarens pinnar

                board.GetNoPins();//Hur många pinnar som är kvar

                if (board.NoPins < 1)//om spelaren tar sista pinnen
                {
                    Console.WriteLine("Spelet är slut! Du förlorade!");
                    break;
                }

                Console.WriteLine();//Lite mellanrum

                int PinnarComputer = computerPlayer.TakePins(board);
                board.takePins(PinnarComputer);//tar bort datorns pinnar

                board.GetNoPins();//Hur många pinnar som är kvar

                if (board.NoPins <= 1)//om datorn tar sista pinnen
                {
                    Console.WriteLine("Spelet är slut! Du vann!");
                    break;
                }

                Console.WriteLine();//Lite mellanrum
            }



        }

    }
}
