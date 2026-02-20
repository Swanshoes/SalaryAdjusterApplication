using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryAdjusterApplication
{
    internal class ContractEmployee : Employee
    {
        decimal SalaryMultiplier = 1.05m;
        public ContractEmployee(string name, decimal salary) : base(name, salary)
        {
        }
        public void AdjustSalary()
        {
            Salary = Salary * SalaryMultiplier;
        }
    }
}
