// See https://aka.ms/new-console-template for more information

List<int> numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10 };
// Find last element- of a DataSource
var ms=numbers.Last();
var ms1=numbers.LastOrDefault();

// if value is not present  Last() throw exception
// var ms3 = numbers.Where(x=>x>15).Last();
var ms4 = numbers.Where(x=>x>15).LastOrDefault();

var mixedS = (from n in numbers
              where n>15
             select n).LastOrDefault();

Console.ReadLine();
