namespace SalaryAdjusterApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            WorkPlace workplace = new WorkPlace();
            while (!exit)
            {
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Adjust Salaries");
                Console.WriteLine("3. Display Employees");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter employee type (Permanent/Contract/Intern): ");
                        string type = Console.ReadLine().ToLower();
                        Console.Write("Enter employee name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter employee salary: ");
                        decimal salary = decimal.Parse(Console.ReadLine());
                        Employee employee = type switch
                        {
                            "permanent" => new PermanentEmployee(name, salary),
                            "contract" => new ContractEmployee(name, salary),
                            "intern" => new InternEmployee(name, salary),
                            _ => null
                        };
                        workplace.AddToWorkPlace(employee);
                        break;
                    case "2":
                        workplace.AdjustSalaries();
                        Console.WriteLine("Salaries adjusted.");
                        break;
                    case "3":
                        workplace.displayEmployees();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }

    class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }
    }

    class PermanentEmployee : Employee
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

    class ContractEmployee : Employee
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

    class InternEmployee : Employee
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

    class WorkPlace
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
