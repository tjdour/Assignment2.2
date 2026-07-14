namespace Assignment2_2;
public class Workstation : Computer
{
    public string Gpu { get; set; }

    public Workstation(string brand, string os, int ramGb, string gpu)
        : base(brand, os, ramGb)
    {
        Gpu = gpu;
    }
}