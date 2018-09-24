using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo1 {
    class DojoStack<T> {
        private DojoElement<T> current;

        public DojoStack() { }

        public DojoStack(T value) {
            current = new DojoElement<T>(value);
        }

        public void Push(T value) {
            if (current == null) {
                current = new DojoElement<T>(value);

            } else {
                DojoElement<T> newCurrent = new DojoElement<T>(value);
                newCurrent.Previous = this.current;
                this.current = newCurrent;
            }
        }

        public T Peek() {
            if (current == null) {
                Console.WriteLine("No Elements in stack");
                return default(T);
            }
            return current.Value;
            //Console.WriteLine(current.Value);
        }

        public T Pop() {
            if (current == null) {
                Console.WriteLine("No Element in stack");
                return default(T);
            }
            T poppedValue = current.Value;

            if (current.Previous == null) {
                current = null;
            } else {
                current = current.Previous;
            }
            return poppedValue;
        }
    }
}
