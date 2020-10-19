
using System.Text.Json;

namespace BLI.Data.Adult {
public class Adult:Person
    {
        private Job Jobpool;
        public string Job { get; set; }
        public Adult(Person person,string Job )
        {
            FirstName = person.FirstName;
            LastName = person.LastName;
            Id = person.Id;
            HairColor = person.HairColor;
            EyeColor = person.EyeColor;
            Height = person.Height;
            Weight = person.Weight;
            Sex = person.Sex;
            Age = person.Age;
            this.Job = Job;
        }
        public string getChosenJobTitle(int index)
        {
            Job = Jobpool.selectJob(index);
            return Job;
        }
        public string getRamdonJob()
        {
            Job = Jobpool.randomJob();
            return Job;
        }
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }

        public void Update(Adult toUpdate)
        {
            Job = toUpdate.Job;
            base.Update(toUpdate);
        }


    }
}