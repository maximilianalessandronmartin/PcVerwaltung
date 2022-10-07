using PcVerwaltung.Model.Enums;

namespace PcVerwaltung.Model.Components;

public class Cpu : Component
{
    public Cpu(int id, string name, EBrand brand, string description, double price, double stock, float frequency, ESocket socket) : base(id, name, brand, description, price, stock)
    {
        Frequency = frequency;
        Socket = socket;
    }
    public float Frequency { get; set; }
    public ESocket Socket { get; set; }


    public override int CalcPerformanceIndex()
    {
        throw new System.NotImplementedException();
    }
}