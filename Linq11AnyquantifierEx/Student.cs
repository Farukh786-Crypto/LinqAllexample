using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq10AllQuantifierEx
{
    public class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }
        public List<Subject>? Subject { get; set; }
    }
}
