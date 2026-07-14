namespace Assignment2_2;

public class Embedded : Computer
{
    public string Purpose { get; set; }

    public Embedded(
        string brand,
        string os,
        int ramGb,
        string purpose)
        : base(brand, os, ramGb)
    {
        Purpose = purpose;
    }
}