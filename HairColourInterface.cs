using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLI.Data.Adult
{
    interface HairColourInterface
    {
        public String SelectHairColour(int index);
        public String RandomHairColour();
        public String[] GetHairColour();
    }
}
