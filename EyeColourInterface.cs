using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLI.Data.Adult
{
    interface EyeColourInterface
    {
        public String SelectEyeColour(int index);
        public String RandomEyeColour();
        public String[] GetEyeColour();
    }
}
