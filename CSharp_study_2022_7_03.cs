using System;
using System.Collections.Generic;
using System.Text;
using AnotherAssembly;

namespace CSharp_study_test2
{
    class CSharp_study_2022_7_03
    {
        static void Main(string[] args)
        {
            #region 引用类型(public、private)
            /*
            Person me = new Person();
            Console.WriteLine(me.Address);

            me.Address = "where";
            Console.WriteLine(me.Address);

            string node = me.GetAddress();
            Console.WriteLine(node);
            */
            #endregion

            #region 引用类型(internal、protected)
            /*
            //internal
            intalClassTest instance = new intalClassTest();
            Console.WriteLine(instance.internalstring);
            
            //protected
            Man man = new Man();
            string manName = man.GetBaseName();
            Console.WriteLine(manName);

            //internal protected
            Class2 anotherAssemblyClassInt = new Class2();
            Console.WriteLine(anotherAssemblyClassInt.GetA());
            */
            #endregion

            #region 继承(重写方法)
            /*
            Dog mydog = new Dog();

            mydog.age = 10;
            Console.WriteLine("age: {0}",mydog.age);

            //重写(new)
            Console.WriteLine("age_new: {0}", mydog.GetAge());

            //重写(virtual->override)
            Console.WriteLine("age_override: {0}", mydog.GetAge_x2());  
            */
            #endregion

            #region 继承(构造函数)
            /*
            //子类实例化时，子父类构造函数调用顺序
            Dog yourdog = new Dog();

            //子类实例化时，子类调用父类普通构造函数，子类调用自己具体构造函数
            Dog newdog = new Dog(10);

            //子类实例化时，子类调用父类具体构造函数，子类调用自己具体构造函数
            Cat newcat = new Cat(20);

            //子类实例化时，子类调用父类普通构造函数，子类再调用自己普通构造函数，最后调用自己具体构造函数
            Pig newpig = new Pig(50);
            */
            #endregion

            #region 继承(new和override奇葩调用,面试常考)
            Animal dog = new Dog();
            dog.GetAge();//new重写,调用基类方法
            dog.GetAge_x2();//virtual重写,调用子类方法
            //((Dog)dog).GetAge_x2();//强制转换为子类时,调用基类方法
            #endregion
        }
    }

    class Person
    {
        private string address = "天堂";//无法直接访问，但可以通过属性和方法获取

        protected string name = "???";

        public string Address
        {
            get { return "休想访问"; }
            set { }
        }

        public string GetAddress()
        {
            if (checkAddress())
                return address;
            else
                return "error";
        }

        private bool checkAddress()
        {
            if (address == "天堂") 
                return true;
            else 
                return false;
        }
    }

    class Man: Person
    {
        public string GetBaseName()
        {
            return base.name;
        }
    }

    class Class2 : Class1
    {
        public int GetA()
        {
            return base.a;
        }
    }

    class Animal
    {
        public int age;

        //基类构造函数
        public Animal()
        {
            Console.WriteLine("Animal constructer");
        }

        public Animal(int age)
        {
            Console.WriteLine("Animal Concreate constructer");
            this.age = age;
        }

        public int GetAge()
        {
            Console.WriteLine("base getage");
            return age;
        }

        public virtual int GetAge_x2()//声明为virtual的方法可被子类用override重写
        {
            Console.WriteLine("base getage_x2");
            return age * 2;
        }
    }

    sealed class Dog : Animal//声明为sealed的类表示此类不可再被其他类继承
    {
        //子类构造函数
        public Dog()
        {
            Console.WriteLine("Dog constructer");
        }

        //子类具体构造函数
        public Dog(int age)
        {
            Console.WriteLine("Dog Concreate constracter");
            this.age = age;
        }

        public new int GetAge()//声明为new的，可重写基类的方法(相当于将基类的GetAge方法隐藏了，而只暴露这个new的)
        {
            Console.WriteLine("son getage");
            return age*101;
        }

        public override int GetAge_x2()//声明为virtual的方法可被子类用override重写
        {
            Console.WriteLine("son getage_x2");
            base.age *= 10;
            return base.GetAge_x2();
        }
    }

    sealed class Cat : Animal
    {
        //子类构造函数
        public Cat()
        {
            Console.WriteLine("Cat constructer");
        }

        //子类具体构造函数
        public Cat(int age) : base(age)
        {
            Console.WriteLine("Cat Concreate constracter");
            this.age = age;
        }
    }

    sealed class Pig : Animal
    {
        //子类构造函数
        public Pig()
        {
            Console.WriteLine("Pig constructer");
        }

        //子类具体构造函数
        public Pig(int age) : this()
        {
            Console.WriteLine("Pig Concreate constracter");
            this.age = age;
        }
    }
}
