using System;

public class Bezier_curve
{
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
                double basis = Math_Utilities.Bernstein(i, t);
                path_pts[icount] = path_pts[icount] + basis * coordinates[jcount];
                jcount = jcount + 1;
            }

            icount += 1;
            t += step;
        }
    }
}