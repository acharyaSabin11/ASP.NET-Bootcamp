namespace Sabin.inheritance;

using Sabin.sync;

//Point 3d inherits from the point class form Sabin.sync
class Point3D: Point
{
    public int z;

    public Point3D(int x, int y, int z): base(x, y)
    {
        this.z = z;
    }

}