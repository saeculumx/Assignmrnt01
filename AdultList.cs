
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLI.Data.Adult
{
    public class AdultList
    {
        public List<Adult> Adults;
        public List<String> Firstnames;
        public List<String> LastNames;
        public List<String> HairColours;
        public List<String> EyeColours;
        public List<int> IDs;
        public List<String> Jobs;
        public AdultList()
        {
            Adults = new List<Adult>();
            Firstnames = new List<string>();
            LastNames = new List<string>();
            HairColours = new List<string>();
            EyeColours = new List<string>();
            Jobs = new List<string>();
            IDs = new List<int>();

        }
         public void AddAdult(Adult adult)
        {
            int ii = Adults.Count + 1;
            adult.Id = ii;
            Adults.Add(adult);
            Firstnames.Add(adult.FirstName);
            LastNames.Add(adult.LastName);
            HairColours.Add(adult.HairColor);
            EyeColours.Add(adult.EyeColor);
            IDs.Add(adult.Id);
            Jobs.Add(adult.Job);
        }
        public String getFirstName(int index)
        {
            return Adults[index].FirstName;
        }
        public String getLastName(int index)
        {
            return Adults[index].LastName;
        }
        public int getId(int index)
        {
            return Adults[index].Id;
        }
        public String getHairColour(int index)
        {
            return Adults[index].HairColor;
        }
        public String getEyeColour(int index)
        {
            return Adults[index].EyeColor;
        }
        public String getJob(int index)
        {
            return Adults[index].Job;
        }
        public Adult getAdult(int index)
        {
            return Adults[index];
        }
        public List<Adult> getAdultListByName(String name)
        {
            List<Adult> lista = new List<Adult>();
            for (int i = 0; i < Adults.Count; i++)
            {
                if (name.Equals(Adults[i].FirstName) || name.Equals(Adults[i].LastName))
                {
                    lista.Add(Adults[i]);
                }
            }
            return lista;
        }
        public List<Adult> getList()
        {
            return Adults;
                }
        public int getSize()
        {
            return Adults.Count;
        }
    }
}
