using PcVerwaltung.Model.Enums;

namespace PcVerwaltung.Model

{
    public abstract class Component
    {
        public Component(int id, string name, EBrand brand, string description, double price, double stock)
        {
            Id = id;
            Name = name;
            Brand = brand;
            Description = description;
            Price = price;
            Stock = stock;
        }

        public abstract int CalcPerformanceIndex();
        
        
        public int Id { get; set; }
        public string Name {get; set;}
        public EBrand Brand { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double Stock { get; set; }

        
    }
    
    
}