using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    static public class Squre
    {
        static public double Calculate(params double[] side)
        {
            switch (side.Length) 
            {
                case 1:
                    return CircleCalculate(side[0]);
                case 3:
                    return TriangleCalculate(side[0], side[1], side[2]);
                default:
                    return 0;
            }
        }

        static public double CircleCalculate(double radius)
        {
            if (IsShapeSidesExist(radius))
                return Math.PI * Math.Pow(radius, 2);
            return 0;
        }

        static public double TriangleCalculate(double firstSide, double secondSide, double thirdSide)
        {
            return 0;
        }

        static private bool IsShapeSidesExist(params double[] sides)
        {
            int sideCount = sides.Length;

            if (sideCount == 2)
                throw new Exception("A figure cannot consist of two sides");

            double sum = sides.Sum();

            if (IsSidesGreaterZero(sides))
            {
                if (sideCount == 1)
                    return true;

                foreach (var side in sides)
                {
                    if (side < (sum - side))
                        throw new Exception("There is no such figure.");
                }
            }
            return true;
        }

        static private bool IsSidesGreaterZero(params double[] sides)
        {
            foreach (var side in sides)
                if (side <= 0)
                    throw new Exception("Sides must have a value greater than zero");         
            return true;
        }
    }
}
