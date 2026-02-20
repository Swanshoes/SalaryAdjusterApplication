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
}
