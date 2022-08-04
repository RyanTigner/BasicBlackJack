using System;
using System.Collections.Generic;
using System.Text;

namespace BasicBlackJack
{
    public class Shape_2D : Shape
    {
        protected float length;
        protected float width;

        protected Shape_2D(float l, float w)
        {
            this.length = l;
            this.width = w;
        }

    }
}
