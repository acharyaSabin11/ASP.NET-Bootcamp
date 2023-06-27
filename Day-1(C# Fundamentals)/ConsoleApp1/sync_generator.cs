namespace Sabin.sync;

class PointFactory {
    int _numPoints;
    public PointFactory(int numberOfPoints) { 
        _numPoints = numberOfPoints;
    }

    public IEnumerable<Point> createPoints()
    {
        var generator = new Random();
        for(int i = 0; i < _numPoints; i++)
        {
            Console.WriteLine($"Point {i}: ");
            yield return new Point(generator.Next()%1000, generator.Next()%1000);
        }
    }
}

class Point
    {
    public int x;
    public int y;
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    }
