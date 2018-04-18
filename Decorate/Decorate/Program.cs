using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorate
{
    class Context
    {
        public Context()
        {
            Console.WriteLine("Context Class");
        }
    }

    class ConcreateContext : Context
    {
        public ConcreateContext()
        {
            Console.WriteLine("ConcreateContext Class");
        }
    }

    class Decorator:Context
    {
        public Decorator()
        {
            Console.WriteLine("Decorate Class");

        }
    }

    class ConcreateDecoratorA:Decorator
    {
        int AddedStatus;
        public ConcreateDecoratorA()
        {
            AddedStatus = 0;
            Console.WriteLine("ConcreateDeacoratorA Class.\nAddedStatus : {0}", AddedStatus);
        }
    }

    class ConcreateDecoratorB : Decorator
    {
        public ConcreateDecoratorB()
        {
            Console.WriteLine("ConcreateDeacoratorB Class.");
        }

        public void AddBehavior()
        {
            Console.WriteLine("AddBehavior");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Context con = new Context();
            ConcreateContext ccre = new ConcreateContext();
            Decorator dec = new Decorator();
            ConcreateDecoratorA cda = new ConcreateDecoratorA();
            ConcreateDecoratorB cdb = new ConcreateDecoratorB();
        }
    }
}
