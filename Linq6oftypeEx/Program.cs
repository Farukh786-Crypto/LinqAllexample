// See https://aka.ms/new-console-template for more information
var dataSource = new List<object>() { "adam","Harry","kim","john",1,2,3,4,5 };

var methodsyntax1 = dataSource.OfType<string>().ToList();

var methodsyntax2 = dataSource.OfType<int>().ToList();

var methodsyntax3 = dataSource.OfType<string>().Where(x=>x.Length>3).ToList();

var querySyntax = (from x in dataSource
                   where x is string
                   select x).ToList();

Console.ReadKey();
