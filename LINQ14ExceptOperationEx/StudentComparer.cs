using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ14ExceptOperationEx;

namespace Linq12ContainsEx
{
    public class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student? x, Student? y)
        {
            if(object.ReferenceEquals(x,y))
            {
                return true;
            }
            if(object.ReferenceEquals(x,null) || object.ReferenceEquals(y,null))
            {
                return false; 
            }
            return x.Id == y.Id;
        }

        public int GetHashCode([DisallowNull] Student obj)
        {
            if(Object.ReferenceEquals(obj,null))
            {
                return 0; 
            }

            int idHashCode=obj.Id.GetHashCode();
            int nameHashCode=obj.Name==null?0:obj.Name.GetHashCode();

            return idHashCode^nameHashCode;
        }
    }
}
