using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabaSharpV2
{
    class TeamsJournal<TKey>
    {
        private List<TeamsJournalEntry> journalEntries;
        public List<TeamsJournalEntry> JournalEntries
        {
            get { return journalEntries; }
            set { journalEntries = value; }
        }

        public void /*GraduateStundentAdded*/Show(object sender, GraduateStudentsChangedEventArgs<TKey> e)
        {
            if (JournalEntries == null)
            {
                JournalEntries = new List<TeamsJournalEntry>();
            }
            JournalEntries.Add(new TeamsJournalEntry(e.CollectionName,e.GetRevision,e.NameOfProperty,e.Year));
         //   Console.WriteLine(e.ChangesInfo);
        }
       /* public void GraduateStudentInserted(object sender, GraduateStudentsChangedEventArgs<TKey> e)
        {
            if(JournalEntries==null)
            {
                JournalEntries = new List<TeamsJournalEntry>();
            }
            JournalEntries.Add(new TeamsJournalEntry(e.CollectionName, e.GetRevision, e.NameOfProperty, e.Year));
           // Console.WriteLine(e.ChangesInfo);
        }*/

       public override string ToString()
        {
            if (JournalEntries == null)
            {
               return "Nothing haappend";
            }
            else
            {
                string str = "";
                foreach(TeamsJournalEntry element in JournalEntries)
                {
                    str += element.ToString() + "    ";
                }
                return str;
            }
        }
     
    }
}
