// See https://aka.ms/new-console-template for more information

using Linq23LeftJoinEx;

var students = new List<Student>()
{
    new Student() { Id = 1,Name="Maria",AddressId= 1},
    new Student() { Id = 2,Name="Amelia",AddressId=2},
    new Student() { Id = 3,Name="Rebecca"},
    new Student() { Id = 4,Name="Una",AddressId=3},
    new Student() { Id = 5,Name="Victoria",AddressId=5},
};

var address = new List<Address>()
{
    new Address() { Id = 1,AddressLine="Maria address"},
    new Address() { Id = 2,AddressLine="Amelia address"},
    new Address() { Id = 3,AddressLine="Una address"}
};

var qs =(from std in students
        join add in address
        on std.AddressId equals add.Id into stdAddress
        from studentAddress in stdAddress.DefaultIfEmpty()
        select new { StudentName=std.Name, StudentAddress=studentAddress!=null ? studentAddress.AddressLine:"NA" }).ToList();

Console.ReadKey();
