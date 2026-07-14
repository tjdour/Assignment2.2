namespace Assignment2_2;

public class Computer
{
    public string Brand { get; set; }
    public string OS { get; set; }
    public int RamGb { get; set; }

    public Computer(string brand, string os, int ramGb)
    {
        Brand = brand;
        OS = os;
        RamGb = ramGb;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, OS: {OS}, RAM: {RamGb} GB");
    }
}