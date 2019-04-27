using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticCoding
{
   public static class Output
    {
        public static void Printer(string source)
        {
            

            ArithCode code = new ArithCode();

            code.Build(source);
            List<Node> nodes = code.GetSymbolsRanges(source);
            List<Node> allCodedNodes = code.Encode(source);
            string decodedNodes = code.Decode(allCodedNodes, source.Length);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n  КОДИРУЕМОЕ СЛОВО:   " + source + "\n");
            Console.WriteLine("\n  Символ  |   Границы символa  | Частота появления");
            Console.WriteLine("----------------------------------------------------");
            foreach (Node node in nodes)
            {
                Console.Write("{0,5}:    |", node.Symbol);
                Console.Write("{0,8:f1}  -", node.Low);
                Console.Write("{0,5:f1}    |", node.High);
                Console.WriteLine("{0,8}", node.Frequency);
            }
            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("\n\n\n\n    НОВЫЕ ГРАНИЦЫ ДЛЯ СИМВОЛОВ: \n");
            Console.WriteLine("\n  Символ  |   Границы символa");
            Console.WriteLine("----------------------------------------------------");
            foreach (Node codedNode in allCodedNodes)
            {
                Console.Write("{0,5}:    |", codedNode.Symbol);
                Console.Write("{0,12}   -", codedNode.Low);
                Console.WriteLine("{0,12}", codedNode.High);
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("\n");

            Console.WriteLine("  ДЕКОДИРОВАНИЕ:   " + decodedNodes);
            

        }
    }
}
