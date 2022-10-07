using PcVerwaltung.Model.Enums;

namespace PcVerwaltung.Model.Components;

public class Ram : Component
{
    public Ram(int id, string name, EBrand brand, string description, double price, double stock, int storageSize, EStorageUnit storageUnit, float frequency) : base(id, name, brand, description, price, stock)
    {
        StorageSize = storageSize;
        StorageUnit = storageUnit;
        Frequency = frequency;
    }

    private int StorageSize { get; set; }
    private EStorageUnit StorageUnit { get; set; }
    private float Frequency { get; set; }
    
    public override int CalcPerformanceIndex()
    {
        throw new System.NotImplementedException();
    }
}