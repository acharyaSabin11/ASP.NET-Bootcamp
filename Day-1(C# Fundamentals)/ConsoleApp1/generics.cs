namespace Sabin.generics;

public class pair<TFirst, TSecond>
{
    public TFirst First { get; set; }
    public TSecond Second { get; set; }

    public pair(TFirst first, TSecond second)
    {
        (First, Second) = (first, second);  //records type
    }
}