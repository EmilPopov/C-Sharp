
namespace WarMachines.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using WarMachines.Interfaces;
    using System.Linq;
    using System.Text;
    class Pilot : IPilot
    {
        private string name;
        private ICollection<IMachine> pilotMachines;
        public Pilot(string name)
        {
            this.Name = name;
            this.pilotMachines = new List<IMachine>();
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                Validator.StringNullOrEmpty(value, "Name can't be null or empty");
                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            Validator.NullObject(machine, "Added machine can't be null");
            pilotMachines.Add(machine);            
        }

        public string Report()
        {
            var sortedMachines = this.pilotMachines
                .OrderBy(x => x.HealthPoints)
                .ThenBy(x => x.Name);
            var yesOrNoMsshine = this.pilotMachines.Count > 0
                ? this.pilotMachines.Count().ToString()
                : "no";
            var moreThanOneMachine = this.pilotMachines.Count == 1
                ? "machine"
                : "machines";
            var result = new StringBuilder();
            result.AppendLine(string.Format("{0} - {1} {2}",this.Name,yesOrNoMsshine,moreThanOneMachine));
            foreach (var machine in sortedMachines)
            {
                result.AppendLine(machine.ToString());
            }
            return result.ToString().Trim();
        }

    }
}
