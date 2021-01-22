using System;

namespace Records
{
    class Program
    {
        static void Main()
        {
            //string s1 = "Hello";
            //string s2 = "Hello";

            //Console.WriteLine(s1 == s2);

            PointR r1 = new PointR { X = 1, Y = 2, Z = 3 };
            PointR r2 = new PointR { X = 1, Y = 2, Z = 3 };

            PointS s1 = new PointS { X = 1, Y = 2, Z = 3 };
            PointS s2 = new PointS { X = 1, Y = 2, Z = 3 };

            PointC c1 = new PointC { X = 1, Y = 2, Z = 3 };
            PointC c2 = new PointC { X = 1, Y = 2, Z = 3 };

            //IEquatable<PointR> eq = r1;

            Console.WriteLine(r1 != r2);
            //Console.WriteLine(c1 == c2);
            //Console.WriteLine(s1 == s2);

            PointR r3 = r1 with { X = 27, Z = 200 };

            Console.WriteLine(object.ReferenceEquals(r3,r1));

            Console.WriteLine(r1);
            Console.WriteLine(r3);

            PointR p4 = new Point4D { X = 1, Y = 2, Z = 3, CT = 4 };

            Console.WriteLine(p4);

            // Decomposition only provided automatically for positional record
            //var (x, y, _) = r3;

            //Console.WriteLine(x);
            //Console.WriteLine(y);
        }
    }
}
