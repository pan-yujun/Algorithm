using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {0,4,-6,1,-7,9 };
            Sort _sort = new Sort();
            _sort.SortQuick(a);
            foreach (int i in a) {
                Console.Write(i + "   ");
            }
            Console.WriteLine("helloworld");
            Console.ReadLine();
        }
        
    }
    class Sort { //1232334r34rtwerfvv豆腐干豆腐干
        // 快速排序
        public void SortQuick(int[] a)
        {
            int left = 0, right = a.Length - 1;
            quickSort(left, right, a);
        }
        private int[] quickSort(int left, int right, int[] a)
        {
            if (left < right)
            {
                int indexPovit = parttion(left, right, a);
                quickSort(0, indexPovit - 1, a);
                quickSort(indexPovit + 1, right, a);
            }
            return a;
        }
        private int parttion(int left, int right, int[] a)
        {
            int povit = left;
            int index = left + 1;
            for (int i = index; i <= right; i++)
            {
                if (a[i] < a[povit])
                {
                    swap(i, index, a);
                    index++;//index永远指向第一个>=a[povit]的位置
                }
            }
            swap(index - 1, povit, a);//最后将index前一个与基准点交换位置
            return index - 1;
        }
        private void swap(int i, int j, int[] a)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
    }
}
