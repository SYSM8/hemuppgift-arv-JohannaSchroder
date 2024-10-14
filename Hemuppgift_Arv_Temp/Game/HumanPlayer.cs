using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    internal class HumanPlayer : Player
    {
        public string player { get; set; }
        public HumanPlayer(string UserId) : base(UserId) 
        { 
            this.UserId = UserId;
        }

        public override string GetUserId()
        {
            return UserId;
        }

        public override int TakePins(Board board)
        {
            Console.WriteLine($"Hur många pinnar vill du ta {UserId}?");
            int PinnarUser = Convert.ToInt32(Console.ReadLine());

            while (PinnarUser < 1 || PinnarUser > 2 || PinnarUser > board.NoPins)
            {
                Console.WriteLine("Du kan bara välja 1 eller 2 pinnar.");
                PinnarUser = Convert.ToInt32(Console.ReadLine());
            }
            return PinnarUser;
        }

    }
}
