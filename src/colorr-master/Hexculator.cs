using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colorrmaster
{
    internal class Hexculator
    {
        public Hexculator() { }
        public string hex(int integer)
        {
            string value = string.Format("{0:X}", integer.ToString("X"));
            if (value.Length == 1) value = "0" + value;

            return value;
        }
    }
}
