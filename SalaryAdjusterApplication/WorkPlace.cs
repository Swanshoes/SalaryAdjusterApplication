using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryAdjusterApplication
{
    internal class WorkPlace
    {
        public List<Employee> Employees { get; set; }
        public WorkPlace()
        {
            Employees = new List<Employee>();
        }

        public void AddToWorkPlace(Employee employee)
        {
            Employees.Add(employee);
        }
        public void AdjustSalaries()
        {
            foreach (var employee in Employees)
            {
                if (employee is PermanentEmployee permanentEmployee)
                {
                    permanentEmployee.AdjustSalary();
                    Console.WriteLine($"Adjusted salary for {permanentEmployee.Name}: {permanentEmployee.Salary}");
                }
                else if (employee is ContractEmployee contractEmployee)
                {
                    contractEmployee.AdjustSalary();
                    Console.WriteLine($"Adjusted salary for {contractEmployee.Name}: {contractEmployee.Salary}");

                }
                else if (employee is InternEmployee internEmployee)
                {
                    internEmployee.AdjustSalary();
                    Console.WriteLine($"Adjusted salary for {internEmployee.Name}: {internEmployee.Salary}");

                }
            }
        }

        public void displayEmployees()
        {
            foreach (var employee in Employees)
            {
                Console.WriteLine($"Name: {employee.Name}, Salary: {employee.Salary}");
            }
        }
    }
}
