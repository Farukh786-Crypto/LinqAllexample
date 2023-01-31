// See https://aka.ms/new-console-template for more information

using Linq10AllQuantifierEx;

Student[] students = {
    new Student(){ Name="Kim",Marks=90 },
    new Student(){ Name="John",Marks=80 },
    new Student(){ Name="Lee",Marks=75 }
};

var qs = students.All(x => x.Marks > 70);
var qs1 = students.All(x => x.Marks > 80);

var ms = (from student in students
          select student).All(x=>x.Marks>70);

Console.WriteLine(ms);

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

var ms2 = students1.Where(std => std.Subject.All(x => x.SubjectMarks > 70)).Select(std=>std).ToList();

var qs2 = (from std in students1
           where std.Subject.All(x=>x.SubjectMarks>70)
          select std).ToList();

Console.ReadKey();