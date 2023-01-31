// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,10 };
// Linq using QuerySyntax
var querySyntx = from listObj in list where listObj > 2 select listObj;
foreach (var item in querySyntx)
{
    Console.WriteLine(item);
}
Console.Write("-------------------------------------------");
var methodsyntax = list.Where(ob=>ob>=2);
foreach (var item in methodsyntax)
{
    Console.WriteLine(item);
}
Console.Write("-------------------------------------------\n");
var mixedsyntax = (from obj in list
                   select obj).Max();
Console.WriteLine("Max Value=" +mixedsyntax);
Console.ReadLine();
