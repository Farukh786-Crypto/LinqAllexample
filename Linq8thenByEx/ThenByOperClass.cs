using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq8thenByEx
{
    public class ThenByOperClass
    {
      public void ThenByOperMethod()
      {
            var dataSource = new List<EmployeeClass>()
            {

                new EmployeeClass()
                {
                    Id= 1,
                    FirstName="Foo",
                    LastName="Smith",
                    Email="Smith@email.com"
                },
                new EmployeeClass()
                {
                    Id= 2,
                    FirstName="Mark",
                    LastName="Thomas",
                    Email="Thomas@email.com"
                },
                new EmployeeClass()
                {
                    Id= 4,
                    FirstName="Foo",
                    LastName="Anderson",
                    Email="Anderson@gmail.com"
                },
                new EmployeeClass()
                {
                    Id= 3,
                    FirstName="Mark",
                    LastName="Allen",
                    Email="Thomas@email.com"
                }
               
            };
            var ms=dataSource.OrderBy(emp=>emp.FirstName).ThenBy(emp=>emp.LastName).ToList();

            var qs = from emp in dataSource
                     orderby emp.FirstName descending, emp.LastName ascending
                     select emp;
            foreach (var item in qs)
            {
                Console.WriteLine($"{item.Id},FirstName={item.FirstName},LastName={item.LastName},Email={item.Email}");
            }
      }
    }
}
