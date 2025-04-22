namespace Netrunner.Signasl.Models;

public class TriangleSignals
{
    public DateTime Date { get; set; }
    public string Pair1 { get; set; } = string.Empty;
    public decimal Price1 { get; set; }
    public string Pair2 { get; set; } = string.Empty;
    public decimal Price2 { get; set; }
    public string Pair3 { get; set; } = string.Empty;
    public decimal Price3 { get; set; }
    public decimal MaxProfit { get; set; }
}

