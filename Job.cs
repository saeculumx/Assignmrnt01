using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLI.Data.Adult
{
   public class Job
    {
        String[] JobList = new string[26];
        public Job()
        {
            JobList[0] = "hello?";
            JobList[1] = "Teacher";
            JobList[2] = "Engineer";
            JobList[3] = "Garbage Collector";
            JobList[4] = "Shepherd";
            JobList[5] = "Pilot";
            JobList[6] = "Police Officer";
            JobList[7] = "Pirate";
            JobList[8] = "Fireman";
            JobList[9] = "Astronaut";
            JobList[10] = "Capitan";
            JobList[11] = "Soldier";
            JobList[12] = "Pizza chef";
            JobList[13] = "Chef";
            JobList[14] = "Janitor";
            JobList[15] = "Worker";
            JobList[16] = "Chauffeur";
            JobList[17] = "Waittress";
            JobList[18] = "Ninja";
            JobList[19] = "Doctor";
            JobList[20] = "Chemist";
            JobList[21] = "Caretaker";
            JobList[22] = "Gardener";
            JobList[23] = "Mascot";
            JobList[24] = "Athlete";
            JobList[25] = "Mage";
        }
        public String selectJob(int index)
        {
            Console.WriteLine("job selected in class: " + JobList[index]);
            return JobList[index];
        }
        public String randomJob()
        {
            Random rnd = new Random();
            int index = rnd.Next(0,26);
            Console.WriteLine("rnd in job: " + index);
            Console.WriteLine("job rnd get in class: " + JobList[index]);
            return JobList[index];
          
        }
        public String[] getJobList()
        {
            return JobList;
        }
    }
}
