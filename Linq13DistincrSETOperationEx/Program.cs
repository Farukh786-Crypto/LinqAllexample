// See https://aka.ms/new-console-template for more information

using Linq12ContainsEx;
using Linq13DistincrSETOperationEx;

List<int> numbers = new List<int>() { 1,2,3,1,2,3,4,3,5,5 };

var ms = numbers.Distinct().ToList();

var qs = (from num in numbers
         select num).Distinct().ToList();


// pass data through object
List<Student> students = new List<Student>()
{
    new Student() { Id=1,Name="John" },
    new Student() { Id=2,Name="kim" },
    new Student() { Id=3,Name="John" },
    new Student() { Id=4,Name="kim" }
};

var ms1 = students.Distinct().ToList();

var ms2 = students.Select(x => x.Name).Distinct().ToList();

// By using IEqualityComparer<Student>
var ms3 = students.Distinct(new StudentComparer()).ToList();

Console.ReadKey();

