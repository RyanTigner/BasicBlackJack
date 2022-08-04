using System;
using System.Collections.Generic;
using System.Text;

namespace BasicBlackJack
{
    public class Shape_2D_Rectangle : Shape_2D
    {
        public Shape_2D_Rectangle(float l, float w) : base(l, w) { }

        public void Draw()
        {

        }

        public void SetDeminsions(float l, float w)
        {
            this.length = l;
            this.width = w;
        }

        public void SetLength(float l)
        {
            this.length = 1;
        }

        public void SetWidth(float w)
        {
            this.width = w;
        }
        public float Length()
        {
            return this.length;
        }

        public float Width()
        {
            return this.width;
        }

        public float GetArea()
        {
            return (this.length * this.width);
        }

        public float GetPerimeter()
        {
            return ((2 * this.length) + (2 * this.width));
        }

        
    }
}
