// See https://aka.ms/new-console-template for more information
using LINQ14ExceptOperationEx;
using Linq12ContainsEx;

List<string> dataSource1= new List<string>() { "A","B","C","D" };
List<string> dataSource2 = new List<string>() { "C", "D", "E", "F" };

var ms=dataSource1.Except(dataSource2).ToList();

List<Student> students= new List<Student>()
{ 
    new Student(){ Id=1,Name="John" },
    new Student(){ Id=2,Name="Kim" },
    new Student(){ Id=3,Name="John" },
    new Student(){ Id=4,Name="Mark" }

};
List<Student> students1 = new List<Student>()
{
    new Student(){ Id=1,Name="John" },
    new Student(){ Id=2,Name="Kim" },
    new Student(){ Id=5,Name="John" },
    new Student(){ Id=6,Name="Mark" }
};

var ms1 = students.Select(x=>x.Name).Except(students1.Select(x => x.Name)).ToList();

// this below will give all data which is not true to solve this issue we used anonymous or comparator
var ms2 = students.Except(students1).ToList();
// By using Anonymous method
var ms3 = students.Select(x=>new { x.Id,x.Name }).Except(students1.Select(x=>new { x.Id,x.Name })).ToList();
// By using ComparerMethod
var ms4 = students.Except(students1,new StudentComparer()).ToList();

var qs3 = (from std in students
           select std).Except(students1, new StudentComparer()).ToList();

Console.ReadKey();
