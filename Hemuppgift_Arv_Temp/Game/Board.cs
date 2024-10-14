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
        public int NoPins { get; set; }

        //Metoder
        public void SetUp(int PinnarAntal)//Skriver ut hur många pinnar spelet börjar med
        {
            NoPins = PinnarAntal;
            Console.WriteLine($"Det finns {PinnarAntal} pinnar på bordet.");
        }

        public bool takePins(int PinnarTagna)//valde en bool så spelet ska rulla
        {
            if (PinnarTagna < 1 || PinnarTagna > 2)
            {
                Console.WriteLine("Du kan bara välja 1 eller 2 pinnar i taget.");
                return false;//man kan bara välja max 2 pinnar
            }            
            else if(PinnarTagna > NoPins)
            {
                Console.WriteLine("Det finns inte så många pinnar kvar.");
                return false;//om man väljer fler än vad som finns kvar
            }
            else
            {
                NoPins -= PinnarTagna;//Räknar bort pinnar som datorn eller spelaren väljer
                return true;
            }
        }

        public void GetNoPins()//hur många pinnar som finns kvar i spelet
        {
            Console.WriteLine($"Det finns {NoPins} kvar.");
        }


    }
}
