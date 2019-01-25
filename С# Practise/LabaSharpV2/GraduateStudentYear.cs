using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabaSharpV2
{
   public class GraduateStudentYear:IComparer<GraduateStudent>
    {
      public int Compare(GraduateStudent obj1, GraduateStudent obj2)
        {
            GraduateStudent p1 = obj1 as GraduateStudent;
            GraduateStudent p2 = obj2 as GraduateStudent;
            if (p1 != null && p2 != null)
                return p1.Year.CompareTo(p2.Year);
            else throw new ArgumentException("Not GraduateStudent");
        }
    }
}
