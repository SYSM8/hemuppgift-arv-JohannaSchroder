using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    internal class ComputerPlayer : Player//ärver från Player
    {
       
        //konstruktor
        public ComputerPlayer(string UserId) : base(UserId)
        {
            this.UserId = UserId;
        }

        //metoder
        public override string GetUserId()//returnerar ett namn på datorn
        {
            return UserId;
        }

        //när det är datorns tur vill jag att det ska finnas 4st pinnar kvar.
        //då kan spelar det ingen roll om Player tar 1 eller 2 pinnar för datorn vinner oavsett.
        public override int TakePins(Board board)
        {
            int PinnarDator;
            if ((board.NoPins % 4) == 0)
            {
                PinnarDator = new Random().Next(1, 3);//slumpar 1-2 pinnar och deklarerar det i en variabel
            }
            else
            {
                PinnarDator = board.NoPins % 4;
            }
            
            Console.WriteLine($"{UserId} har tagit {PinnarDator}st pinnar");//visar hur många pinnar datorn tagit

            return PinnarDator;
        }

    }
}
