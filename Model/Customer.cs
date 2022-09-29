using System.Collections.Generic;

namespace PcVerwaltung.Model;

public class Customer
{
    private string Id { get; set; }
    private string FirstName { get; set; }
    private string LastName { get; set; }
    private string Mail { get; set; }
    private List<InVoice> InVoices { get; set; }
}