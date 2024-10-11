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

        //Konstruktor
        public Board(int NoPins) 
        {
            this.NoPins = NoPins;
        }

        //Metoder
        public void SetUp()
        {
            Console.WriteLine("Välkommen till ett mycket enkelt spel!");
            Console.WriteLine($"Det finns {NoPins} på bordet, du får ta 1-2pinnar");
            Console.WriteLine("Den som tar den sista pinnen förlorar. Lycka till!");
        }

        public void takePins(int tagnaPinnar)
        {
            Console.WriteLine("Hur många pinnar vill du ta?");
            tagnaPinnar = Convert.ToInt32(Console.ReadLine());

            if (tagnaPinnar <= 3 && tagnaPinnar > 0)
            {
                NoPins -= tagnaPinnar;
                Console.WriteLine($"Du har tagit bort {tagnaPinnar}");
                Console.WriteLine($"Det finns nu {NoPins} kvar på bordet");
            }
            else 
            {
                Console.WriteLine("Du kan bara ta bort 1-2 pinnar i taget");
            }
        }
        
        /*public int GetNoPins()
        { 
        
        }*/


    }
}
