using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    internal class ComputerPlayer : Player//ärver från Player
    {
        public Random random;//skapar ett random
       
        //konstruktor
        public ComputerPlayer(string UserId) : base(UserId)
        {
            random = new Random();//skapar ett nytt random för att slumpa pinnar
        }

        //metoder
        public override string GetUserId()//returnerar ett namn på datorn
        {
            return UserId;
        }

        public override int TakePins(Board board)
        {
            int PinnarDator = random.Next(1, 3);//slumpar 1-2 pinnar och deklarerar det i en variabel
            Console.WriteLine($"{UserId} har tagit {PinnarDator}st pinnar");//visar hur många pinnar datorn tagit

            return PinnarDator;
        }

    }
}
