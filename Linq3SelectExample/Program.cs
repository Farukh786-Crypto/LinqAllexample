// See https://aka.ms/new-console-template for more information
using Linq3SelectExample;
using System.Security.Cryptography;

List<Employee>? employees = new List<Employee>() { 
    new Employee(){ Id=1,Name="Tom",Email="tom@gmail.com" },
    new Employee(){ Id=2,Name="John",Email="john@gmail.com" },
    new Employee(){ Id=3,Name="Mark",Email="mark@gmail.com" },
    new Employee(){ Id=4,Name="Kim",Email="kim@gmail.com" },
};

var Querysyntax =(from emp in employees
                 select emp).ToList();
var Methodsyntax = employees.ToList();
// ---------------
// Operations
var Querysyntax1 = (from emp in employees
                    select emp.Id).ToList();

var Querysyntax2 = (from emp in employees
                    select emp.Id+1).ToList();

var Querysyntax3 = (from emp in employees
                    select emp.Id.ToString()).ToList();

var Methodsyntax1 = employees.Select(emp => emp.Id).ToList();

var selectQuery1 = (from emp in employees
                   select new Employee()
                   { 
                        Id=emp.Id,
                        Email=emp.Name
                   }).ToList();
// Provide data to new Type i.e student
var selectQuery2 = (from emp in employees
                    select new Student()
                    {
                       StudentId=emp.Id,
                       stName=emp.Name,
                       stEmail=emp.Email
                    }).ToList();
var selectMethodsyntax1 = employees.Select(emp=>new Student() 
        {
            StudentId=emp.Id,
            stName=emp.Name,
            stEmail=emp.Email
        }).ToList();

// Writing your own custom properties

var selectMethodsyntax2 = (from emp in employees
                           select new
                           {
                               CustomerId = emp.Id,
                               CustomerName = emp.Name,
                               CustomerEmail = emp.Email
                           });

var selectMethodssyntax3 = employees.Select(emp=>new 
    { 
        CustomerId=emp.Id,
        CustomerName=emp.Name,
        CustomerEmail=emp.Email
    });

var query =employees.Select((emp,index)=>new { Index=index,FullName=emp.Name }).ToList();

/*foreach (var item in selectMethodsyntax2)
{
    Console.WriteLine($"Id :{item.CustomerId},Name:{item.CustomerName},Email:{item.CustomerEmail}");
    //Console.WriteLine(item.CustomerId+" "+item.CustomerName+" "+item.CustomerEmail);
}*/
Console.ReadLine();
