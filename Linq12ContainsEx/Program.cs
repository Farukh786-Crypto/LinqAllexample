// See https://aka.ms/new-console-template for more information

using Linq12ContainsEx;
using System.Security.Cryptography;

List<string> students= new List<string>() { "kim","Jacob","Simon","John" };

var isExisted = students.AsEnumerable().Contains("kim");

var isExistUsingQuery=(from student in students
                      select student).Contains("kim");

// pass object 
List<Student> students2 = new List<Student>()
{
    new Student(){ Id=1,Name="kim" },
    new Student(){ Id=2,Name="John" }
};

// value is getting false bcoz object reference are changing
var isExisted1 = students2.Contains(new Student() { Id = 1, Name = "kim" });

var std = new Student() { Id=1,Name = "kim" };

students2.Add(std);
// value is true 
var isExisted2=students2.Contains(std);

// Note : when you have same value but different object references then use IEqualityComparer<>

var comparer = new StudentComparer();

var isexisted3 = students2.Contains(new Student() { Id = 1, Name = "kim" },comparer);

var qs3 = (from std1 in students2
          select std1).Contains(new Student() { Id = 1, Name = "kim" }, comparer);

Console.ReadKey();
