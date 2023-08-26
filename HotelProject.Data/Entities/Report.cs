public class Report
{
    public int ReportId { get; set; }
    public ReportType ReportType { get; set; }
    public ReportDuration ReportDuration { get; set; }
    public DateTime ReportDate { get; set; }
    public string FilePath { get; set; } 

    public Hotel? Hotel { get; set; } 
    public Restaurant? Restaurant { get; set; } 
    public Transfer? Transfer { get; set; } 
    public Product? Product { get; set; } 
    public HotelMenu? HotelMenu { get; set; }
}