using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BitsConsole
{
    public class Bits : IBits
    {
        public byte _value { get; private set; } = 0;
        public Bits(byte value) {
            _value = value;
        }
        public override string ToString()
        {
            return _value.ToString();
        }

        public bool getBits(int index)
        {
            if (index > 7 || index < 0) return false;
            return ((_value >> index) & 1) == 1;
        }

        public void setBits(int index, bool value)
        {
            if (index > 7 || index < 0) return;
            if (value) _value = (byte)(_value | (1 << index));
            else
            {
                var mask = (byte)(1 << index);
                mask = (byte)(0xff ^ mask);
                _value &= (byte)(_value & mask);
            }
        }

        public static implicit operator byte(Bits b) => b._value;
        public static explicit operator Bits(byte b) => new Bits(b);
        public static implicit operator long(Bits l) => l._value;
        public static explicit operator Bits(long l) => new Bits(unchecked ((byte)l));
        public static implicit operator int(Bits i) => i._value;
        public static explicit operator Bits(int i) => new Bits(unchecked ((byte)i));
    }
}
