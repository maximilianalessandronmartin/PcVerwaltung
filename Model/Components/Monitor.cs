using System;
using PcVerwaltung.Model.Enums;

namespace PcVerwaltung.Model.Components;

public class Monitor : Component
{
    public Monitor(int id, string name, EBrand brand, string description, double price, double stock, EMonitorType monitorType, ERefreshRate refreshRate) : base(id, name, brand, description, price, stock)
    {
        MonitorType = monitorType;
        RefreshRate = refreshRate;
    }

    private EMonitorType MonitorType { get; set; }
    private ERefreshRate RefreshRate { get; set; }

    public override int CalcPerformanceIndex()
    {
        throw new NotImplementedException();
    }
}