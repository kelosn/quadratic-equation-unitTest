 using System;

namespace QuadraticEquationSolver
{
    public class QuadraticEquation
    {
        public static (double?, double?) Solve(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                return (null, null);
            }
            else if (delta == 0)
            {
                double root = -b / (2 * a);
                return (root, null);
            }
            else
            {
                double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return (root1, root2);
            }
        }
    }
}
