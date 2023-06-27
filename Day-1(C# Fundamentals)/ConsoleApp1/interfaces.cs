using System.Xml.Serialization;

namespace Sabin.interfaces;

interface Icontrol
{
    void paint();
}

interface ItextBox: Icontrol    //inheriting the interfaces
{
    void setText(string text);
}

interface IListBox : Icontrol
{
    void setItems(string[] items);
}

interface IComboBox: ItextBox, IListBox{}   //this interface is a combo of all  the above mentioned interfaces.