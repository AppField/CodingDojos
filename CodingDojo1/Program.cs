using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo1 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Starting Dojo 1\n");

            Console.WriteLine("Start Stack with 20, 35");

            DojoStack<int> dojoStack = new DojoStack<int>(20);
            dojoStack.Push(35);

            int peeked = dojoStack.Peek();
            Console.WriteLine("\nPeeked: {0}", peeked);

            Console.WriteLine("\nPush 66");
            dojoStack.Push(66);

            peeked = dojoStack.Peek();
            Console.WriteLine("\nPeeked: {0}", peeked);

            int popped = dojoStack.Pop();
            Console.WriteLine("\nPop: {0}", popped);

            peeked = dojoStack.Peek();
            Console.WriteLine("\nPeeked: {0}", peeked);

            popped = dojoStack.Pop();
            Console.WriteLine("\nPop: {0}", popped);

            Console.WriteLine("\nPush 80");
            dojoStack.Push(80);

            popped = dojoStack.Pop();
            Console.WriteLine("\nPop: {0}", popped);

            popped = dojoStack.Pop();
            Console.WriteLine("\nPop: {0}\n", popped);

            popped = dojoStack.Pop();
            Console.WriteLine("Pop: {0}\n", popped);

            popped = dojoStack.Pop();
            Console.WriteLine("Pop: {0}\n", popped);

            peeked = dojoStack.Peek();
            Console.WriteLine("Peeked: {0}\n", peeked);

            Console.WriteLine("Press key for string demo");
            Console.ReadKey();
            
            Console.WriteLine("\n\n ========= Stack with Strings ========= ");

            Console.WriteLine("\nStart Stack with 'First', 'Second'");

            DojoStack<string> dojoStackStrings = new DojoStack<string>("First");
            dojoStackStrings.Push("Second");

            string peekedString = dojoStackStrings.Peek();
            Console.WriteLine("\nPeeked: {0}", peekedString);

            string poppedString = dojoStackStrings.Pop();
            Console.WriteLine("Pop: {0}\n", poppedString);

            Console.WriteLine("Push 'Third'");
            dojoStackStrings.Push("Third");

            peekedString = dojoStackStrings.Peek();
            Console.WriteLine("\nPeeked: {0}\n", peekedString);

            poppedString = dojoStackStrings.Pop();
            Console.WriteLine("Pop: {0}\n", poppedString);

            poppedString = dojoStackStrings.Pop();
            Console.WriteLine("Pop: {0}\n", poppedString);

            poppedString = dojoStackStrings.Pop();
            Console.WriteLine("Pop: {0}\n", poppedString);

            Console.ReadKey();
        }
    }
}
