using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLI.Data.Adult
{
    public class EyeColour:EyeColourInterface
    {
        String[] eyeColourf;
        public EyeColour()
        {
            String[] eyeColour = { "Black", "Brown","Grey","Green","Blue","Amber","Hazel" };
            this.eyeColourf = eyeColour;
        }
        public String SelectEyeColour(int index)
        {
            Console.WriteLine("eyecolour selected in class: " + eyeColourf[index]);
            return eyeColourf[index];
        }
        public String RandomEyeColour()
        {
            Random rnd = new Random();
            int index = rnd.Next(0, 6);
            Console.WriteLine("rnd in eyeColour: " + index);
            Console.WriteLine("eyeColour rnd get in class: " + eyeColourf[index]);
            return eyeColourf[index];

        }
        public String[] GetEyeColour()
        {
            return eyeColourf;
        }
    }
}
