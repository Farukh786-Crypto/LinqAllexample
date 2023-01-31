// See https://aka.ms/new-console-template for more information

var numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10 };

// DataSource contain single value ow it gives both errors
//var ms = numbers.Single();
//var ms1 = numbers.SingleOrDefault(); 

var ms2 = numbers.Where(x=>x>9).Single();
var ms3 = numbers.Where(x=>x>9).SingleOrDefault();

Console.ReadKey();
