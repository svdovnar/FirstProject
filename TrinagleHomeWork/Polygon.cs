using System;

namespace TrinagleHomeWork
{
    public class Polygon
    {
        private float _sideLenght;
        private int _anglesNumber;
        

        public Polygon(int anglesNumber, float sideLenght)
        {
            _sideLenght = sideLenght;
            _anglesNumber = anglesNumber;
        }

        public float GetSquare()
        {
            float square = GetRadius()*_sideLenght*_anglesNumber/2; 
            return square;
        }

        public float GetPerimeter()
        {
            float perimeter = _sideLenght * 6;
            return perimeter;
        }

        public float GetRadius()
        {
            float radius = _sideLenght / (Math.Abs(2 * (float) Math.Tan((double) 360 / 2 * _anglesNumber)));
            return radius;
        }
    }
    
}