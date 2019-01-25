using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabaSharpV2
{
    
     class GraduateStudentsChangedEventArgs<TKey>:EventArgs
    {
        public string CollectionName { get; set; }
        public Revision GetRevision { get; set; }
        public string NameOfProperty { get; set; }
        public int Year { get; set; }
        public GraduateStudentsChangedEventArgs(string cN,Revision rev,string noP,int year)
        {
            CollectionName = cN;
            GetRevision = rev;
            NameOfProperty = noP;
            Year = year;
        }
        public override string ToString()
        {
            return string.Format("Name of Collection = {0}\nRevision = {1}\nName of Property = {2}\nYear = {3}", CollectionName, GetRevision, NameOfProperty, Year);
        }
    }
}
