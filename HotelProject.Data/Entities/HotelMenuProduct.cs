public class HotelMenuProduct
{
    public int HotelMenuProductId { get; set; }
    public HotelMenu HotelMenu { get; set; }
    public Product Product { get; set; }
    public decimal Price {get;set;}
    public decimal? DiscountRate { get; set; }
    public Status Status {get; set;}
}