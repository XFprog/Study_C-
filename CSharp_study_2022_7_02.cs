using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharp_study_test2
{
    class CSharp_study_2022_7_02
    {
        static void Main(string[] args)
        {
            #region 装箱拆箱
            /*
            object myObj = 32;//装箱
            int myInt = (int)myObj;//拆箱
            Console.WriteLine(myObj);
            */
            #endregion

            #region 可空类型
            /*
            //可空整形变量
            int? a = null;//可空整形
            System.Nullable<int> aa = 1111;//可空整形
            Console.WriteLine(a+" "+aa);
            Console.WriteLine(a.HasValue);
            Console.WriteLine(a.GetValueOrDefault());

            //根据是否为空赋值
            int aaa = a ?? 101;//判断a是否为空。为空则给问号后的值，不为空则给本身
            int aaaa = aa ?? 1001;
            Console.WriteLine(aaa);
            Console.WriteLine(aaaa);
            */
            #endregion

            #region 条件语句
            /*
            if (false & true) Console.WriteLine("???");
            */
            #endregion

            #region 循环语句
            /*
            int i;
            for (i = 1, Console.Write("start:[{0}]\n", i); i <= 10; i++, Console.WriteLine("now:[{0}]", i))
            {
                Console.WriteLine("hello");
            }

            //for (; ; ) Console.WriteLine(1);

            List<int> myList = new List<int>() { 1, 0, 0, 8, 6 };
            foreach(var elem in myList)
            {
                Console.WriteLine("[{0}]阿哲!",elem);
            }
            */
            #endregion

            #region 数组
            /*
            //一维数组
            int ii = 5;
            int[] oneArray = new int[ii]; //{1,2,3,4,5 };
            Console.WriteLine("一维数组:");
            foreach(var e in oneArray)
            {
                Console.WriteLine("[{0}]",e);
            }

            //二维数组
            string[,] twoArray = new string[3, 2] { { "111", "222" }, { "333", "444" },{ "555","666"} };
            Console.WriteLine("二维数组:");
            foreach (var e in twoArray)
            {
                Console.WriteLine("[{0}]", e);
            }

            //交错数组(数组的数组)
            byte[][] arrayArray = new byte[ii][];//有着5个一维数组的一维数组
            Console.WriteLine("交叉数组:");
            for (int i = 0;i<arrayArray.Length;i++)
            {
                arrayArray[i] = new byte[i+2];
            }
            foreach(var arr in arrayArray)
            {
                Console.WriteLine("[]length: {0}",arr.Length);
            }

            //其他写法
            int[] qqq = new int[5] { 1, 2, 3, 4, 5 };
            int[] www = new int[] { 1, 2, 3 };
            int[] eee = { 1, 2, 3, 4 };
            int[,] rrr = { { 1, 2 }, { 3, 4 } };
            int[][] ttt = { new int[5], new int[7] };
            */
            #endregion

            #region ArrayList和List(集合类)
            /*
            //动态数组(ArrayList)
            ArrayList al = new ArrayList();
            al.Add(38);
            al.Add(188);
            al.AddRange(new string[] { "aaa", "bbb" });
            al.Remove(38);
            //Console.WriteLine(al[0]);
            Console.WriteLine(al.Capacity);
            for (int j=0;j<al.Count;j++)
            {
                Console.WriteLine("[{0}]: {1}",j,al[j]);
            }

            //列表(List)
            List<int> intList = new List<int>();
            intList.Add(1);
            intList.AddRange(new int[] { 14,15});
            intList.Remove(14);
            intList.Insert(1,555);
            foreach(var i in intList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(intList.IndexOf(15));
            Console.WriteLine(intList.Contains(555));
            */
            #endregion

            #region HashTable和Dictionary(集合类)
            //哈希表(Hashtable)
            Hashtable htab = new Hashtable();
            htab.Add("hero", "saida");
            //htab.Remove("hero");
            Console.WriteLine(htab["hero"]);

            //字典(Dictionary)
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("hero",138);
            dic.Add("kkk", 000);
            dic.Add("jjj", 010);
            foreach (var kv in dic)
            {
                Console.WriteLine(kv.Value);
            }

            //排序列表(SortedList)
            SortedList<int, int> soList = new SortedList<int, int>();
            soList.Add(1, 2);
            soList.Add(3, 4);
            foreach(var sle in soList)
            {
                Console.Write(sle);
            }
            #endregion
        }
    }
}
