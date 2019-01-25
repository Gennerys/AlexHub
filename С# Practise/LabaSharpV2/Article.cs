using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabaSharpV2
{
    public enum Tuition { Сorrespondence, FullTime };
    [Serializable]
    public class Article
    {
        public string Article_name { get; set;}
        public string Edition { get; set;}
        public DateTime Date_of_pub { get; set;}
        public Article (string article_name,string edition, DateTime date_of_pub)
        {
            this.Article_name = article_name;
            this.Edition = edition;
            this.Date_of_pub = date_of_pub;
        }
        public Article ()
        {
            this.Article_name = "Blank";
            this.Edition = "Blank";
            this.Date_of_pub = DateTime.Today;
        }
        public override string ToString()
        {
            return String.Format("\nArticle name " + Article_name + "\nEdition " + Edition + "\nDate of publishing " + Date_of_pub);
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            { return false; }
            Article a = obj as Article;
            if (a as Article == null)
            { return false; }
            if (this.Article_name == ((Article)obj).Article_name && this.Edition == ((Article)obj).Edition && this.Date_of_pub == ((Article)obj).Date_of_pub)
            { return true; }
            else
            { return false; }

        }
        public static bool operator ==(Article a1, Article a2)
        {
            return a1.Equals(a2);
        }
        public static bool operator !=(Article a1, Article a2)
        {
            return !a1.Equals(a2);
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public object DeepCopy()
        {
            return new Article(Article_name, Edition, Date_of_pub);
        }


    }
}
