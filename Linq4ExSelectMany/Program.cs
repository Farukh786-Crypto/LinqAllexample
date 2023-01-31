// See https://aka.ms/new-console-template for more information
using Linq4SelectManyEx;
using System.Security.Cryptography.X509Certificates;

List<string> strList = new List<string>() { "Nitish", "kaushik" };
var methodResult = strList.SelectMany(x => x).ToList();
// Note : there is no selectmany() in Querystring so we do following

var QueryStringResult = (from rec in strList
                         from ch in rec
                         select ch).ToList();

var dataSource = new List<Employee>()
{
    new Employee(){ Id=1,Name="Tom",Email="Tom@gmail.com",Programming=new List<string>(){ "C#","PHP","JAVA" } },
    new Employee(){ Id=2,Name="Kim",Email="Kim@gmail.com",Programming=new List<string>(){ "LINQ","C#","MVC" } },
    new Employee(){ Id=3,Name="Harry",Email="Harry@gmail.com",Programming=new List<string>(){ "LINQ","VB","SQL" } },

};

var methodSyntax = dataSource.SelectMany(x => x.Programming).ToList();

foreach (var item in methodSyntax)
{
    Console.WriteLine("Programming" + item);
}


var QuerySyntax = (from emp in dataSource
                   from skill in emp.Programming
                   select skill).ToList();

foreach (var item in QuerySyntax)
{
    Console.WriteLine("Programming -" + item);
}

var dataSource1 = new List<Employee1>()
{
    new Employee1(){ Id=1,Name="Ashok",Email="Ashok@gmail.com",ProgrammingLanguage=
        new List<Techs>
        {
            new Techs(){ Technology="c#" },
            new Techs(){ Technology="PHP" },
            new Techs(){ Technology=".Net" }
        }
    },
    new Employee1(){ Id=2,Name="Nilesh",Email="Nil@gmail.com",ProgrammingLanguage=new List<Techs>()
        {
            new Techs(){ Technology="C#" },
            new Techs(){ Technology="VB" },
            new Techs(){ Technology="SQL" }
        }
    },
    new Employee1(){ Id=3,Name="Akshay",Email="Walunjakshay@gmail.com",ProgrammingLanguage=new List<Techs>()
        {
            new Techs(){ Technology="LINQ" },
            new Techs(){ Technology="MVC" },
            new Techs(){ Technology="C#" }
        }
    },
    new Employee1(){ Id=4,Name="john",Email="jogncena@gm,ail.com",ProgrammingLanguage= new List<Techs>()},
    new Employee1(){ Id=5,Name="Adam",Email="adam@gm,ail.com",ProgrammingLanguage= new List<Techs>()}
};

var methodQuery1 = dataSource.SelectMany(emp => emp.Programming).ToList();

var QuerySyntax1 = (from emp in dataSource1
                  from pro in emp.ProgrammingLanguage
                  select pro).ToList();

Console.ReadKey();