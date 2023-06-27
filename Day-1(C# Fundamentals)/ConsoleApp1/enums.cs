namespace Sabin.enums;

public enum Seasons
{
    None,
    Summer,
    Autumn,
    Winter,
    Spring = 15, 
    All = Summer | Autumn | Winter | Spring
}