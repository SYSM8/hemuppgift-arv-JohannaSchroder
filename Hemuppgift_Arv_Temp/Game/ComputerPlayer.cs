using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    internal class ComputerPlayer : Player//ärver från Player
    {
       Random random = new Random();
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


        //efter datorn valt vill jag att det ska finnas 4st pinnar kvar.
        //då spelar det ingen roll om Player tar 1 eller 2 pinnar för datorn vinner oavsett.
        //här har jag försökt att datorn ska dela med 4 och att det ska bli lika med noll
        //för att den ska fatta att det ska vara 4 kvar till motståndaren.
        public override int TakePins(Board board)
        {
            int PinnarDator;
            if ((board.NoPins % 4) == 0)
            {
                PinnarDator = random.Next(1, 3);//slumpar 1-2 pinnar och deklarerar det i en variabel
            }
            else
            {
                PinnarDator = board.NoPins % 2;
                PinnarDator = random.Next(1, 3);
            }
            
            Console.WriteLine($"{UserId} har tagit {PinnarDator}st pinnar");//visar hur många pinnar datorn tagit

            return PinnarDator;
        }

    }
}
