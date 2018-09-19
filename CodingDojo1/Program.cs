using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo1 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Starting Dojo 1\n");

            DojoList<int> dojoList = new DojoList<int>(10);
            dojoList.Push(20);
            dojoList.Push(30);
            dojoList.Push(25);
            dojoList.Push(64);

            Console.WriteLine("\nPeek");
            dojoList.Peek();

            Console.WriteLine("\nRead all Values");
            dojoList.ReadValues();

            Console.WriteLine("\nPeek");
            dojoList.Peek();

            Console.WriteLine("\nPush 66");
            dojoList.Push(66);

            Console.WriteLine("\nPeek");
            dojoList.Peek();

            Console.WriteLine("\nPop");
            dojoList.Pop();

            Console.WriteLine("\nRead all Values");
            dojoList.ReadValues();

            Console.WriteLine("\nPeek");
            dojoList.Peek();

            Console.WriteLine("\nPop");
            dojoList.Pop();
            Console.WriteLine("\nPop");
            dojoList.Pop();

            Console.WriteLine("\nRead all Values");
            dojoList.ReadValues();

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
