using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Lab_1
{
    class Sorts
    {
        public static int Bubble(KeyValue[] a, int dummy)
        {
            dummy = 0;
            for (int i = 0; i < a.Length; i++)
            {
                bool f = false;
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j].key > a[j + 1].key)
                    {
                        KeyValue temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        f = true;
                        dummy++;
                    }
                }
                if (!f)
                { break; }
            }
            return dummy;
        }

        public static int Quick(KeyValue[] a, int first, int last, int dummy)
        {
            dummy = 0;
            int i = first;
            int j = last;

            int mid = a[(i + j) / 2].key;
            do
            {
                while (a[i].key < mid)
                    i++;
                while (a[j].key > mid)
                    j--;
                if (i <= j)
                {
                    KeyValue temp;
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    i++;
                    j--;
                    dummy++;
                }
            }
            while (i <= j);

            if (j > first)
            {
                Quick(a, first, j, dummy);
            }
            if (i < last)
            {
                Quick(a, i, last, dummy);
            }
            return dummy;
        }

        public static int Selection(KeyValue[] a, int dummy)
        {
            dummy = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j].key < a[min].key)
                    {
                        min = j;
                    }
                }
                KeyValue temp = a[i];
                a[i] = a[min];
                a[min] = temp;
                dummy++;
            }
            return dummy;
        }

        public static int Insertion(KeyValue[] a, int dummy)
        {
            for (int i = 1; i < a.Length; i++)
            {
                dummy++;
                KeyValue cur = a[i];
                int j = i;
                while (j > 0 && cur.key < a[j - 1].key)
                {
                    a[j] = a[j - 1];
                    j--;
                }
                a[j] = cur;
            }
            return dummy;
        }

        public static int Shell(KeyValue[] a, int dummy)
        {
            int j;
            dummy = 0;
            int step = a.Length / 2;
            while (step > 0)
            {
                for (int i = 0; i < a.Length - step; i++)
                {
                    j = i;
                    while ((j >= 0) && (a[j].key > a[j + step].key))
                    {
                        KeyValue tmp = a[j];
                        a[j] = a[j + step];
                        a[j + step] = tmp;
                        j -= step;
                        dummy++;
                    }
                }
                step = step / 2;
            }
            return dummy;
        }
    }
}
