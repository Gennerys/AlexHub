using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
namespace LabaSharpV2
{
    public class TestCollections
    {
         private static System.Collections.Generic.List<Person> people = new List<Person>();
         private static System.Collections.Generic.List<string> vs= new List<string>();
         private static System.Collections.Generic.Dictionary<Person, GraduateStudent> pairs= new Dictionary<Person, GraduateStudent>();
         private static System.Collections.Generic.Dictionary<string, GraduateStudent> keys= new Dictionary<string, GraduateStudent>();

     
      /*public static GraduateStudent Generator(int n)
        {
            GraduateStudent graduate = new GraduateStudent() { Name = "Index № " + n.ToString() + " " };
            if (people.Contains(graduate))
            {
                people.Add(graduate as Person);
                vs.Add(graduate.ToString());
                pairs.Add(graduate as Person, graduate);
                keys.Add(graduate.ToString(), graduate);
            }
            return graduate;  
        }*/
        public static GraduateStudent Generator(int n)
        {
            GraduateStudent graduate = new GraduateStudent();
            graduate.Name = n.ToString();
            return graduate;
        }
        public TestCollections(int elements)
        {
            for(int i = 0;i<elements;i++)
            {
                GraduateStudent graduate = Generator(i);
                people.Add(graduate.Person);
                vs.Add(graduate.ToString());
                pairs.Add(graduate.Person, graduate);
                keys.Add(graduate.ToString(), graduate);

            }
        }

     
       
        /*public TestCollections(int elements)
        {
             people = new List<Person>(elements);
             vs = new List<string>(elements);
             pairs = new Dictionary<Person, GraduateStudent>(elements);
             keys = new Dictionary<string, GraduateStudent>(elements);
            for (int i = 0; i < elements; i++)
            {
                GraduateStudent grs1 = Generator(i);
            }
        }*/


        public string Search(int index)
        {
            string result = "";
            bool cont;
         
            GraduateStudent graduate = new GraduateStudent();
            graduate.Name = index.ToString();
            Person p = (Person)graduate;

            //graduate.Name += string.Format(" #{0}", index);
            //  graduate = Generator(index);
            //Person p = (Person)graduate;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            cont = people.Contains(graduate.Person);
            Console.WriteLine(cont);
            stopwatch.Stop();
            result = result + String.Format("Время поиска в списке List<Person> составило: {0}\n", stopwatch.Elapsed);

            stopwatch.Restart();
            cont = vs.Contains(graduate.ToString());
            Console.WriteLine(cont);
            stopwatch.Stop();
            result = result+ String.Format("Время поиска в списке List<string> составило: {0}\n", stopwatch.Elapsed);

            stopwatch.Restart();
            cont = pairs.ContainsKey(graduate.Person);
            Console.WriteLine(cont);
            stopwatch.Stop();
            result = result + String.Format("Время поиска в словаре Dictionary<Person, GraduateStudent> по ключу составило: {0}\n", stopwatch.Elapsed);

            stopwatch.Restart();
            cont = pairs.ContainsValue(graduate);
            Console.WriteLine(cont);
            stopwatch.Stop();
            result = result + String.Format("Время поиска в словаре Dictionary<Person, GraduateStudent> по значению составило: {0}\n", stopwatch.Elapsed);

            stopwatch.Restart();
            cont = keys.ContainsKey(graduate.ToString());
            Console.WriteLine(cont);
            stopwatch.Stop();
            result = result + String.Format("Время поиска в словаре Dictionary<string, GraduateStudent> по ключу составило: {0}\n", stopwatch.Elapsed);

            stopwatch.Restart();
            cont = keys.ContainsValue(graduate);
            Console.WriteLine(cont);
            stopwatch.Stop();

            result = result + String.Format("Время поиска в словаре Dictionary<string, GraduateStudent> по значению составило: {0}\n", stopwatch.Elapsed);
            return result;



        }
    }
}
