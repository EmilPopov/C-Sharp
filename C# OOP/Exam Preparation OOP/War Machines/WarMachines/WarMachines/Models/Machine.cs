
namespace WarMachines.Models
{
    using System.Collections.Generic;
    using WarMachines.Interfaces;
    using System.Text;

    public abstract class Machine : IMachine
    {
        private string name;
        private IPilot pilot;
        private double healthPoints;
        private IList<string> targets;
        private double attackPoints;
        private double defensePoints;
        public Machine(string name,double attackPoints,double defensePoints,double healthPoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.HealthPoints = healthPoints;
            this.targets = new List<string>();
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                Validator.StringNullOrEmpty(value,"Name can't be null or empty");
                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                Validator.NullObject(value, "Pilot can't be null ");
                this.pilot = value;
            }
        }

        public double HealthPoints { get; set; }
      

        public double AttackPoints{get; protected set;}



        public double DefensePoints { get; protected set; }
   
      

        public IList<string> Targets
        {
            get
            {
                return new List<string>(this.targets);
            }
        }
        
        public void Attack(string target)
        {
            this.targets.Add(target);
        }
        public override string ToString()
        {
            var checkTargets = this.targets.Count > 0
                ? string.Join(", ", this.targets)
                : "None";
            var result = new StringBuilder();
            result.AppendLine(string.Format("- {0}",this.Name));
            result.AppendLine(string.Format(" *Type: {0}",this.GetType().Name));
            result.AppendLine(string.Format(" *Health: {0}",this.HealthPoints));
            result.AppendLine(string.Format(" *Attack: {0}",this.AttackPoints));
            result.AppendLine(string.Format(" *Defense: {0}", this.DefensePoints));
            result.AppendLine(string.Format(" *Targets: {0}", checkTargets));

            return result.ToString();
        }
//- (machine name) 
// *Type: (“Tank”/”Fighter”) 
// *Health: (machine health points) 
// *Attack: (machine attack points) 
// *Defense: (machine defense points) 
// *Targets: (machine target names/”None” – comma separated) 
// *Defense: (“ON”/”OFF” – when applicable) 
// *Stealth: (“ON”/”OFF” – when applicable) 
    }
}
