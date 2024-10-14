using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hemuppgift_Arv_Temp.Game
{
    internal class Board
    {
        //Egenskap
        public int NoPins { get; private set; }

        //Metoder
        public void SetUp(int PinnarAntal)
        {
            NoPins = PinnarAntal;
            Console.WriteLine($"Det finns {PinnarAntal} på bordet.");
        }

        public bool takePins(int PinnarTagna)//valde en bool
        {
            if (PinnarTagna < 1 || PinnarTagna > 2)
            {
                Console.WriteLine("Du kan bara välja 1 eller 2 pinnar i taget.");
                return false;
            }            
            else if(PinnarTagna > NoPins)
            {
                Console.WriteLine("Det finns inte så många pinnar kvar.");
                return false;
            }
            else
            {
                NoPins -= PinnarTagna;
                return true;
            }
        }

        public void GetNoPins()
        {
            Console.WriteLine($"Det finns {NoPins} kvar.");
        }


    }
}
