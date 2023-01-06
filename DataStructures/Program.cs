using System;

namespace DataStructures{
    class Program{
        public static void Main(){
            linkedList list = new linkedList();
            list.AddFirst(70);
            list.AddFirst(30);
            list.AddFirst(56);
            list.Display();
        }
    }
}