// See https://aka.ms/new-console-template for more information

int[] numbers= new int[] { 1,2,3,4,5,6,7,8,9,10 };

List<string> names= new List<string>() { "Kim","John","Ma","Adam","Nitish" };

var ms1= numbers.SkipWhile(x => x < 6).ToArray();

var ms2 = names.SkipWhile( x=>x.Length < 4 ).ToList();

var ms3 = names.SkipWhile((value,index)=>value.Length>index).ToList();

var mixedL1 = (from num in numbers select num).SkipWhile(x=>x<6).ToArray();


Console.ReadKey();
