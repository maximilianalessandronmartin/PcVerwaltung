using System.Collections.Generic;

namespace PcVerwaltung.Model;

public class Customer
{
    public Customer(string id, string firstName, string lastName, string mail, List<InVoice> inVoices)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Mail = mail;
        InVoices = inVoices;
    }

    public string Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Mail { get; set; }
    public List<InVoice> InVoices { get; set; }
}