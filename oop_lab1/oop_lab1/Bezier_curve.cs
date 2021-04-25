using System;

public class Bezier_curve
{
    static private double factorial(int n)
    {
        if (n <= 0)
        {
            return 1;
        }
        else
        {
            return n * factorial(n - 1);
        }
    }

    static public double get_factorial(int n)
    {
        return factorial(n);
    }

    static private double binom_coef(int i)
    {
        double binom;
        double a1 = factorial(3);
        double a2 = factorial(i);
        double a3 = factorial(3 - i);
        binom = a1 / (a2 * a3);
        return binom;
    }

    static public double get_binom_coef(int n)
    {
        return binom_coef(n);
    }

    static private double Bernstein(int i, double t)
    {
        double basis;
        double ti;
        double tni;
        if (t == 0.0 && i == 0)
            ti = 1.0;
        else
            ti = Math.Pow(t, i);

        if (i == 3 && t == 1.0)
            tni = 1.0;
        else
            tni = Math.Pow((1 - t), (3 - i));
        basis = binom_coef(i) * ti * tni;
        return basis;
    }

    static public double get_Bernstein(int i, double t)
    {
        return Bernstein(i, t);
    }

    public void Cubic_curve(Point2d[] coordinates, int num_of_path_pts, Point2d[] path_pts)
    {
        int icount, jcount;
        double step, t;
        Point2d zero_point = new Point2d(0.0, 0.0);

        icount = 0;
        t = 0;
        step = (double)1.0 / (num_of_path_pts - 1);

        for (int k = 0; k != num_of_path_pts; k++)
        {
            if ((1.0 - t) < 0.000005)
            {
                t = 1.0;
            }

            jcount = 0;
            path_pts[icount] = zero_point;
            for (int i = 0; i != 4; i++)
            {
                double basis = Bernstein(i, t);
                path_pts[icount] = path_pts[icount] + basis * coordinates[jcount];
                jcount = jcount + 1;
            }

            icount += 1;
            t += step;
        }
    }
}