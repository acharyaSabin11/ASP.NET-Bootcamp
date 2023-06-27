namespace Sabin.ClassInterface;

using Sabin.interfaces;

class InterfaceClass : IComboBox //Here the InterfaceClass must implement all the methods of the IcomboBox interface.
{
    public void paint()
    {
        Console.WriteLine("Paint Implemented");
    }

    public void setItems(string[] items)
    {
        Console.WriteLine("SetItems Implemented.");
    }

    public void setText(string text)
    {
        Console.WriteLine("SetText Implemented.");
    }
}