using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo
{
    public class Color
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public int Alpha { get; set; }

        public Color(int red, int green, int blue, int alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public Color(int red, int green, int blue) : this(red, green, blue, 255)
        {
        }

    }

    public class Ball
    {
        public int Size { get; private set; }
        public Color Color { get; set; }
        private int throwCount;

        public Ball(Color color, int size)
        {
            Color = color;
            Size = size;
            throwCount = 0;
        }

        public void Pop()
        {
            Size = 0;
        }

        public void Throw()
        {
            if (Size > 0)
            {
                throwCount++;
            }
        }

        public int GetThrowCount()
        {
            return throwCount;
        }
    }
}
