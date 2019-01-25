using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcDZ
{
    class Program
    {
        public static double GetNumber(char []mas,ref int index)
        {
            string number = "";
            //string[] leftBracket = { };
            //string[] rightBracket = { };
            while (((int)mas[index] >= 48 && (int)mas[index] <= 57)|| mas[index] == 48)
            {
                number = number + mas[index].ToString();
                index++;
                if(index==mas.Length)
                {
                    index--;
                    break;
                }


            }
            return double.Parse(number);


        }
        public static double DivAndMulti(char[]mas,ref int index)
        {
            double num = GetNumber(mas, ref index);
            while(true)
            {
                char op = mas[index];
                if (op != '/' && op != '*')
                    return num;
                index++;
                double num1 = GetNumber(mas, ref index);
                if (op == '/')
                    num /= num1;
                else
                    num *= num1;
            }

        }
        public static double PlusAndMin(char[] mas,  int index)
        {
            double num = DivAndMulti(mas, ref index);
            while (true)
            {
                char op = mas[index];
                if (op != '+' && op != '-')
                    return num;
                index++;
                double num1 = DivAndMulti(mas, ref index);
                if (op == '+')
                    num += num1;
                else
                    num -= num1;
            }

        }
        public static char[] ConsoleReader()
        {
            string stringFromConsole = Console.ReadLine();
            char[] stringToParse = new char[stringFromConsole.Length];
            stringToParse = stringFromConsole.ToCharArray();
            return stringToParse;
        }
        public static double GetEvalExpression(char[]mas)
        {
            return PlusAndMin(mas, 0);
        }
        static void Main(string[] args)
        {
          try
            {
                if(args.Length>0)
                {
                    Console.WriteLine(GetEvalExpression(args[1].ToCharArray()).ToString());
                    Console.ReadKey();
                }
                Console.WriteLine(GetEvalExpression(ConsoleReader()).ToString());
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine("{0} Error caught",ex);
            }





        }
    }
}
