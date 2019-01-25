using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabaSharpV2
{
   interface IDateAndCopy
    {
        object DeepCopy();
        DateTime Date { get; set; }
    }
}
