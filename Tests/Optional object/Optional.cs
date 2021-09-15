using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_object
{
    public struct Optional<T>
    {
        public bool HasValue { get; private set; }

        public T Value
        {
            get
            {
                if (HasValue)
                    return value;
                else
                    throw new InvalidOperationException();
            }
        }

        public Optional(T value)
        {
            this.HasValue = value ??= false
           
        }

    }
}
