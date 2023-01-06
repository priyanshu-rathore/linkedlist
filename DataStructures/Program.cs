using System;

namespace DataStructures{
    class Program{
        public static void Main(){
            linkedList list = new linkedList();
            list.AddLast(56);
            list.AddLast(30);
            list.AddLast(70);
            list.Display();
        }
    }
}