using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo1 {
    class DojoStack<T> {
        private DojoElement<T> _start;

        public DojoStack() { }

        public DojoStack(T value) {
            _start = new DojoElement<T>(value);
        }

        public void Push(T value) {
            if (_start == null) {
                _start = new DojoElement<T>(value);

            } else {
                DojoElement<T> node = _start;
                while (node.Next != null) {
                    node = node.Next;
                }
                if (node.Value == null) {
                    node.Value = value;
                } else {
                    node.Next = new DojoElement<T>(value);
                }
            }
        }

        public void Peek() {
            DojoElement<T> node = _start;

            if (node == null) {
                Console.WriteLine("No Elements in list");
                return;
            }

            while (node.Next != null) {
                node = node.Next;
            }
            if (node.Value != null) {
                Console.WriteLine(node.Value);
            }
        }

        public void Pop() {
            DojoElement<T> node = _start;

            if (node == null) {
                Console.WriteLine("No Element in list");
                return;
            }

            if (node.Next == null) {
                T lastValue = _start.Value;
                _start = null;
                Console.WriteLine("Last Value removed: {0}", lastValue);
                return;
            }

            bool nextIsLast = false;
            while (!nextIsLast) {
                if (node.Next != null && node.Next.Next == null) {
                    nextIsLast = true;
                } else {
                    node = node.Next;
                }
            }
            T valueRemoved = node.Next.Value;
            node.Next = null;
            Console.WriteLine("Value removed: {0}", valueRemoved);
        }

        public void ReadValues() {
            DojoElement<T> node = _start;

            if (node == null) {
                Console.WriteLine("No Elements in list");
            }

            while (node.Next != null) {
                Console.WriteLine(node.Value);

                node = node.Next;
            }
            if (node.Value != null) {
                Console.WriteLine(node.Value);
            }
        }
    }
}
