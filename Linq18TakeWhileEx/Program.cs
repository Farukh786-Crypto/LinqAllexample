// See https://aka.ms/new-console-template for more information

using System.Linq;
using System.Security.Cryptography;

int[] numbers = new int[] { 1,2,3,4,5,6,7,8,9,10 };
var ms = numbers.TakeWhile(x=>x<7).ToList();

var qs = (from n in numbers select n).TakeWhile(x=>x<7).ToList();

List<string> names = new List<string>() { "Kim","John","Mark","Ada","Nitish" };
var ms1 = names.TakeWhile((name,index)=>name.Length>index).ToList();

var qs1 = (from n in names select n).TakeWhile((name,index)=>name.Length>index).ToList();


Console.ReadKey();
