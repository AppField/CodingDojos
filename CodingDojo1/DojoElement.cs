using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo1 {
    class DojoElement<T> {
        public T Value { get; set; }
        public DojoElement<T> Previous { get; set; }

        public DojoElement(T value) {
            this.Value = value;
        }
    }
}
