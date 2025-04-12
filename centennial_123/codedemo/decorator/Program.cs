using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestHidden();
        }
        static void TestHidden()
        {
            //Parent p1 = new Parent();
            //p1.Foo();
            //p1.Bar();

            //Parent p2 = new Child1();
            //p2.Foo();
            //p2.Bar();
            //Foo of Parent
            //virtual Bar of Parent

            Child2 p3 = new Child2();
            p3.Bar();
            p3.Foo();
            ((Parent)p3).Foo();
            // virtual Bar of Parent
            //Foo of Child2
            //Foo of Parent

        //Parent p4 = new Child3();
        //p4.Foo();
        //p4.Bar();
        // Foo of Parent
        // virtual Bar of Parent
    }
    }


    #region hiding members
    class Parent
    {
        public void Foo() => Console.WriteLine("Foo of Parent");
        public virtual void Bar() => Console.WriteLine("virtual Bar of Parent");
    }
    class Child1 : Parent { }
    class Child2 : Parent
    {
        public new void Foo() => Console.WriteLine("Foo of Child2");
    }
    class Child3 : Parent
    {
        public new virtual void Bar() => Console.WriteLine("virtual Bar of Child3");
    }
    class Child4 : Child3
    {
        // 虽然重新，但因为child3 并不是base，所以这个是无效的
        public override void Bar() => Console.WriteLine("virtual Bar of Child4");

    }
    #endregion
}
