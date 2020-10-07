using System;

namespace Geometria
{
    public class Rettangolo
    {
        private int x;
        private int y;
        private int width;
        private int height;

        public Rettangolo(int x, int y, int w, int h)
        {
            this.x = x;
            this.y = y;
            this.width = w;
            this.height = h;
        }

        public int CalcolaArea()
        {
            return width * height;
        }

        public int CalcolaPerimetro()
        {
            return height * 2 + width * 2;
        }

        public bool Contiene(Rettangolo r)
        {
            if(x<=r.x && y <= r.y && x + width >= r.x + r.width && y+height >= r.y + r.height)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    

}
