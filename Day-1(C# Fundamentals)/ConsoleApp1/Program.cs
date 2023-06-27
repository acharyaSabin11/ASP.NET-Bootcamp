using Sabin.sync;
using Sabin.generics;
using Sabin.inheritance;
using Sabin.interfaces;

class Program
{
    public static void Main()
    {
        var s = new Sabin.Collections.Stack<int>();
        s.Push(1);
        s.Push(10);
        s.Push(100);
        Console.WriteLine(s.pop());
        Console.WriteLine(s.pop());
        Console.WriteLine(s.pop());

        Console.WriteLine("Generator(Iterator) Started");
        PointFactory factory = new PointFactory(10);
        Point point = new Point(1, 3);        
        for(int i = 0; i < 5; i++)
        {
            point = factory.createPoints().ElementAt(i);
            Console.WriteLine($"({point.x}, {point.y})");
        }

        //Generics
        var pair = new pair<int, String>(1, "One");
        Console.WriteLine(pair.First);
        Console.WriteLine(pair.Second);

        //Inheritance
        Point3D point3d = new Point3D(1, 2, 3);
        Console.WriteLine($"x: {point3d.x}, y: {point3d.y}, z: {point3d.z}");

        //Example that there is an implicit conversion from a derived class to its base class. This is possible because a derived class contains all the elements of a base class so a base class can be constructed from that.
        Point a = new Point(1, 1);
        Point b = new Point3D(1, 5, 3); //Point3D class object is implicitly converted to Point class object
        Console.WriteLine($"({b.x}, {b.y})");

        //struct
        var pointNew = new Sabin.structure.Point(1, 2);
        Console.WriteLine($"x: {pointNew.X}, y: {pointNew.Y}");

        //Interfaces Implemented Class
        Sabin.ClassInterface.InterfaceClass interfaceObject = new Sabin.ClassInterface.InterfaceClass();
        interfaceObject.paint();
        interfaceObject.setText("Sabin");
        string[] strings = { "Sabin", "bro" };
        interfaceObject.setItems(strings);


        //Example that the class implementing an interface is implicitly convertible to the Interface.
        Icontrol icontrol = new Sabin.ClassInterface.InterfaceClass();
        icontrol.paint();   //if we see implementation of the class IControl interface's paint method, it is empty but as it is object implicitly converted from the InterfaceClass, the implementation of paint from the InterfaceClass is copied to the iControl object.

        //enums
        Sabin.enums.Seasons enumTest = Sabin.enums.Seasons.Spring;
        Console.WriteLine(enumTest);

        //Nullable types
        int? nullableInt = default;
        Console.WriteLine(nullableInt);

        //tuples: provides concise syntax to group multiple data elements in a lightweight data structure. 
        (double Sum, int Count) t2 = (4.5, 3);
        Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");

    }
}