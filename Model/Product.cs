using System.Collections.Generic;

namespace PcVerwaltung.Model;

public class Product
{
    private string Id { get; } = null!;
    private string Name {get; set;}
    private string EProductType { get; set; }
    private string Description { get; set; }
    public List<Component> Components { get; set; }
    private double Price { get; set; }


    public Product(string id, string name, string eProductType, string description, List<Component> components, double price)
    {
        Id = id;
        Name = name;
        EProductType = eProductType;
        Description = description;
        Components = components;
        Price = price;
    }

    public Product(string name , string eProductType, string description, List<Component> components)
    {
        Name = name;
        EProductType = eProductType;
        Description = description;
        Components = components;
        
        
    }
}

