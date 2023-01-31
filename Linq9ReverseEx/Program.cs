// See https://aka.ms/new-console-template for more information

// Data stored in int 
int[] rollnums= new int[] { 1,2,3,4,5,6,7,8,9,10 };

var mq=rollnums.Reverse().ToList();

var qs=(from num in rollnums
       select num).Reverse();
 
foreach (var item in qs)
{
    Console.WriteLine(item);
}

// Data Stored in List
List<string> names= new List<string>() { "Mark","John","Adam","Umar","Bob" };
foreach (var item in names)
{
    Console.WriteLine(item);
}
Console.WriteLine("========== After Reverse =========");
/*names.Reverse();
if you want to convert this method into Ienumerable */
var reversed1 = names.AsEnumerable().Reverse();
var reversed2 = names.AsQueryable().Reverse();

foreach (var item in reversed2)
{
    Console.WriteLine(item);
}

Console.ReadKey();
