using System;

namespace TrinagleHomeWork
{
    public class Point
    {
        public override string ToString()
        {
            return $"{nameof(x)}: {x}, {nameof(y)}: {y}";
        }

        public float x;
        public float y;

        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        
        public float GetDistance(Point otherPoint)
        {
            float katet1 = otherPoint.x - x;
            float katet2 = otherPoint.y - y;
            // D = корень из (Bx - Ax)^2 + (By-Ay)^2; 
            float distance = (float)Math.Sqrt((double)(katet1 * katet1 + katet2 * katet2));
            return distance;
        }
    }
}