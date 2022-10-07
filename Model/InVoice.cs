using System.Collections.Generic;

namespace PcVerwaltung.Model;

public class InVoice
{
    private string Number { get; set; }
    private List<Product> Products { get; set; }
    private string Total { get; set; }

    public InVoice(string number, List<Product> products, string total)
    {
        Number = number;
        Products = products;
        Total = total;
    }
}