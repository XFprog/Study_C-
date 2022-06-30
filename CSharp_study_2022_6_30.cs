using System;

namespace CSharp_study_test2
{
    enum Types { INT=1,FLOAT,DOUBLE,STRING,CLASS,INTERFACE,DELECATE}
    enum ssss: short { s,ss,sss,ssss}

    class Program
    {
        /// <summary>
        /// test
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region 测试1
            /*
            int a = 5;
            System.Int32 b = 5;
            int c = new int();//整形的构造函数默认值为0

            Console.WriteLine("Hello World!");
            Console.WriteLine("a = {0}", a);
            Console.ReadLine();
            */
            #endregion

            #region 内置引用类型
            /*
            //引用类型object
            object obj = 100f;//装箱
            float b = (float)obj;//拆箱
            Console.WriteLine("obj: "+obj);
            Console.WriteLine("b: {0}", b);

            //引用类型dynamic
            dynamic dyna = 100l;
            double c = (double)dyna;
            Console.WriteLine("dyna: {0} \nc: {1}",dyna,c);

            //引用类型string
            string stra = "\abc";
            string strb = @"\abc
                                d
                                e
                                f";
            Console.WriteLine(stra + "\n" + strb);
            */
            #endregion

            #region 指针类型
            /*
            int* a;//不安全代码
            */
            #endregion

            #region 结构体
            /*
            Person Remy = new Person();
            Remy.name = @"remy";
            Console.WriteLine("name: {0}", Remy.name);
            Remy.attack();
            */
            #endregion

            #region 枚举
            /*
            Types t = Types.DELECATE;
            Console.WriteLine(t);
            Console.WriteLine((int)t);
            Console.WriteLine(ssss.sss);
            */
            #endregion
        }

        struct Person
        {
            public string name;
            public int age;
            public float point;

            public void attack()
            {
                Console.WriteLine("attacking......");
            }
        }
    }
}
