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
        // 정적할당 : 클래스 인스턴스를 만들지 않아도 접근 가능한 변수.
        SingleObject()
        {
            m_cInstance = null;
        }
        public static SingleObject getInstance() // 정적맴버
        {
            // 클래스는 객체만으로 사용할 수 없다. 객체의 인스턴스를 만들지 않고 사용할 경우, NullReferenceException 발생
            if (m_cInstance == null)
                m_cInstance = new SingleObject();
            return m_cInstance;
            // if로 안 거를 경우, 중복정의로 인하여 포인터가 가리키는 인스턴스가 바뀌게 되고, 쓰던 인스턴스는 GC에 의해 썰린다.
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
