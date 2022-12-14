using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colorrmaster
{
    internal class Randomizer
    {
        public int GetColorComponent()
        {
            int value = new Random().Next(0, 255);
            return value;
        }

        public string GetColorHexa()
        {
            Hexculator hexculator = new();

            int ired = this.GetColorComponent();
            int igreen = this.GetColorComponent();
            int iblue = this.GetColorComponent();

            string red = hexculator.hex(ired);
            string green = hexculator.hex(igreen);
            string blue = hexculator.hex(ired);

            string hexa = string.Format("#{0}{1}{2}", red, green, blue);
            return hexa;
        }

        public Color GetColor()
        {
            int red = this.GetColorComponent();
            int green = this.GetColorComponent();
            int blue = this.GetColorComponent();

            Color color = Color.FromArgb(red, green, blue);

            return color;
        }
    }
}
