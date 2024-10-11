using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    abstract class Player
    {
        //Egenskap
        public abstract int NoPins { get; set; }


        //Metoder
        public abstract string player();

        public abstract string GetUserId();

        public abstract string TakePins();

    }
}
