// See https://aka.ms/new-console-template for more information

using Linq25firstEx;

List<int> numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10 };

// find the first element if not found send exception
var ms = numbers.First();

var ms1 = numbers.Where(x => x > 5).FirstOrDefault();
var ms2 = numbers.FirstOrDefault(x => x > 5);
// handle null Exception by show 0
var ms3 = numbers.FirstOrDefault(x=>x>10);


var user = new List<User>()
{
    new User(){ Id=1,UserName="Admin",Password="Admin" },
    new User(){ Id=2,UserName="UserA",Password="UserA" },
    new User(){ Id=3,UserName = "UserB",Password ="UserB" },
    new User(){ Id=4,UserName="UserC",Password="UserC" },
};

var ms4 = user.First(x=>x.UserName=="Admin" && x.Password=="Admin" );
var ms5 = user.FirstOrDefault(x => x.UserName == "Admin" && x.Password == "Admin");

var qs1 = (from us in user
           select us).FirstOrDefault(x=>x.UserName=="Admin" && x.Password=="Admin");

Console.ReadKey();
