using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    internal abstract class Player
    {
        //Egenskap
        public string UserId { get; set; }

        //Konstruktor
        public Player(string UserId)
        {
            this.UserId = UserId;
        }

        //Metoder
        public abstract int TakePins(Board board);

        public abstract string GetUserId();



    }
}
