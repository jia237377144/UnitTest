using System;
namespace Practice.Models
{
    public struct Location
    {
        public Location(double coordinateX,double coordinateY)
        {
            this.CoordinateX = coordinateX;
            this.CoordinateY = coordinateY;
        }

        public double CoordinateX { get; }
        public double CoordinateY { get; }

        public static Location Here()
        {
            return new Location(double.MinValue, double.MaxValue);
        }
    }
}
