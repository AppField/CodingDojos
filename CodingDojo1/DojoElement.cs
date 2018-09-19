using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo1 {
    class DojoElement<T> {
        public T value;
        public DojoElement<T> next;

        public DojoElement(T value) {
            this.value = value;
        }
    }
}
