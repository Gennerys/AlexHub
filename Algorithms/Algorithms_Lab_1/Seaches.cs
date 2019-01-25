using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Lab_1
{
    class Searches
    {
        public static string QuickSequential(KeyValue[] a, int n, int x, ref int dummy)
        {
            int last = a[n - 1].key;
            a[n - 1].key = x;
            int index = 0;
            while (a[index].key != x)
            {
                dummy++;
                index++;
            }
            a[n - 1].key = last;
            if (index < n - 1 || a[n - 1].key == x)
            {
                dummy++;
                return a[index].value;

            }
            else
            {
                return null;
            }
        }

        public static string Binary(KeyValue[] a, int n, int x, ref int dummy)
        {
            int low = 0;
            int high = a.Length - 1;

            int location = -1;
            int middle = (low + high + 1) / 2;
            while ((low <= high) && (location == -1))
            {
                dummy++;

                if (x == a[middle].key)
                {
                    location = middle;
                    dummy++;
                }
                if (x > a[middle].key)
                {
                    dummy++;
                    low = middle + 1;
                    middle = (low + high) / 2;
                }
                if (x < a[middle].key)
                {
                    dummy++;
                    high = middle - 1;
                    middle = (low + high + 1) / 2;
                }


            }
            if (location == -1) return null;

            return a[location].value;
        }

        public static string Interpolation(KeyValue[] a, int n, int x, ref int dummy)
        {
            int mid;
            int low = 0;
            int high = a.Length-1 ;
            while (a[low].key < x && a[high].key > x)
            {
                dummy++;
                mid = low + ((x - a[low].key) * (high - low)) / (a[high].key - a[low].key);
                if (a[mid].key < x)
                {
                    low = mid + 1;
                    dummy++;
                }
                else if (a[mid].key > x)
                {
                    high = mid - 1;
                    dummy++;
                }
                else
                {
                    dummy++;
                    return a[mid].value;

                }
            }
            if (a[low].key == x)
            {
                dummy++;
                return a[low].value;

            }
            else if (a[high].key == x)
            {
                dummy++;
                return a[high].value;

            }
            else
            {
                dummy++;
                return null;
            }
        }

        public static string Sequential(KeyValue[] a, int n, int x, ref int dummy)
        {
            for (int i = 0; i < a.Length; i++)
            {
                dummy++;
                if (a[i].key == x)
                {
                    dummy++;
                    return a[i].value;
                }
            }
            return null;
        }

        public static string Fibonacci(KeyValue[] a, int x, ref int dummy)
        {
            int N = a.Length;
            int SKey; // Искомый элемент
            int Search; // Индекс найденного элемента. 0, если элемент не найден
            int Mid; // Индекс внутреннего элемента
            int j, i;
            int F1, F2, t;
            bool Finish;
            SKey = x;
            j = 1;
            while (SFib(j) < (N + 1))
            { j = j + 1; }
            Mid = N - SFib(j - 2) + 1;
            F1 = SFib(j - 2);
            F2 = SFib(j - 3);
            Finish = false;
            for (; ; )
            {
                dummy++;
                if (x > a[a.Length - 1].key || x == 0)
                {
                    dummy++;
                    return null;
                }
                if (Finish)
                    break;
                if (Mid > 0)
                {
                    if (Mid > a.Length - 1)
                        Mid = a.Length - 1;
                    if (SKey == a[Mid].key)
                        break;
                }

                if ((Mid <= 0) || (SKey > a[Mid].key))
                {
                    if (F1 == 1)
                    {
                        Finish = true;
                    }
                    else
                    {
                        Mid = Mid + F2;
                        F1 = F1 - F2;
                        F2 = F2 - F1;
                        dummy++;
                    }
                }
                else
                {
                    if (F2 == 0)
                    {
                        Finish = true;
                    }
                    else
                    {
                        Mid = Mid - F2;
                        t = F1 - F2;
                        F1 = F2;
                        F2 = t;
                        dummy++;

                    }
                }
            }
            if (Finish)
                Search = 0;
            else
                Search = Mid;
            if ((Search < 0) || (Search == N))
            {
                dummy++;
                return null;
            }
            else
            {
                dummy++;
                return a[Search].value;

            }
        }
        public static int SFib(int N)
        {
            int F1, F2;
            if ((N == 0) || (N == 1))
                return (N);
            else
                if (N >= 2)
            {
                F1 = SFib(N - 1);
                F2 = SFib(N - 2);
                return (F1 + F2);
            }
            return -1;
        }
    }
}
