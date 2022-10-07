using PcVerwaltung.Model.Enums;

namespace PcVerwaltung.Model.Components;

public class Storage: Component
{
    public Storage(int id, string name, EBrand brand, string description, double price, double stock, EStorageType storageType,int size, int readSpeed, int writeSpeed) : base(id, name, brand, description, price, stock)
    {
        StorageType = storageType;
        Size = size;
        ReadSpeed = readSpeed;
        WriteSpeed = writeSpeed;
    }

    private EStorageType StorageType { get; set; }
    private int Size { get; set; }
    private int ReadSpeed { get; set; }
    private int WriteSpeed { get; set; }
    
    public override int CalcPerformanceIndex()
    {
        throw new System.NotImplementedException();
    }
}