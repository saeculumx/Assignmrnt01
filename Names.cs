using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLI.Data.Adult
{
    public class Names
    {
        private List<String> FirstNameString;
        private List<String> LastNameString;
        public Names()
        {
            FirstNameString = new List<string>();
            LastNameString = new List<string>();
            FirstNameString.Add("Tom");
            LastNameString.Add("nobody");
            FirstNameString.Add("jack");
            LastNameString.Add("anyone");
            FirstNameString.Add("white");
            LastNameString.Add("someone");
            FirstNameString.Add("isaac");
            LastNameString.Add("thisone");
            FirstNameString.Add("feier");
            LastNameString.Add("askert");
            FirstNameString.Add("doggy");
            LastNameString.Add("ohmy");
            FirstNameString.Add("plole");
            LastNameString.Add("ugius");
            FirstNameString.Add("oion");
            FirstNameString.Add("wither");
            FirstNameString.Add("north");
            LastNameString.Add("biberia");
            FirstNameString.Add("werany");
            FirstNameString.Add("enty");
            LastNameString.Add("hang");
            FirstNameString.Add("ramdon");
            LastNameString.Add("whatever");
            FirstNameString.Add("yang");
            FirstNameString.Add("sharped");
            FirstNameString.Add("youmei");
            FirstNameString.Add("joel");
            FirstNameString.Add("yune");
            FirstNameString.Add("viv");
            LastNameString.Add("lana");
            FirstNameString.Add("mute");
            FirstNameString.Add("alex");
            LastNameString.Add("jack");
            FirstNameString.Add("andy");
            LastNameString.Add("tomy");
            FirstNameString.Add("cheese");
            LastNameString.Add("sweet");
            FirstNameString.Add("rillu");
            LastNameString.Add("lienu");
            FirstNameString.Add("halo");
            LastNameString.Add("gears");
            FirstNameString.Add("nowhere");
            FirstNameString.Add("breis");
            LastNameString.Add("james");
            FirstNameString.Add("hastobe");
            LastNameString.Add("shiery");
            FirstNameString.Add("hitio");
            LastNameString.Add("errar");
            LastNameString.Add("black");
            LastNameString.Add("frost");
            LastNameString.Add("buck");
            LastNameString.Add("meiluci");
            LastNameString.Add("oliv");
            LastNameString.Add("ujiu");
            LastNameString.Add("este");
            LastNameString.Add("yher");
            LastNameString.Add("play");
            FirstNameString.Add("sctrn");
            FirstNameString.Add("exanina");
            FirstNameString.Add("ezio");
            FirstNameString.Add("yoha");
        }

        public String ramdonFNames()
        {
            Random rmd = new Random();
            int i = rmd.Next(0, FirstNameString.Count);
            return FirstNameString[i];
        }
        public String ramdonLNames()
        {
            Random rmd = new Random();
            int i = rmd.Next(0, LastNameString.Count);
            return LastNameString[i];
        }
    }
}
