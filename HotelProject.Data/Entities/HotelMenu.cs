public class HotelMenu
{
    public int HotelMenuId { get; set; }
    public string MenuName { get; set; }
    public Hotel Hotel { get; set; }
    public IList<HotelMenuProduct> MenuProducts { get; set; }
}