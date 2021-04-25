using System;

public class Math_Utilities
{
    static public double factorial(int n)
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

    static public double binom_coef(int i)
    {
        double binom;
        double a1 = factorial(3);
        double a2 = factorial(i);
        double a3 = factorial(3 - i);
        binom = a1 / (a2 * a3);
        return binom;
    }

    static public double Bernstein(int i, double t)
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
}
