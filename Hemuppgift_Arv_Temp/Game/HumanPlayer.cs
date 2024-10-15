using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    internal class HumanPlayer : Player//ärver från Player-Klassen
    {
        //Egenskap
        public string player { get; set; }

        //Konstruktor
        public HumanPlayer(string UserId) : base(UserId) //hämtar userid från basklassen 
        { 
            this.UserId = UserId;
        }


        //Metoder
        public override string GetUserId()//returnar ett användarman på spelaren
        {
            return UserId;
        }

        public override int TakePins(Board board)//Hur spelaren kan mata in siffror
        {
            Console.WriteLine($"Hur många pinnar vill du ta {UserId}?");
            int PinnarUser = Convert.ToInt32(Console.ReadLine());

            while (PinnarUser < 1 || PinnarUser > 2 || PinnarUser > board.NoPins)
            //får inte vara mindre än 1, större än 2 eller fler pinnar än vad som finns kvar.
            {
                Console.WriteLine("Du kan bara välja 1 eller 2 pinnar.");//felmeddelande
                PinnarUser = Convert.ToInt32(Console.ReadLine());//så spelaren kan mata in en ny siffra
            }
            return PinnarUser;
        }

    }
}
