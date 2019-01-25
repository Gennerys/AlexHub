using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabaSharpV2
{
   public class Notes
    {
        public string Nazvtez
        { get; set; }
        public string Konfa
        { get; set; }
        public DateTime Datetez
        { get; set; }
        public Notes(string nazvtez,string konfa, DateTime datetez)
        {
            this.Nazvtez = nazvtez;
            this.Konfa = konfa;
            this.Datetez = datetez;
        }
        public Notes()
        {
            this.Nazvtez = "Blank";
            this.Konfa = "Blank";
            this.Datetez = DateTime.Today;
        }
        public override string ToString()
        {
            return String.Format("\nNazvanie Tez:  " + Nazvtez + "\nKonferencii " + Konfa + "\nData tez:  " +Datetez);
        }
        public object DeepCopy()
        {
            return new Notes(Nazvtez, Konfa, Datetez);
        }

    }
}
