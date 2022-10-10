namespace PointDemo
{
    public class Point
    {
        private int x;
        private int y;

        public Point()
        {
            
        }

        public Point(int x, int y)
        {
            setX(x);
            Y = y;
        }
        
        public int getX()
        {
            return x;
        }

        public void setX(int x)
        {
            this.x = (x >= 30 && x <= 100 ? x : this.x);
        }

        public int Y
        {
            get => y;
            set
            {
                y = (value >= 30 && value <= 100 ? value : this.y);
            }
        }

        public override string ToString()
        {
            return getX() + " " + Y;
        }
    }
}