using System;

namespace TrinagleHomeWork
{
    public class Circle : Figure
    {
        private float _radius;
        private Point _center;

        public override string ToString()
        {
            return $"{nameof(_radius)}: {_radius}, {nameof(_center)}: {_center}";
        }

        public Circle(Point bottomLeftSquarePoint, float radius)
        {
            _center = bottomLeftSquarePoint;
            _radius = radius;
        }

        public override float GetSquare()
        {
            // S = pR^2;
            float S = (float) Math.PI * _radius * _radius;
            return S;
        }


        public override float GetPerimeter()
        {
            //P = 2pR
            float P = 2 * (float) Math.PI * _radius;
            return P;
        }

        public bool IsPointInside(Point somePoint)
        {
            float distanceFromCenterToPoint = somePoint.GetDistance(_center);
            if (distanceFromCenterToPoint < _radius)
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