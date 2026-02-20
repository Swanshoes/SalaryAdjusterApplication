using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryAdjusterApplication
{
    internal class PermanentEmployee : Employee
    {
        decimal SalaryMultiplier = 1.1m;
        int Bonus = 1000;
        public PermanentEmployee(string name, decimal salary) : base(name, salary)
        {
        }

        public void AdjustSalary()
        {
            Salary = (Salary * SalaryMultiplier) + Bonus;
        }
    }
}
