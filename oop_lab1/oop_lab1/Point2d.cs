public class Point2d
{
    private double x;
    private double y;
    public Point2d(double x = 0.0, double y = 0.0)
    {
        this.x = x;
        this.y = y;
    }
    public static Point2d operator *(double c1, Point2d c2)
    {
        Point2d point = new Point2d();
        point.x = c1 * c2.x;
        point.y = c1 * c2.y;
        return point;
    }

    public static Point2d operator +(Point2d c1, Point2d c2)
    {
        Point2d point = new Point2d();
        point.x = c1.x + c2.x;
        point.y = c1.y + c2.y;
        return point;
    }

    public static Point2d operator -(Point2d c1, Point2d c2)
    {
        Point2d point = new Point2d();
        point.x = c1.x - c2.x;
        point.y = c1.y - c2.y;
        return point;
    }
    public static bool operator >(Point2d c1, double c2)
    {
        Point2d point = new Point2d();
        return ((point.x > c2) && (point.y > c2));
    }

    public static bool operator <(Point2d c1, double c2)
    {
        Point2d point = new Point2d();
        return ((point.x < c2) && (point.y < c2));
    }

    public static Point2d Abs(Point2d c1)
    {
        Point2d point = new Point2d();
        if (c1.x < 0 || c1.x == 0)
        {
            point.x = -c1.x;
        }
        if (c1.y < 0 || c1.y == 0)
        {
            point.y = -c1.y;
        }
        return point;
    }
}