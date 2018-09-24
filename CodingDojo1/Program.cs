using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo1 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Starting Dojo 1\n");

            Console.WriteLine("Start Stack with 10, 20, 35");

            DojoStack<int> dojoList = new DojoStack<int>(10);
            dojoList.Push(20);
            dojoList.Push(35);

            Console.WriteLine("\nPeek");
            dojoList.Peek();

            Console.WriteLine("\nPush 66");
            dojoList.Push(66);

            Console.WriteLine("\nPeek");
            dojoList.Peek();

            Console.WriteLine("\nPop");
            dojoList.Pop();

            Console.WriteLine("\nPeek");
            dojoList.Peek();

            Console.WriteLine("\nPop");
            dojoList.Pop();

            Console.WriteLine("\nPush 80");
            dojoList.Push(80);

            Console.WriteLine("\nPop");
            dojoList.Pop();

            Console.WriteLine("\nPop");
            dojoList.Pop();

            Console.WriteLine("\nPop");
            dojoList.Pop();

            Console.WriteLine("\nPop");
            dojoList.Pop();

            Console.WriteLine("\nPeek");
            dojoList.Peek();

            Console.ReadKey();
        }
    }
}
