using System;

namespace Records
{
    public class PointC
    {
        public double X { get; init; }
        public double Y { get; init; }
        public double Z { get; init; }
    }

    public struct PointS
    {
        public double X { get; init; }
        public double Y { get; init; }
        public double Z { get; init; }
    }

    // Positional record 
    // public record PointR(double X, double Y, double Z);

    // Manual record
    public record PointR
    {
        public double X { get; init; }
        public double Y { get; init; }
        public double Z { get; init; }

        public override string ToString() => $"({X:N2}, {Y:N2}, {Z:N2})";

        public virtual bool Equals(PointR other)
        {
            Console.WriteLine("Bing!");

            return X == other.X && Y == other.Y && Z == other.Z;
        }

        public override int GetHashCode() => HashCode.Combine(X, Y, Z);
    }

    public record Point4D : PointR
    {
        public double CT { get; set; }
    }
}
