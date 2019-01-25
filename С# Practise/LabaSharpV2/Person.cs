using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabaSharpV2
{
    [Serializable]
    public class Person : IDateAndCopy, IComparable, IComparer<Person>
    {
        protected string name;
        protected string surname;
        protected DateTime date;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public int Birth_Date_changer
        {
            get { return date.Year; }

            set { date = new DateTime(value, date.Month, date.Day); }

        }

        public Person(string name, string surname, DateTime date)
        {
            this.name = name;
            this.surname = surname;
            this.date = date;
        }
        public Person()
        {
            this.name = "Blank";
            this.surname = "Blank";
            this.date = DateTime.Today;
        }

        public override string ToString()
        {
            return String.Format("Name: " + name + " Surname: " + surname + " Birth day: " + date);
        }

        public virtual string ToShortString()
        {
            return String.Format("Name: " + name + " Surname: " + surname);

        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            { return false; }
            Person p = obj as Person;
            if (p as Person == null)
            { return false; }
            if (this.Name == ((Person)obj).Name && this.Surname == ((Person)obj).Surname && this.Date == ((Person)obj).Date)
            { return true; }
            else
            { return false; }

        }
        public static bool operator ==(Person p1, Person p2)
        {
            return p1.Equals(p2);
        }
        public static bool operator !=(Person p1, Person p2)
        {
            return !p1.Equals(p2);
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public virtual object DeepCopy()
        {
            return new Person(this.Name, this.Surname, this.Date);

        }
       public int CompareTo(object obj)
        {
            Person temp = obj as Person;
            if (temp != null)
            {
                /*if (this.Surname > temp.Surname)
                    return 1;
                if (this.Surname < temp.Surname)
                    return -1;
                else
                    return 0;*/
                return string.Compare(this.Surname,temp.Surname);
            }
            else throw new ArgumentException("Params not Person");
        }
        public int Compare(Person obj1, Person obj2)
        {
            Person p3 = obj1 as Person;
            Person p4 = obj2 as Person;
            if (p3 != null && p4 != null)
            {
                if (p3.Date > p4.Date)
                    return 1;
                else if (p3.Date < p4.Date)
                    return -1;
                else
                    return 0;
            }
            /* return p3.Date.CompareTo(p4.Date);*/
            else
                throw new ArgumentException("Not Person");
        }


    }
}
