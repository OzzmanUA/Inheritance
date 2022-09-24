using Inheritance;
Manager man = new Manager()
{
    Name= "Oleg",
    Salary=4333,
    Age=30,
    Clients=5
};
Console.WriteLine(man.GetResultSalary());