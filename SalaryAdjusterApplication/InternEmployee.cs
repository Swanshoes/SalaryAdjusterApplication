using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryAdjusterApplication
{
    internal class InternEmployee : Employee
    {
        int Stipend = 200;
        public InternEmployee(string name, decimal salary) : base(name, salary)
        {
        }
        public void AdjustSalary()
        {
            Salary = Salary + Stipend;
        }
    }
}
