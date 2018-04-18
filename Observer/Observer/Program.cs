using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Subject
    {
        List<Observer> observerCollection = new List<Observer>();
        public void registerObserver(Observer observer)
        {
            observerCollection.Add(observer);
        }

        public void unregisterObserver(Observer observer)
        {
            observerCollection.Remove(observer);
        }

        public void notifyObservers(String str)
        {
            for (int i = 0; i < observerCollection.Count; i++)
                Console.WriteLine(observerCollection[i]);
        }
    }

    class Observer
    {
        public void Notify(string note)
        {

        }
    }

    class ConcreateObserverA:Observer
    {
        public void Notify(String str)
        {
            
        }
    }

    class ConcreateObserverB : Observer
    {
        public void Notify(String str)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
