using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication155
{
    public class A
    {
        private int i = 0;

        public A()
        {
            i = 7;
        }

        public virtual void MethodA()
        {
            Console.WriteLine("Base A");
        }
    }

    public class B :A
    {
        public int i = 0;

        public B()
        {
            i = 5;
        }

        public void MethodA() //B.MethodA() hides inherited member A.MethodA()
        {
            Console.WriteLine("Child A");
        }

        public void MethodB()
        {
            Console.WriteLine("Child B");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            A obj = new B();
            obj.MethodA(); //Base A (when we use NEW keyword or NO keyword)

            obj.MethodA(); //Child A (when we use OVERRIDE keyword)

            //**  obj.MethodB(); // A does not contain defination of MethodB()

            B obj1 = new B();
            obj1.MethodB(); // Child B

            Console.WriteLine("Value of i : " + obj1.i); // 5

            Console.ReadKey();
        }
    }
}
