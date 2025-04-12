using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestMcDonalds();
            //TestAbstract();
            TestHidden();
        }
        static void TestMcDonalds()
        {
            Server ayushi = new Server("Ayushi");
            Console.WriteLine(ayushi);

            Supervisor supervisor = new Supervisor("Kevin");
            Console.WriteLine(supervisor);

            Manager manager = new Manager("Apple");
            Console.WriteLine(manager);
        }

        static void TestAbstract()
        {
            //Figure2D figure = new Figure2D(10, 20); //this does not work

            List<Figure2D> list = new List<Figure2D>()
            {
                new Triangle(20, 5),
                new Rectangle(4, 3),
                new Square(5),
                // new Figure2D(20, 5), //abstract classes may not be intantiated  实例化
            };

            foreach (Figure2D figure in list) 
            {
                Console.WriteLine(figure);
            }
        }

        static void TestHidden()
        {
            //Parent p1 = new Parent();
            //p1.Foo();
            //p1.Bar();
            /*
             * Foo of Parent
               virtual Bar of Parent
             */

            //Parent p2 = new Child1();
            //p2.Foo();
            //p2.Bar();

            Child2 p3 = new Child2();
            p3.Bar();
            p3.Foo();
            ((Parent)p3).Foo();
        }

    }
    #region McDonalds
    //server, supervisor, store manager

    #endregion

    #region abstract class

    #endregion

    #region hiding members
    class Parent
    {
        public void Foo() => Console.WriteLine("Foo of Parent");
        /*
         *  virtual 可以在sub class 中被重写，也可以不重写
         */
        public virtual void Bar() => Console.WriteLine("virtual Bar of Parent");
    }
    class Child1 : Parent {
        /**
         * 继承 
         * public void Foo()
         * public virtual void
         */
    }
    class Child2 : Parent 
    {
        public new void Foo() => Console.WriteLine("Foo of Child2");
    }
    class Child3 : Parent
    {
        public new virtual void Bar() => Console.WriteLine("virtual Bar of Child3");
    }
    class Child4: Child3
    {
        public override void Bar() => Console.WriteLine("virtual Bar of Child4");
    }
    #endregion
}
