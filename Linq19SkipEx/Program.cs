// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

int[] numbers= new int[] { 1,2,3,4,5,6,7,8,9,10 };

var ms1= numbers.Skip(3).ToList();

var ms2 = numbers.Where(x=>x>4).Skip(3).ToList();

var mixedL1 = (from n in numbers select n).Skip(3).ToList();

var mixedL2 = (from n in numbers where n>4 select n).Skip(3).ToList();

Console.ReadKey();
