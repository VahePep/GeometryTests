﻿namespace GeometryLibrary
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be positive.");
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

}
