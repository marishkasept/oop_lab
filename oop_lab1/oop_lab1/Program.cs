using System;
class Program
{
    static void Main(string[] args)
    {
        Bezier_curve curve = new Bezier_curve();
    }
}

public class Bezier_curve
{
    private static double[] factorial_list = new double[]
    {
    1.0,
    1.0,
    2.0,
    6.0
    };

    public static double binom_coef(int i)
    {
        double binom;
        double a1 = factorial_list[3];
        double a2 = factorial_list[i];
        double a3 = factorial_list[3 - i];
        binom = a1 / (a2 * a3);
        return binom;
    }

    public static double Bernstein(int i, double t)
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

    public static void Cubic_curve(double[] coordinates, int num_of_path_pts, double[] path_pts)
    {
        int icount, jcount;
        double step, t;

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
            path_pts[icount] = 0.0;
            path_pts[icount + 1] = 0.0;
            for (int i = 0; i != 4; i++)
            {
                double basis = Bernstein(i, t);
                path_pts[icount] += basis * coordinates[jcount];
                path_pts[icount + 1] += basis * coordinates[jcount + 1];
                jcount = jcount + 2;
            }

            icount += 2;
            t += step;
        }
    }
}