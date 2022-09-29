using PcVerwaltung.Model.Enums;

namespace PcVerwaltung.Model

{
    public class Component
    {
        private string Id { get; set; }
        private string Name {get; set;}
        private EBrand Brand { get; set; }
        private string Descripton { get; set; }
        private double Price { get; set; }
        private double Stock { get; set; }

    }
}