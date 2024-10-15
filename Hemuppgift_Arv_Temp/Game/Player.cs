using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    internal abstract class Player//en abstract klass som visar vad som måste finnas i klasserna HP och CP
    {
        //Egenskap
        public string UserId { get; set; }

        //Konstruktor
        public Player(string UserId)
        {
            this.UserId = UserId;
        }

        //Metoder
        public abstract int TakePins(Board board);//Tar info från Board-klassen

        public abstract string GetUserId();



    }
}
