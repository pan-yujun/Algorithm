using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static void swap(int m,int n,List<int> li) {
            int temp = li[m];
            li[m] = li[n];
            li[n] = temp;
        }
        public static void partition(int l,int r,List<int> list) {
        }
        static void Main(string[] args)
        {
            //ArrayList _list = new ArrayList();
            //_list.Add(2);
            //_list.Add("hello");

            List<int> _list = new List<int>() {3,5,8,1,2,9,4,7,6};
            // 冒泡排序，相邻两个比较，因为一轮比较后，最后一个为最大，故最外层循环从后往前走
            /*
            for (int i = _list.count; i > 0; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    if (_list[j] < _list[j - 1])
                    {
                        swap(j - 1, j, _list);
                    }
                }
            }
            */
            // 选择排序，依次选到最小的放到最前面
            /*for (int i = 0;i<_list.Count; i++) {
                for (int j = i;j<_list.Count;j++) {
                    if (_list[j]<_list[i]) {
                        swap(j,i,_list);
                    }
                }
            }*/
            //插入排序,j在前面的有序排列里遍历，找到比_list[i]大的，把——list[i]插入到此处
            /*for (int i = 1; i < _list.Count; i++) {
                for (int j=0;j<i;j++) {
                    if (_list[j]>_list[i]) {
                        swap(j,i,_list);
                    }
                }
            }*/

            foreach (int i in _list) {
                Console.WriteLine(i+"   ");
            }

            Console.ReadLine();
        }
    }
}
