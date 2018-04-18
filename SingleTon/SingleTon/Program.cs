using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon
{
    class SingleObject
    {
        static SingleObject m_cInstance;
        SingleObject()
        {
            m_cInstance = null;
        }
        public static SingleObject getInstance()
        {
            if (m_cInstance == null)
                m_cInstance = new SingleObject();
            return m_cInstance;
        }

        public void ShowMessage()
        {
            Console.WriteLine("SingleObject!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SingleObject cA;
            cA=SingleObject.getInstance();
            cA.ShowMessage();
        }
    }
}
