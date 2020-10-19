using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLI.Data.Adult
{
    public class HairColor : HairColourInterface
    {
        String[] Haircolourf = new string[9];
        public HairColor()
        {
            String[] HairColour = { "Blond", "Red", "Brown", "Black", "White", "Grey", "Blue","Green","Leverpostej" };
            this.Haircolourf = HairColour;
        }
        public string[] GetHairColour()
        {
            return Haircolourf;
        } 

        public string RandomHairColour()
        {
            Random rnd = new Random();
            int index = rnd.Next(0, 9);
            Console.WriteLine("rnd in Haircolour: " + index);
            Console.WriteLine("Haircolour rnd get in class: " + Haircolourf[index]);
            return Haircolourf[index];
        }

        public string SelectHairColour(int index)
        {
            Console.WriteLine("Haircolour selected in class: " + Haircolourf[index]);
            return Haircolourf[index];
        }
    }
}
