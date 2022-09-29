using System.Collections.Generic;

namespace PcVerwaltung.Model;

public class Product
{
    private string Id { get; set; }
    private string Name {get; set;}
    private string Descripton { get; set; }
    private List<Component> Components { get; set; }
    private double Price { get; set; }
    private double Stock { get; set; }
}