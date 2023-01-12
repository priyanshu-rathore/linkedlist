using System;

namespace DataStructures{
    class Program{
        public static void Main(){
            linkedList list = new linkedList();
            list.AddLast(56);
            list.AddLast(70);
            list.Insert(30,1);
            list.Pop();
            list.Display();
        }
    }
}