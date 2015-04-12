using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_And_Workers
{
    public class Worker : Human
    {
        private const int workDays = 5;
        private double fieldWeekSalary;
        private int fieldWorkHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, int workHoursPerDay) : base(firstName,lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public double WeekSalary { get; private set; }
        public int WorkHoursPerDay{ get; private set; }
        public double MoneyPerHour()
        {
            double result = this.WeekSalary / (this.WorkHoursPerDay * workDays);
            return result;
        }
        public override string ToString()
        {
            return base.ToString() + string.Format(" {0:F2} ", this.MoneyPerHour());
        }
    }
}
