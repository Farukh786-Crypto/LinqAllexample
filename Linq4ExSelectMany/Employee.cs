using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq4SelectManyEx
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<string>? Programming { get; set; }
    }
    public class Employee1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Techs>? ProgrammingLanguage { get; set; }
    }
    public class Techs
    {
        public string Technology { get; set; }
    }
}
