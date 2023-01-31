// See https://aka.ms/new-console-template for more information
using Linq16UnionEx;

List<string> dataSource1 = new List<string>() { "A","A","B","C","D" };
List<string> dataSource2 = new List<string>() { "C", "D", "E", "F" };

var ms = dataSource1.Union(dataSource2).ToList();

// Getting data from class objects
List<Student> students1 = new List<Student>()
{
    new Student(){ Id=1,Name="John" },
    new Student(){ Id=2,Name="Kim" },
    new Student(){ Id=3,Name="John" },
    new Student(){ Id=4,Name="Mark" },
};
List<Student> students2 = new List<Student>()
{
    new Student(){ Id=1,Name="John" },
    new Student(){ Id=2,Name="Kim" },
    new Student(){ Id=5,Name="John" },
    new Student(){ Id=6,Name="Mark" },
};

var ms1 = students1.Union(students2).ToList();

var ms2 = students2.Select(x=>new { x.Id,x.Name }).Union(students1.Select(x =>new { x.Id,x.Name })).ToList();

// using comparer
var ms3 = students1.Union(students2, new StudentComparer()).ToList();

Console.ReadKey();
