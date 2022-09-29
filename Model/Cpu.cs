using PcVerwaltung.Model.Enums;
namespace PcVerwaltung.Model;

public class Cpu : Component
{
    private float Frequency { get; set; }
    private ESocket Socket { get; set; }
}