namespace Assignment2_2;
public class Mobile : Computer
{
    public double ScreenSize { get; set; }

    public Mobile(
        string brand,
        string os,
        int ramGb,
        double screenSize)
        : base(brand, os, ramGb)
    {
        ScreenSize = screenSize;
    }
}