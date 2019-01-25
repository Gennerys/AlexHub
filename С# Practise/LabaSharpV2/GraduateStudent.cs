using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LabaSharpV2
{
    enum Revision { Remove, Replace, Property };
    [Serializable]
    public class GraduateStudent : Person, IDateAndCopy,IEnumerable, INotifyPropertyChanged
    {

        private Person ryk;
        private string spec;
        private Tuition form;
        private int year;
        private string dolj;
        private System.Collections.Generic.List<Article> aspstat;
        private System.Collections.Generic.List<Notes> ryknot;

        public event PropertyChangedEventHandler PropertyChanged;

        public Person Ryk
        {
            get { return ryk; }
            set { ryk = value;  }
        }
        public string Spec
        {
            get { return spec; }
            set {
                
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Spec"));

                spec = value; }
        }
        public Tuition Form
        {
            get { return form; }
            set {
                
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Form"));

                form = value; }
        }
        public int Year
        {
            get { return year; }
            set
            { year = value; }
                
        }

        

        public string Dolj
        {
            get { return dolj; }
            set { dolj = value; }
        }
        public System.Collections.Generic.List<Notes> GetNotes
        {
            get { return ryknot; }
            set { ryknot = value; }
        }
        public Person Person
        {
            get { return new Person(base.name, base.surname, base.date); }
            set
            {
                base.name = value.Name;
                base.surname = value.Surname;
                base.date = value.Date;
            }
        }
        

            
            
        public GraduateStudent(Person person, string spec,string dolj, Tuition form, int year):base(person.Name,person.Surname,person.Date)
        {
            
            this.spec = spec;
            this.dolj = dolj;
            this.form = form;
            this.year = year;
            this.Aspstat = new List<Article>();
           
          
        }
        public GraduateStudent()
        {
            
            ryk = new Person();
            this.spec = "Blank";
            this.dolj = "Blank";
            this.form = Tuition.FullTime;
            this.year = 2018;
            this.Aspstat = new List<Article>();
            this.ryknot = new List<Notes>();
            
        }
        public Article Lastlist
        {
            get
            {
                int k = 0;
                DateTime max = new DateTime(1000, 1, 1);
                if (Aspstat.Count != 0)
                {
                    for (int i = 0; i <Aspstat.Count; i++)
                    {
                        if (Aspstat[i].Date_of_pub > max)
                        {
                            max = Aspstat[i].Date_of_pub;
                            k = i;
                        }

                    }
                    return Aspstat[k];
                }


                else
                    return null;

            }
        }

        public List<Article> Aspstat { get => aspstat; set => aspstat = value; }

        public void AddArticles(params Article[] Lists)
        {
             if(Lists==null)
            { Lists = new Article[0]; }
            for(int i=0;i<Lists.Length;i++)
            {
                Aspstat.Add(Lists[i]);
                //aspstat.Add(new Article() { Article_name = Lists[i].Article_name, Edition = Lists[i].Edition, Date_of_pub = Lists[i].Date_of_pub });
            }

        }
        public override string ToString()
        {
            string str = "";
           
            
            for (int p = 0; p < Aspstat.Count; p++)
            {
                str = str + Aspstat[p].ToString();
            }
         

            return String.Format("\nRykovoditel' " + base.ToString()+ "\nSpecialnost' " + spec + "\nForma obyjeniya "+form+"\nGod obyjeniya "+year+"\nDoljnost' "+dolj+"\nSpisok statei "+str+"\nSpisok tezisi "+"\n");
        }

        public new virtual string ToShortString()
        {
            return String.Format("\nRykovoditel' " + base.ToString() + "\nSpecialnost' " + spec + "\nForma obyjeniya " + form + "\nGod obyjeniya " + year + "\nDoljnost' " + dolj + "\nKolvo statei " + Aspstat.Count + "\nKolvo tezisi "  + "\n");
        }


        public override bool Equals(object obj)
        {
            var temp = (GraduateStudent)obj;

            if (ReferenceEquals(temp, null) || ReferenceEquals(this, null))
                return false;
            if (!(temp.Aspstat.SequenceEqual(this.Aspstat) || temp.ryknot.SequenceEqual(this.ryknot))) // проверка равенства груп сравнивая элементы с помощью метода System.Object.Equals. Если элементы эквивалентны, и последовательности содержат одинаковое количество элементов, операция возвращает true
                return false;
            return (temp.Date == this.Date && temp.Dolj == this.Dolj && this.Spec == temp.Spec && this.Year == temp.Year);
        
        }
      /*  public override bool Equals(object obj)
        {
            return (obj is GraduateStudent && this == (GraduateStudent)obj);

        }
        public static bool operator ==(GraduateStudent g1, GraduateStudent g2)
        {
            if (ReferenceEquals(g1, null) || ReferenceEquals(g2, null))
                return false;
            if (!g1.aspstat.SequenceEqual(g2.aspstat) || !g2.ryknot.SequenceEqual(g2.ryknot)) // проверка равенства груп сравнивая элементы с помощью метода System.Object.Equals. Если элементы эквивалентны, и последовательности содержат одинаковое количество элементов, операция возвращает true
                return false;
            return (g1.ryk == g2.ryk && g1.spec == g2.spec && g1.year == g2.year && g1.dolj == g2.dolj);
        }
        public static bool operator !=(GraduateStudent g1, GraduateStudent g2)
        {
            return !g1.Equals(g2);
        }*/
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Object> GetEnumerator()
        {
            foreach (Article st in Aspstat)
            { yield return st; }
            foreach (Notes st in ryknot)
            { yield return st; }
        }
        public IEnumerable<Article> GetStudent(DateTime n)
        {
            foreach(var a in Aspstat)
            {
                if (a.Date_of_pub.Year >= n.Year)
                    yield return a;

            }
        }




        private static IFormatter formatter = new BinaryFormatter();
        public new GraduateStudent DeepCopy()
        {

            using (MemoryStream stream = new MemoryStream())
            {
                formatter.Serialize(stream, this);
                stream.Seek(0, SeekOrigin.Begin);
                return formatter.Deserialize(stream) as GraduateStudent;
            }
        }

        public bool Save(string filename)
        {
            if (!File.Exists($"{filename}.dat"))
            {
                Console.WriteLine("Файла с таким именем не обнаруженно. Файл создан");
            }
            try
            {
                using (FileStream fs = new FileStream($"{filename}.dat", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, this);
                    fs.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            return true;
        }

        public bool Load(string filename)
        {
            GraduateStudent gStudent;
            try
            {
                using (FileStream fs = new FileStream($"{filename}.dat", FileMode.Open))
                {
                    gStudent = formatter.Deserialize(fs) as GraduateStudent;
                    fs.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\n ЗАГРУЖАЕМЫЙ ФАЙЛ ПУСТОЙ!");
                return false;
            }

            this.Spec = gStudent.Spec;
            this.Form = gStudent.Form;
            this.Dolj = gStudent.Dolj;
            this.Ryk = gStudent.Ryk;
            this.Year = gStudent.Year;
            this.Aspstat = gStudent.Aspstat;
            return true;
        }

        public bool AddFromConsole()
        {
            string text = "";
            text += "Введите значения для полей обьекта\n";
            text += "Доступные для использования разделители: \" \" , \"-\" , \",\" \n";
            text += "[Название статьи] [Издание] [Год издания]";
            Console.WriteLine(text);
            string[] data = Console.ReadLine().Split(' ', ',', '-');
            DateTime hour;
            try
            {
                hour = new DateTime(int.Parse(data[2]));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            try
            {
               Article subject = new Article(data[0], data[1], hour);
                Aspstat.Add(subject);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Вы ввели неправильные данные!");
                return false;
            }
        }

        public static bool Save(string filename, GraduateStudent obj)
        {
            try
            {
                if (!File.Exists($"{filename}.dat"))
                {
                    Console.WriteLine("Файла с таким именем не обнаруженно. Файл создан");
                }
                using (FileStream fs = new FileStream($"{filename}.dat", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, obj);
                    fs.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            return true;
        }

       
        public static bool Load(string filename, GraduateStudent obj)
        {
            GraduateStudent grStudent;
            try
            {
                using (FileStream fs = new FileStream($"{filename}.dat", FileMode.OpenOrCreate))
                {
                    grStudent = formatter.Deserialize(fs) as GraduateStudent;
                    fs.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            obj.Spec = grStudent.Spec;
            obj.Form = grStudent.Form;
            obj.Dolj = grStudent.Dolj;
            obj.Ryk = grStudent.Ryk;
            obj.Year= grStudent.Year;
            obj.Aspstat = grStudent.Aspstat;
            return true;
        }

    }
    
    
}
