
namespace WarMachines.Models
{
    using System.Text;
    using WarMachines.Interfaces;    
    public class Tank : Machine,IMachine,ITank
    {
        private const int AttackPointChange = 40;
        private const int DefensePointChange = 30; 
        private const double initialHealthPoints = 100;
        public Tank(string name, double attackPoints, double defensePoints)
            : base(name, attackPoints, defensePoints,initialHealthPoints)
        {
            this.ToggleDefenseMode();
        }
       
        public bool DefenseMode { get; private set; }


        public void ToggleDefenseMode()
        {
            this.DefenseMode = !this.DefenseMode;
            if (this.DefenseMode == true )
            {
                this.DefensePoints += DefensePointChange;
                this.AttackPoints -= AttackPointChange;
            }
            else
            {
                this.DefensePoints -= DefensePointChange;
                this.AttackPoints += AttackPointChange;
            }
        }
        public override string ToString()
        {         
            var baseString = base.ToString();
            var result = new StringBuilder();
            result.Append(baseString);
            result.Append(string.Format(" *Defense: {0}",this.DefenseMode ? "ON" : "OFF"));
            return result.ToString();
        }
    }
}
