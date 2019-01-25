using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabaSharpV2
{
    public class GraduateStudentListHandlerEventArgs : System.EventArgs
    {
        public string CollectionEvent
        { get; set; }
        public string ChangesInfo
        { get; set; }
        public int NumberOfChanged
        { get; set; }
        public GraduateStudentListHandlerEventArgs(string CollectionEvent,string ChangesInfo, int NumberOfChanged)
        {
            this.CollectionEvent = CollectionEvent;
            this.ChangesInfo = ChangesInfo;
            this.NumberOfChanged = NumberOfChanged;
            
        }
        public override string ToString()
        {
            return String.Format(" 1 " + CollectionEvent + " 2 " + ChangesInfo + " 3 "+NumberOfChanged);
        }

    }
}
