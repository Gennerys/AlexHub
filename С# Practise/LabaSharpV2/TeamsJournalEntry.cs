using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabaSharpV2
{
    class TeamsJournalEntry
    {
        public string GraduateStudentCollectionNameWithChanges { get; set; }
        public Revision GetRevision { get; set; } 
        public string EventHappend { get; set; }
        public int Number { get; set; }
        /* public TeamsJournalEntry(GraduateStudentListHandlerEventArgs e)
         {
             GraduateStudentCollectionNameWithChanges = e.CollectionEvent;
             EventHappend = e.ChangesInfo;
             number = e.NumberOfChanged;

         }*/
        public TeamsJournalEntry(string gs,Revision rev,string eh,int number)
        {
            GraduateStudentCollectionNameWithChanges = gs;
            GetRevision = rev;
            EventHappend = eh;
            Number = number;

        }
        public override string ToString()
        {
            return string.Format("\n\n\nИмя коллекции: " + GraduateStudentCollectionNameWithChanges + ".\nТип изменений: " + GetRevision + ". \nНомер нового элемента: " +  Number+ ". \nСвойство базового класса: " + EventHappend);
        }

    }
}
