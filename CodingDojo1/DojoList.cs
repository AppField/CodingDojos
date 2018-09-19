using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo1 {
    class DojoList<T> {
        private DojoElement<T> _start;

        public DojoList() { }

        public DojoList(T value) {
            _start = new DojoElement<T>(value);
        }

        public void Push(T value) {
            if (_start == null) {
                _start = new DojoElement<T>(value);

            }
            else {
                DojoElement<T> node = _start;
                while (node.next != null) {
                    node = node.next;
                }
                if (node.value == null) {
                    node.value = value;
                }
                else {
                    node.next = new DojoElement<T>(value);
                }
            }
        }

        public void Peek() {
            DojoElement<T> node = _start;

            if (node == null) {
                Console.WriteLine("No Elements in list");
            }

            while (node.next != null) {
                node = node.next;
            }
            if (node.value != null) {
                Console.WriteLine(node.value);
            }
        }

        public void Pop() {
            DojoElement<T> node = _start;

            if (node == null) {
                Console.WriteLine("No Elements in list");
            }

            bool nextIsLast = false;
            while (!nextIsLast) {
                if (node.next != null && node.next.next == null) {
                    nextIsLast = true;
                } else {
                    node = node.next;
                }
            }
            T valueRemoved = node.next.value;
            node.next = null;
            Console.WriteLine("Value removed: {0}", valueRemoved);
        }

        public void ReadValues() {
            DojoElement<T> node = _start;

            if (node == null) {
                Console.WriteLine("No Elements in list");
            }

            while (node.next != null) {
                Console.WriteLine(node.value);

                node = node.next;
            }
            if (node.value != null) {
                Console.WriteLine(node.value);
            }
        }
    }
}
