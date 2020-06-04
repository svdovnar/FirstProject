using System;

namespace Hmwork
{
    public class Triangle
    {
        private Point _verticeA;
        private Point _verticeB;
        private Point _verticeC;
 
        public Point VerticeA { get { return _verticeA; } }
        public Point VerticeB { get { return _verticeB; } }
        public Point VerticeC { get { return _verticeC; } }
        
        //sides стороны
        private Line _sideAB;
        private Line _sideBC;
        private Line _sideCA;
        
        public Line SideAB { get { return _sideAB; } }
        public Line SideBC { get { return _sideBC; } }
        public Line SideCA { get { return _sideCA; } }
 
        
 
        # region Constructors
        // по точкам
        public Triangle(Point verticeA, Point verticeB, Point verticeC)
        {
            _verticeA = verticeA;
            this._verticeB = verticeB;
            this._verticeC = verticeC;
            this._sideAB = new Line(_verticeA, _verticeB);
            this._sideBC = new Line(_verticeB, _verticeC);
            this._sideCA = new Line(_verticeC, _verticeA);
        }
 
        /* по длинам
        public Triangle(int LenghtA, int LenghtB, int LenghtC)
        {
            this._verticeA = new Point(0, 0);//первая вершина
            this._verticeB = new Point(0, LenghtA);// вторая вершина
            // метод поиска третьей вершины есть длинная формула если нужно разберешься  ))
            // 
 
        }
        */
        # endregion
 
        # region calculated properties
        //corners in Radians 
        public double AngleA { get { return GetAngleRadians(SideAB, SideCA, SideBC); } }
        public double AngleB { get { return GetAngleRadians(SideAB, SideBC, SideCA); } }
        public double AngleC { get { return GetAngleRadians(SideBC, SideCA, SideAB); } }
        //Периметр
        public double Perimeter 
        {
            get
            {
                return SideAB.Lenght + SideBC.Lenght + SideCA.Lenght;
            }
        }
        //Площадь
        public double Area 
        {
            get
            {
                return (0.5 * SideAB.Lenght * Altitude(SideAB));
            }
        }
        //Прямоугольный
        public bool Rectangled 
        { 
            get {
                if (this.GetAngleDegree(AngleA) == 90 ||
                    this.GetAngleDegree(AngleB) == 90 ||
                    this.GetAngleDegree(AngleC) == 90) 
                    return true;
                return false;
                }
        }
        //Равнобедренный
        public bool Isosceles 
        {
            get 
            {
                if (this.Rectangled)
                    if (this.SideAB.Lenght == this.SideBC.Lenght ||
                        this.SideBC.Lenght == this.SideCA.Lenght ||
                        this.SideAB.Lenght == this.SideCA.Lenght)
                        return true;
                return false;
            }
        }
        //Равносторонний
        public bool Equilateral 
        {
            get
            {
                if (this._sideAB.Lenght ==this.SideBC.Lenght && 
                    this.SideBC.Lenght == this.SideCA.Lenght)
                    return true;
                return false;
            }
        }
        //Разносторонний
        public bool Versatile 
        {
            get
            {
                if (this.SideAB.Lenght != this.SideBC.Lenght &&
                    this.SideBC.Lenght != this.SideCA.Lenght &&
                    this.SideCA.Lenght != this.SideAB.Lenght)
                    return true;
                return false;
            }
        }
 
        # endregion
        # region private methods
 
        //Получить Угол в радианах
        private double GetAngleRadians(Line side1, Line side2, Line oppositeSide)
        {
            return Math.Acos((side1.Lenght * side1.Lenght +
                              side2.Lenght * side2.Lenght -
                              oppositeSide.Lenght * oppositeSide.Lenght
                              ) / (2 * side1.Lenght * side2.Lenght)
                             );
        }
        /*
                    .C 
                   *|*angleC
                  * | *
                 *  |  *
                *   |   *
               *    |    * 
      angleA  *     |     *angleB
           A ***************B
        */
        //длина высоты
        private double Altitude(Line oppositeSide)// параметр -сторона на которую опущена высота
        {
             if(oppositeSide==SideAB)
                 return SideCA.Lenght * Math.Sin(AngleA);
             if(oppositeSide==SideBC)
                 return SideAB.Lenght * Math.Sin(AngleB);
             if (oppositeSide == SideCA)
                 return SideBC.Lenght * Math.Sin(AngleC);
             return 0.0;
        }
 
 
        # endregion
 
        # region public methods
 
        //Получить Угол в градусах округленный до 2х знаков после запятой
        public double GetAltitudeLenght(Line oppositeSide) { return Altitude(oppositeSide); }
        public double GetAngleDegree(double Angle)
        {
            return Math.Round(Angle * 180 / Math.PI, 2);
        }
 
        # endregion
 
    }
 
    public class Line
    {
        public Point StartPoint;
        public Point EndPiont;
 
        public double Lenght
        {
            get
            {
                return Math.Sqrt(
                      (StartPoint.X - EndPiont.X) * (StartPoint.X - EndPiont.X) +
                      (StartPoint.Y - EndPiont.Y) * (StartPoint.Y - EndPiont.Y)
                      );
            }
        }
 
        public Line(int startX, int startY, int endX, int endY)
            {
                this.StartPoint = new Point(startX, startY);
                this.EndPiont = new Point(endX, endY);
            }
 
        public Line(Point startPoint, Point endPoint)
            {
                this.StartPoint = startPoint;
                this.EndPiont = endPoint;
            }
 
    
    }
 
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
 
        public Point(int coordinateX, int coordinateY)
        { 
                this.X = coordinateX;
                this.Y = coordinateY;
        }
    }
    
}