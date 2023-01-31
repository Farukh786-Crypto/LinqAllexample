using Linq4SelectManyEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq7SortingEx.OrderBy
{
    public class OrderByClass
    {
        public void OrderByMethod()
        {
            // Sorting with Number
            var dataSource1=new List<int>() { 5, 12, 13, 1, 7, 53, 100 };

            var querySyntax = (from num in dataSource1
                               orderby num
                               select num).ToList();

            var querySyntax1=from num in dataSource1
                             where num > 10
                             orderby num
                             select num;

            var methodSyntax=dataSource1.OrderBy(x=>x).ToList();
            var methodsyntax1 = dataSource1.Where(x=>x>10).OrderBy(num=>num).ToList();

            // Sorting with strings
            var dataSourceStrings=new List<string>() { 
                "Smith","Anderson","Wright","Mitchell","Thomas","Allen","Evans","Collins"
            };

            var querySyntax2=(from name in dataSourceStrings
                             orderby name
                             select name).ToList();

            var querySyntax3 = (from name in dataSourceStrings
                               where name.Length > 6
                               orderby name
                               select name).ToList();

            var methodSyntax2 = dataSourceStrings.OrderBy(name => name).ToList();

            // Sorting with Objects
            var dataSourceObjects = new List<Employee>()
            {
                new Employee(){
                    Id=1,
                    Name="Allen",
                    Email="Allen@gmail.com"
                },
                new Employee(){
                    Id=2,
                    Name="Thomas",
                    Email="Thomas@gmail.com"
                },
                new Employee(){
                    Id=3,
                    Name="Smith",
                    Email="Smith@gmail.com"
                },
                new Employee()
                {
                    Id=4,
                    Name="Anderson",
                    Email="Anderson@gmail.com"
                }
            };

            var querysyntax3 = from emp in dataSourceObjects
                               orderby emp.Name
                               select emp;

            var methodSyntax3 = dataSourceObjects.OrderBy(emp => emp.Name).ToList();

            foreach (var item in methodSyntax3)
            {
                Console.WriteLine(item.Id+" "+item.Name);
            }

        }
    }
}
