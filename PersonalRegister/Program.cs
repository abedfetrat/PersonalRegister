List<Employee> employees = new List<Employee>();

bool running = true;

while (running)
{
    Console.WriteLine("EMPLOYEE REGISTER PROGRAM");
    Console.WriteLine(@"
        1 Add new employee
        2 List all employees
        3 Quit program
    ");
    Console.WriteLine(@"
        What do you want to do? 
        Type the number coresponding to the action you want to perform
    ");

    string? action = Console.ReadLine();
    
    if (action == "1")
    {
        Console.WriteLine("Enter employee fullname:");
        string? fullName = Console.ReadLine();

        Console.WriteLine("Enter employee salary:");
        string? salary = Console.ReadLine();

        Employee employee = new Employee(fullName, salary);
        employees.Add(employee);

        Console.WriteLine("New employee added");
        Console.WriteLine();
    } else if (action == "2")
    {
        Console.WriteLine("All employees:");
        Console.WriteLine();
        for (int i = 1; i <= employees.Count; i++)
        {
            Employee employee = employees[i-1];
            Console.WriteLine($"Employee {i}:");
            Console.WriteLine(employee.ToString());
            Console.WriteLine();
        }
    } else if(action == "3")
    {
        running = false;
    }
}

class Employee
{
    string fullName;
    string salary;

    public Employee(string fullName, string salary)
    {
        this.fullName = fullName;
        this.salary = salary;
    }
    public override string ToString()
    {
        return ($"Name: {fullName} \nSalary: {salary}$");
    }
}

