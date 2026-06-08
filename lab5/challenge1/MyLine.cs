using System;

namespace challenge1
{
    public class MyLine
    {
        public MyPoint begin;
        public MyPoint end;

        public MyLine(MyPoint begin, MyPoint end)
        {
            this.begin = begin;
            this.end = end;
        }

        public MyPoint getBegin() 
        { return begin; 
        }
        public void setBegin(MyPoint begin) 
        {
            this.begin = begin; 
        }

        public MyPoint getEnd() 
        { return end; }

        public void setEnd(MyPoint end) {
            this.end = end; 
        }

        public double getLength()
        {
            return begin.distanceWithObject(end);
        }

        public double getGradient()
        {
            int yDiff = end.getY() - begin.getY();
            int xDiff = end.getX() - begin.getX();

            if (xDiff == 0) 
                return 0;
            return (double)yDiff / xDiff;
        }
    }
}