// See https://aka.ms/new-console-template for more information
using POO;

try
{
    //Console.WriteLine(new Date(2024, 2, 29));
    //Console.WriteLine(new Date(2022, 11, 31));
    //Console.WriteLine(new Date(2022, 12, 30));

    Employee employee1 = new SalaryEmployee()
    {
        Id = 1010,
        FirstName = "Sandra",
        LastName = "Morales",
        BirthDate = new Date(1990, 5, 25),
        HiringDate = new Date(2022, 1, 15),
        IsActive = true,
        Salary = 185453.45M

    };

    //Console.WriteLine(employee1);

    Employee employee2 = new ComissionEmployee()
    {
        Id = 1010,
        FirstName = "Juan David",
        LastName = "Barragan",
        BirthDate = new Date(2004, 8, 7),
        HiringDate = new Date(2023, 4, 15),
        IsActive = true,
        CommisionPercentage = 0.03F,
        Sales = 320000000M
    };

    //Console.WriteLine(employee2);

    Employee employee3 = new HourlyEmployee()
    {
        Id = 1010,
        FirstName = "Gonzalo",
        LastName = "Cardona",
        BirthDate = new Date(1985, 5, 23),
        HiringDate = new Date(2023, 4, 15),
        IsActive = true,
        Hours = 123.5F,
        HourValue = 12356.56M
    };

    //Console.WriteLine(employee3);

    Employee employee4 = new BaseComissionEmployee()
    {
        Id = 4040,
        FirstName = "Jazmin",
        LastName = "Salazar",
        BirthDate = new Date(1986, 6, 24),
        HiringDate = new Date(2022, 3, 14),
        IsActive = true,
        Base = 860000.45M,
        Sales = 58000000,
        CommisionPercentage = 0.015F
    };

    //Console.WriteLine(employee4);

    //ICollection<Employee> employees = new List<Employee>();
    //employees.Add(employee1);
    //employees.Add(employee2);
    //employees.Add(employee3);
    //employees.Add(employee4);

    ICollection<Employee> employees = new List<Employee>()
    {
        employee1, employee2, employee3, employee4
    };

    decimal payroll = 0;
    foreach (Employee employee in employees)
    {
        Console.WriteLine(employee);
        payroll += employee.GetValueToPay();
    }

    Console.WriteLine("                                =================");
    Console.WriteLine($"TOTAL                             {$"{payroll:C2}",15}");

    Invoice invoice1 = new Invoice()
    {
        Description = "Iphone 13",
        Id = 1,
        Price = 5300000M,
        Quantity = 6
    };

    Invoice invoice2 = new Invoice()
    {
        Description = "Posta Preum",
        Id = 2,
        Price = 3200M,
        Quantity = 175.5F
    };

    Console.WriteLine(invoice1);
    Console.WriteLine(invoice2);
}
catch (Exception error)
{

    Console.WriteLine(error.Message);

}

