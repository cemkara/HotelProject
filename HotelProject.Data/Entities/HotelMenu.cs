public class HotelMenu
{
    public int HotelMenuId { get; set; }
    public string MenuName { get; set; }
    public Hotel Hotel { get; set; }
    public ICollection<HotelMenuProduct> MenuProducts { get; set; }
}