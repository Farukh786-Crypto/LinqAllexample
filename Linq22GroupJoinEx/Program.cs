// See https://aka.ms/new-console-template for more information

using Linq22GroupJoinEx;

var students = new List<Student>()
{
    new Student() { Id = 1,Name="Maria",CategoryId=1},
    new Student() { Id = 2,Name="Amelia",CategoryId=1},
    new Student() { Id = 3,Name="Rebecca",CategoryId=2},
    new Student() { Id = 4,Name="Una",CategoryId=2},
    new Student() { Id = 5,Name="Victoria",CategoryId=3}
};

var categories = new List<Category>()
{ 
    new Category() { Id = 1,Name="Mointor"},
    new Category() { Id = 2,Name="Discipline"},
    new Category() { Id = 3,Name="Nothing"}
};

var qs = from c in categories
         join std in students
         on c.Id equals std.CategoryId into stdGroups
         select new { c,stdGroups };


foreach (var item in qs)
{
    Console.WriteLine(item.c.Name);
    foreach (var c in item.stdGroups)
    {
        Console.WriteLine(c.Name);
    }
}


Console.ReadKey();
