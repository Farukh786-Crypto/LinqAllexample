// See https://aka.ms/new-console-template for more information
using Linq15IntersectEx;

List<string> dataSource1= new List<string>() { "A","B","C","D" };
List<string> dataSource2= new List<string> { "C","D","E","F" };

var ms=dataSource1.Intersect(dataSource2);

var qs=(from ch in dataSource2
       select ch).Intersect(dataSource1).ToList();

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

var ms1=students2.Select(x=>new { x.Id, x.Name }).Intersect(students1.Select(x=> new { x.Id,x.Name })).ToList();

var ms2 = students1.Intersect(students2,new StudentComparer()).ToList();

Console.ReadKey();
