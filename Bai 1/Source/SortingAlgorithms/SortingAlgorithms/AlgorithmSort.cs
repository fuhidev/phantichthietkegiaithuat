using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAlgorithms
{
    class AlgorithmSort
    {
        /*Giai thuat 1*********************************/
        //Giai thuat Insertion Sort
        public void InsertionSort(long[] a)
        {
            long pos, i;
            long x;
            for (i = 1; i < a.Length; i++)
            {
                x = a[i]; pos = i - 1;
                while ((pos >= 0) && (a[pos] > x))
                {
                    a[pos + 1] = a[pos];
                    pos--;
                }
                a[pos + 1] = x;
            }
        }



        //Hoan vi gia tri cua 2 phan tu
        public void swap(ref long a, ref long b)
        {
            long tam = a;
            a = b;
            b = tam;
        }
        /*Giai thuat 2*********************************/
        //Giai thuat selection Sort
        public void SelectionSort(long[] a)
        {
            long min;
            for (long i = 0; i < a.Length; i++)
            {
                min = i;
                for (long j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < a[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                    swap(ref a[min], ref a[i]);
            }
        }




        /*Giai thuat 3*********************************/
        //Giai thuat bubble Sort- Giai thuat truc tiep co do phuc tap la O(n)
        public void bubbleSort(long[] a)
        {
            long i, j;
            for (i = 0; i < a.Length - 1; i++)
            {
                for (j = 0; j > a.Length; j++)
                    if (a[j] < a[j - 1])
                    {
                        swap(ref a[j], ref a[j-1]);
                    }
            }
        }




        /*Giai thuat 4***************************************/
        //Giai thuat Merge Sort 
        public void Merge(long[] a, long nb, long nc, long k, long n, long[] b, long[] c)
        {
            long p, pb, pc, ib, ic, kb, kc;
            p = pb = pc = 0; ib = ic = 0;
            while (0 < nb && 0 < nc)
            {
                kb = (k > nb) ? nb : k;
                kc = (k > nc) ? nc : k;
                if (b[pb + ib] < c[pc + ic])
                {
                    a[p++] = b[pb + ib]; ib++;
                    if (ib == kb)
                    {
                        for (; ic < kc; ic++)
                        {
                            a[p++] = c[pc + ic];
                        }
                        pb += kb; pc += kc; ib = ic = 0;
                        nb -= kb; nc -= kc;
                    }
                }
                else
                {
                    a[p++] = c[pc + ic]; ic++;
                    if (ic == kc)
                    {
                        for (; ib < kb; ib++) a[p++] = b[pb + ib];
                        pb += kb; pc += kc; ib = ic = 0;
                        nb -= kb; nc -= kc;
                    }
                }
            }
        }

        public void MergeSort(long[] a, long n)
        {
            long[] b = new long[n];
            long[] c = new long[n];
            long p, pb, pc;
            long i, k = 1;
            do
            {
                p = pb = pc = 0;
                while (p < n)
                {
                    for (i = 0; (p < n) && (i < k); i++)
                        b[pb++] = a[p++];
                    for (i = 0; (p < n) && (i < k); i++)
                        c[pc++] = a[p++];
                }
                Merge(a, pb, pc, k, n, b, c);
                k *= 2;
            } while (k < n);
        }



        /*Giai thuat 5*****************************************/
        //Giai thuat Quick Sort Middle
        public void QuickSortMiddle(long[] a, long left, long right)
        {
            long i, j, x;
            x = a[(left + right) / 2];
            i = left; j = right;
            do
            {
                while (a[i] < x) i++;
                while (a[j] > x) j--;
                if (i <= j)
                {
                    swap(ref a[i], ref a[j]);
                    i++; j--;
                }
            } while (i < j);
            if (left < j)
                QuickSortMiddle(a, left, j);
            if (i < right)
                QuickSortMiddle(a, i, right);
        }


        //Giai thuat Quick Sort First

        public void QuickSortFirst(long[] a, long left, long right)
        {
            long i, j, x;
            x = a[left];
            i = left; j = right;
            do
            {
                while (a[i] < x) i++;
                while (a[j] > x) j--;
                if (i <= j)
                {
                    swap(ref a[i], ref a[j]);
                    i++; j--;
                }
            } while (i < j);
            if (left < j)
                QuickSortFirst(a, left, j);
            if (i < right)
                QuickSortFirst(a, i, right);
        }
        //Giai thuat Quick Sort Random

        Random rd = new Random();
        public void QuickSortRandom(long[] a, long left, long right)
        {
            long i, j, x;
            int l = (int)left; int r = (int)right;
            int n = rd.Next(l, r);
            x = a[n];
            i = left; j = right;
            do
            {
                while (a[i] < x) i++;
                while (a[j] > x) j--;
                if (i <= j)
                {
                    swap(ref a[i], ref a[j]);
                    i++; j--;
                }
            } while (i < j);
            if (left < j)
                QuickSortRandom(a, left, j);
            if (i < right)
                QuickSortRandom(a, i, right);
        }
    }
}
