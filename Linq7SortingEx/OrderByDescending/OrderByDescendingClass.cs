using Linq4SelectManyEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq7SortingEx.OrderByDescending
{
    public class OrderByDescendingClass
    {
        public void DescendingMethod()
        {
            var dataSourceInt=new List<int>() { 5,12,13,1,7,53,100 };

            var methodSyntax=dataSourceInt.OrderByDescending(x => x).ToList();

            var querySyntax = from num in dataSourceInt
                              where num >12
                              orderby num descending
                              select num;

            // Data in String format
            var dataSourceString = new List<string>()
            {
                "Smith","Anderson","Wright","Mitchell","Thomas","Allen","Evans","Collins"
            };

            var querySyntax1 = (from str in dataSourceString
                               orderby str descending
                               select str).ToList();

            var methodsyntax1 = dataSourceString.OrderByDescending(x=>x).ToList();


            // Sorting with Objects
            var dataSourceObjects1 = new List<Employee>()
            {
                 new Employee(){
                    Id=3,
                    Name="Smith",
                    Email="Smith@gmail.com"
                },
                new Employee(){
                    Id=1,
                    Name="Allen",
                    Email="Allen@gmail.com"
                },
                 new Employee()
                {
                    Id=4,
                    Name="Anderson",
                    Email="Anderson@gmail.com"
                },
                new Employee(){
                    Id=2,
                    Name="Thomas",
                    Email="Thomas@gmail.com"
                },
            };
          /*  foreach (var item in ms)
            {
                Console.WriteLine(item);
            }*/
            var ms = dataSourceObjects1.OrderByDescending(x => x.Id).ToList();

            var qs= (from obj in dataSourceObjects1
                    orderby obj.Id descending
                    select obj).ToList();

            foreach (var item in qs)
            {
                Console.WriteLine($"{item.Id},Name={item.Name},Email={item.Email}");
                /* Console.WriteLine(item.Id+" "+item.Name);*/
            }
        }
    }
}
