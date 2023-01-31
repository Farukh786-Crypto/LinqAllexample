// See https://aka.ms/new-console-template for more information

List<int> numbers = new List<int> { 1,2,3,4,5,6,7,8,9,10 };
List<string> names = new List<string>() { "a","b","c" };
// show element at their position if value is not present in particular position show exception
var ms = numbers.ElementAt(4);

// Show Exception
//var ms1 = numbers.ElementAt(11);

// handle null exception
var ms2 = numbers.ElementAtOrDefault(11);
var ms3 = names.ElementAtOrDefault(12);

var ms4 = numbers.Where(x=>x>3).ElementAtOrDefault(1);

var qs = (from n in numbers
          select n).ElementAt(2);

Console.ReadKey();
