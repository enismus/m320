using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aufgabe05
{
    internal class Rectangle
    {
        private int width;
        private int height;
        private int flaeche;
        private bool isTransparent;


    public Rectangle(int width, int height, int flaeche, bool isTransparent)
        {
        this.width = width;
        this.height = height;
        this.flaeche = flaeche;
        this.isTransparent = isTransparent;
        }
    public Rectangle(int width)
        {
            this.width = width;
        }
    public Rectangle(int height)
        {
            this.height = 0;
        }
    public Rectangle(int flaeche)
        {
            this.flaeche = flaeche;
        }
    public Rectangle(int isTransparent)
        {
            this.isTransparent = 0;
        }
        public void Combined()
        {

            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Height: {0}", height);
            Console.WriteLine("Flaeche: {0}", flaeche);
            Console.WriteLine("isTransparent: {0}", isTransparent);
        }







    }
}
