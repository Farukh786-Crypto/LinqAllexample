// See https://aka.ms/new-console-template for more information

List<Employee> employees = new List<Employee>()
{ 
    new Employee(){ Id=1,Name="Tom" },
    new Employee(){ Id=2,Name="John" }
};
IEnumerable<Employee> query = from emp in employees
                              where emp.Id == 1
                              select emp;

IQueryable<Employee> query1 = employees.AsQueryable().Where(x=>x.Id==1);

foreach (var item in query1)
{
    Console.WriteLine("Id is :"+item.Id+" "+"Name is :"+item.Name);
}

Console.ReadLine();
