// See https://aka.ms/new-console-template for more information

using Linq21InnerJoinEx;
using System.Net;

var students = new List<Student>()
{
    new Student(){ Id=1,Name="A 1",AddressId=1 },
    new Student(){ Id=2,Name="A 2",AddressId=0 },
    new Student(){ Id=3,Name="A 3",AddressId=2 },
    new Student(){ Id=4,Name="A 4",AddressId=0 },
    new Student(){ Id=5,Name="A 5",AddressId=3 },
};

var addresses = new List<Address>()
{
    new Address(){ Id=1,AddressLine="Line 1" },
    new Address(){ Id=2,AddressLine="Line 2" },
    new Address(){ Id=3,AddressLine="Line 3" },
    new Address(){ Id=4,AddressLine="Line 4" },
    new Address(){ Id=5,AddressLine="Line 5" },
};

var Marks = new List<Mark>()
{
    new Mark(){ Id=1,StudentId=1,TMarks=80 },
    new Mark(){ Id=2,StudentId=2,TMarks=90},
    new Mark(){ Id=3,StudentId=3,TMarks=95}
};

var ms = students.Join(addresses,
           std=> std.AddressId,
           address => address.Id,
           (std, address)=>new
           { 
                StudentName=std.Name,
                Line=address.AddressLine
           }).ToList();

var qs = (from student in students
         join address in addresses
         on student.AddressId equals address.Id
         select new
         {
             StudentName = student.Name,
             Line = address.AddressLine
         }).ToList();

// join on 3 datasource
var qs1 = (from student in students
          join address in addresses
          on student.AddressId equals address.Id
          join mark in Marks
          on student.Id equals mark.StudentId
          select new
          {
              StudentName = student.Name,
              Line = address.AddressLine,
              TotalMarks = mark.TMarks
          }).ToList();


 Console.ReadKey();
