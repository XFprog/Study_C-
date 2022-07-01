using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_study_test2
{
    class CSharp_study_2022_7_01
    {
        static void Main(string[] args)
        {
            #region 引用类型测试
            /*
            object o = new object();
            object o2 = new Object();
            Console.WriteLine(o);
            Console.WriteLine(o.ToString());
            Console.WriteLine(o.GetType());

            string str1 = "hello";
            string str2 = " world";
            str1 += str2;//实际从新开辟了一个空间，比较耗性能
            Console.WriteLine(str1);
            Console.WriteLine(str1 == str2);
            Console.WriteLine(str2.Length);
            Console.WriteLine(str2[3]);

            //另一种操作string的方法，在修改字符串时更节省性能
            StringBuilder builder = new StringBuilder();
            builder.Append("Liu ");
            builder.Append("Rong ");
            builder.AppendFormat("Wei{0}", 10086);
            Console.WriteLine(builder);
            */
            #endregion

            #region 类测试
            /*
            Weapon myweapon = new Weapon(188);//类的构造函数在外面可以写new xxx()
            myweapon.shot();
            myweapon.sshot();
            Weapon.sssshot();//公开静态方法不能通过实例访问，二要通过类访问，因为该方法位置唯一的存在该类中，而不在该实例中了
            */
            #endregion

            #region 属性测试
            /*
            Weapon myWeapon = new Weapon(188);
            //最简单的属性
            Console.WriteLine(myWeapon.AAge);//读:get里没有设置操作时默认返回0

            //设置了操作的属性
            Console.WriteLine(myWeapon.ppp);//读；访问时会返回strength+10的值
            myWeapon.ppp = 111;             //写：将111赋值给ppp时，它先会用111代替set里面的value，再把里面的strength值改为value+50，此时strength为161
            Console.WriteLine(myWeapon.ppp);//写完后再访问时，会先到get处返回strength+10，即171

            //测试
            Console.WriteLine(myWeapon.rpg);
            */
            #endregion

            #region 接口和抽象类测试
            /*
            Person me = new Person();
            me.values = 1888;
            Console.WriteLine(me.GetAbstract());
            Console.WriteLine(me.GetSuper());
            */
            #endregion

            #region 显式隐式类型转换测试
            //隐式转换(小空间转大空间, 可自动转换)
            int c = 10;
            double d = c;//自动
            C1 c1 = new C2();//子类转基类(父类)
            Console.WriteLine(c1.GetType());

            //显式转换(大空间转小空间，需要强制转换)
            double a = 10.38;
            int b = (int)a;//强制
            C1 c11 = new C1();
            try
            {
                C2 c22 = (C2)c11;//基类转子类
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            #endregion
        }
    }

    #region 类
    class Weapon
    {
        #region 成员变量
        //成员变量
        int strength;
        #endregion

        #region 属性
        //属性(不同于成员变量,属性可以设置读取和修改时的一些操作。get表示可读,set表示可写,至少要设置一个。其中一个添加操作，另一个就也要)
        public int AAge
        {
            get;
            set;
        }
        public int ppp
        {
            get 
            {
                return strength+10;
            }
            set 
            {
                strength = value + 50; 
            }
        }
        public string rpg{ get { return "mmorpg"; } }
        #endregion

        #region 构造函数
        //构造函数(这个是被隐藏起来的，写出来实际上就是下面这样)
        //public Weapon() { }

        //重构构造函数(也可自己重写构造函数)

        public Weapon(int mystrength)
        {
            this.strength = mystrength;//此this指的是实例出来的类，this可以不写
        }

        #endregion

        #region 成员方法
        //成员方法
        public void shot()//公开的
        {
            Console.WriteLine(strength + "--------------------");
        }
        internal void sshot()//命名空间内部的
        {
            Console.WriteLine(strength + "+-+-+-+-+-+-+-+-+-+-");
        }
        private void ssshot()//私有的
        {
            Console.WriteLine(strength + "+=+=+=+=+=+=+=+=+=+");
        }
        public static void sssshot()//公开静态的
        {
            Console.WriteLine("++++++++++++++++++++");
        }
        #endregion


    }
    class Person : myAbsC,ISuper//继承一个抽象类和一个接口
    {
        public int values;

        //实现抽象类方法
        //实现时要用到override重载
        public override int GetAbstract()
        {
            return values;
        }

        //实现接口方法
        public int GetSuper()
        {
            return values + 10;
        }
    }

    class C1 { }
    class C2 : C1 { }
    #endregion

    #region 抽象类
    abstract class myAbsC
    {
        public int aaaa;
        public int Get_aaaa()
        {
            return aaaa;
        }

        //抽象方法
        //(1)抽象类里的抽象方法只能声明
        //(2)抽象方法必须由继承抽象类的类来实现
        //(3)除了抽象方法其余和普通类一致
        public abstract int GetAbstract();
    }
    #endregion

    #region 接口
    //(1)只含属性、方法、事件、索引
    //(2)方法只能放声明
    //(3)继承了接口的类必须实现接口中的方法
    //(4)一个类可以继承多个接口，但只能继承一个类，并且可以在继承类的同时继承接口
    //(5)接口名一般首字母为大写I表示这是个接口
    interface ISuper
    {
        public int GetSuper();
    }
    #endregion
}
