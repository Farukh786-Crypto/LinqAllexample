// See https://aka.ms/new-console-template for more information

using Linq4SelectManyEx;
using System.Security.Cryptography;

var dataSource = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

var querySyntax=(from number in dataSource
                where number<=5 || number>9
                select number).ToList();

var methodSyntax = dataSource.Where(x=>x<=5 || x>9).ToList();

var dataSource1 = new List<string>() { "Tom","Harry","Adam","Ponting","Sachin" };

var queryString1 = (from str in dataSource1
                    where str=="Tom" || str.Length > 4
                    select str).ToList();


var methodSyntax1 = dataSource1.Where(str=>str.Length > 5 || str=="Tom").ToList();


var dataSource3 = new List<Employee>()
{
    new Employee(){ Id=1,Name="Tom",Email="tom@gmail.com",ProgrammingLanguage=
        new List<Techs>
        {
            new Techs(){ Technology="C#" },
            new Techs(){ Technology="PHP" },
            new Techs(){ Technology=".Net" },
            new Techs(){ Technology="MVC" },
            new Techs(){ Technology="SQL" },
        }},
    new Employee(){ Id=2,Name="John",Email="john@gmail.com",ProgrammingLanguage=
        new List<Techs>(){
            new Techs(){ Technology="C#" },
            new Techs(){ Technology="VB" },
            new Techs(){ Technology="SQL" },
        }
    },
    new Employee(){ Id=3,Name="Mark",Email="mark@gmail.com",ProgrammingLanguage=
        new List<Techs>()
        {
             new Techs(){ Technology="LINQ" },
             new Techs(){ Technology="MVC" },
        }

    },
    new Employee(){ Id=4,Name="kim",Email="kim@gmail.com",ProgrammingLanguage=
        new List<Techs>()},
    new Employee(){ Id=5,Name="Adam",Email="Adam@gmail.com",ProgrammingLanguage=new List<Techs>() }
};
// Query have no programming records
var querySyntax3 = (from employee in dataSource3
                   where employee.ProgrammingLanguage.Count==0
                   select employee).ToList();

// Query having 3 programming records
var methodSyntax3 = dataSource3.Where(emp=>emp.ProgrammingLanguage.Count>3 && emp.Name=="Tom").ToList();

Console.ReadKey();
