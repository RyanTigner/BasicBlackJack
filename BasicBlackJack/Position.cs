using System;
using System.Collections.Generic;
using System.Text;

namespace BasicBlackJack
{
    public class Position
    {
        float x { get; set; }
        float y { get; set; }
        float z { get; set; }

        public Position(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void SetPosition(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public float X()
        {
            return this.x;
        }

        public float Y()
        {
            return this.y;
        }

        public float Z()
        {
            return this.z;
        }
    }
}
