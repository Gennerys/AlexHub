using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LabaSharpV2
{
    
    public delegate void GraduateStudentListHandler(object source, GraduateStudentListHandlerEventArgs args);
    class Program
    {
        static void Main(string[] args)
        {
            GraduateStudent gStudent = new GraduateStudent(new Person("Alex","Papr",new DateTime(1999,10,1)),"PZ-17","Student",Tuition.FullTime,2017);
            gStudent.AddArticles(new Article("Проблемы обработки данных", "Солнышко",new DateTime(2012,10,1)));
            GraduateStudent lecturer1 = gStudent.DeepCopy();


            Console.WriteLine(gStudent.ToString() + "\n");
            Console.WriteLine(lecturer1.ToString() + "\n");

            link:
            Console.WriteLine("Введи имя файла: ");
            string filename = Console.ReadLine();

            if (!File.Exists($"{filename}.dat"))
            {
                Console.WriteLine("Файла не существует, файл создан");
                File.Create($"{filename}.dat").Close();
                goto link;
            }
            else
            {
                gStudent.Load(filename);
                Console.WriteLine("\n" + gStudent.ToString() + "\n");
            }

            gStudent.AddFromConsole();
            gStudent.Save(filename);

            Console.WriteLine("\n" + gStudent.ToString() + "\n");

            GraduateStudent.Load(filename, gStudent);

            gStudent.AddFromConsole();

            GraduateStudent.Save(filename, gStudent);

            Console.WriteLine("Окончательный результат #1");
            Console.WriteLine("\n" + gStudent.ToString() + "\n");

            Console.ReadLine();

        }
    }

}
