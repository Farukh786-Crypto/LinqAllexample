// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography;

int[] numbers= new int[] { 1,2,3,4,5,6,7,8,9,10 };
var ms=numbers.Take(5).ToArray();
var ms1=numbers.Where(x=>x>3).Take(4).ToList();
var ms2 = numbers.Take(5).Where(x => x > 3).ToList();

var mixed = (from n in numbers where n > 3 select n).Take(4).ToList();

Console.ReadKey();
