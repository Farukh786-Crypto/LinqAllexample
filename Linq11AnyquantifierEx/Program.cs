// See https://aka.ms/new-console-template for more information
using Linq10AllQuantifierEx;

List<int> numbers = new List<int>();
var isAvailable = numbers.Any();
if(isAvailable)
{
    Console.WriteLine("Value is Present");
}
else
{
    Console.WriteLine("Value is not Present");
}

// data store in list
Student[] students = {
    new Student(){ Name="Kim",Marks=95 },
    new Student(){ Name="John",Marks=80 },
    new Student(){ Name="Lee",Marks=75 }
};

var ms = students.Any(x=>x.Marks>90);

var qs = (from stud in students
         select stud).Any(x=>x.Marks>90);

// Store data in list
Student[] students1 =
{
    new Student()
    {
        Name="Kim",Marks=90,
        Subject=new List<Subject>()
        {
            new Subject(){ SubjectName="Math",SubjectMarks=75 },
            new Subject(){ SubjectName="English",SubjectMarks=80 },
            new Subject(){ SubjectName="Art",SubjectMarks=86 },
            new Subject(){ SubjectName="History",SubjectMarks=91 },
        }
    },
     new Student()
    {
        Name="John",Marks=80,
        Subject=new List<Subject>()
        {
            new Subject(){ SubjectName="Math",SubjectMarks=89 },
            new Subject(){ SubjectName="English",SubjectMarks=91 },
            new Subject(){ SubjectName="Art",SubjectMarks=90 },
            new Subject(){ SubjectName="History",SubjectMarks=91 },
        }
    },
      new Student()
    {
        Name="Lee",Marks=75,
        Subject=new List<Subject>()
        {
            new Subject(){ SubjectName="Math",SubjectMarks=75 },
            new Subject(){ SubjectName="English",SubjectMarks=80 },
            new Subject(){ SubjectName="Art",SubjectMarks=60 },
            new Subject(){ SubjectName="History",SubjectMarks=91 },
        }
    }
};

var ms1 = students1.Where(stud=>stud.Subject.Any(x=>x.SubjectMarks>90)).Select(std=>std.Name).ToList();

var qs1 = (from stud in students1
          where stud.Subject.Any(x=>x.SubjectMarks>90)
          select stud.Name).ToList();

Console.ReadKey();
