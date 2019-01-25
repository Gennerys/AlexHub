using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace LabaSharpV2
{

    class GraduateStudentCollection<TKey>
    {
        private System.Collections.Generic.List<GraduateStudent> grlist;
        public delegate void GraduateStudentListHandler(object source, GraduateStudentListHandlerEventArgs args);
        public event GraduateStudentListHandler GraduateStundentAdded;
        public event GraduateStudentListHandler GraduateStudentInserted;
        public delegate void GraduateStudentsChangedHandler<TKey>(object source, GraduateStudentsChangedEventArgs<TKey> args);
        public event GraduateStudentsChangedHandler<TKey> GraduateStudentChanged;
        private Dictionary<TKey, GraduateStudent> _studentDictionary = new Dictionary<TKey, GraduateStudent>();
        public string NameOfCollection
        { get; set; }
        public void _studentHandler(object sender, PropertyChangedEventArgs e)
        {
            
            GraduateStudent graduate = (GraduateStudent)sender;
            GraduateStudentChanged?.Invoke(this, new GraduateStudentsChangedEventArgs<TKey>(NameOfCollection, Revision.Property, e.PropertyName, graduate.Year));

           // Console.WriteLine("Name Of Collection: {0} \nRevision Info: {1} \nProperty: {2}\n", NameOfCollection, Revision.Property, e.PropertyName);
        }
        public GraduateStudentCollection(string noc)
        {
            NameOfCollection = noc;
        }
        public void InsertAt(int j, GraduateStudent gs)
        {

            if (j >= grlist.Count)
            {
                gs.AddArticles();
                GraduateStundentAdded?.Invoke(this, new GraduateStudentListHandlerEventArgs(NameOfCollection, "Вставлен в конец", j));
            }
            else
            {
                grlist.Insert(j - 1, gs);
                GraduateStudentInserted?.Invoke(this, new GraduateStudentListHandlerEventArgs(NameOfCollection, "Вставлен перед элементом", j));
            }

        }
        public bool Remove(GraduateStudent rt)
        {
            if (_studentDictionary.ContainsValue(rt))
            {
                TKey tkey = _studentDictionary.FirstOrDefault(grst => grst.Value.Equals(rt)).Key;
                rt.PropertyChanged-=_studentHandler;
                _studentDictionary.Remove(tkey);
                if (GraduateStudentChanged != null)
                {
                    GraduateStudentChanged(this, new GraduateStudentsChangedEventArgs<TKey>(NameOfCollection, Revision.Remove, "", rt.Year));
                }

                return true;
            }
            else return false;

        }
        public bool Replace(GraduateStudent gsold, GraduateStudent gnew)
        {
            if (_studentDictionary.ContainsValue(gsold))
            {
                foreach (var stud in _studentDictionary.ToArray())
                {
                    if (stud.Value == gsold)
                    {
                        _studentDictionary[stud.Key] = gnew;
                        gsold.PropertyChanged -= _studentHandler;

                        if (GraduateStudentChanged != null)
                        {
                            GraduateStudentChanged(this, new GraduateStudentsChangedEventArgs<TKey>(NameOfCollection, Revision.Replace, "", gnew.Year));
                        }
                        gnew.PropertyChanged += _studentHandler;
                    }

                }
                return true;
            }
            else { return false; }

        }
        public List<GraduateStudent> Aspirants(Tuition form)
        {
            var asp = _studentDictionary.Values.Where(a => a.Form == form).ToList();
            return asp;
        }


        public GraduateStudent this[TKey index]
        {
            get { return _studentDictionary[index]; }
            set { _studentDictionary[index]=value; }
        }

        public void AddDefaults(TKey key)
        {
            if(_studentDictionary==null)
            {
                _studentDictionary = new Dictionary<TKey, GraduateStudent>();
            }
            GraduateStudent graduateStudent = new GraduateStudent(new Person("Alex", "Papirnyk", new DateTime(1999, 10, 01)), "PZ-17-1", "Student", Tuition.FullTime, 2018);
           _studentDictionary.Add(key,graduateStudent);
            graduateStudent.PropertyChanged += _studentHandler;
           /* int j = _studentDictionary.LastIndexOf(graduateStudent);
            var arg = new GraduateStudentListHandlerEventArgs(NameOfCollection, "Был добавлен дефолтный элемент",j);
            GraduateStudentInserted?.Invoke(this, arg);*/
        }
        public GraduateStudentCollection()
            { grlist = new List<GraduateStudent>();}
        public void AddGraduateStudents(TKey key, GraduateStudent GrLists)
        {
            /*if (GrLists == null)
            { GrLists = new GraduateStudent[0]; }*/
           /* for (int i = 0; i < GrLists.Length; i++)
            {*/
                GrLists.PropertyChanged += _studentHandler;
                _studentDictionary.Add(key,GrLists);
                //GraduateStudentInserted?.Invoke(this, new GraduateStudentListHandlerEventArgs(NameOfCollection, "Был добавлен новый элемент", i+1));
            /*}*/
          
        }
        public override string ToString()
        {
            string dtr = "";
            foreach (var it in _studentDictionary)
                dtr += it.Value.ToString();
            return String.Format("Элементы списка:\n "+dtr);
        }
        public string ToShortString()
        {
            string dtr = "";
            foreach (var it in _studentDictionary)
                dtr += it.Value.ToString();
            return String.Format("Элементы списка123 " + dtr);
        }
        public void MySurname()
        {
            grlist.Sort();
        }
        public void MyDate()
        {
            grlist.Sort(new Person());
        }
        public void MyYear()
        {
            grlist.Sort(new GraduateStudentYear());
        }

    

    }
}
