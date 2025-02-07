using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics1
{
    internal class Box<T>
    {
        private T _value;

        public void SetValue(T value)
        {
            _value = value;
        }
        public T GetValue()
        {
            return _value;
        }
    }
}
