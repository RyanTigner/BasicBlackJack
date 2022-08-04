using System;
using System.Collections.Generic;
using System.Text;

namespace BasicBlackJack
{
    public abstract class Card
    {


        public Shape_2D_Rectangle Deminsons { get; set; }
        public Position Position { get; set; }


        public struct Image
        {
            public Image (string frontImage, string backImage)
            {
                this.frontImage = frontImage;
                this.backImage = backImage;
            }

            public string frontImage;
            public string backImage;
        }

        public Image m_SImage;
        public bool m_bFaceUp;


        public Card(Position position, Shape_2D_Rectangle deminsions, Image image)
        {
            this.Position = position;
            this.Deminsons = deminsions;
            this.m_SImage = image;
            this.m_bFaceUp = true;
        }
        public Card()
        {

        }


    }
}
