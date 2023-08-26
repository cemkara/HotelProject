public class Product{
    public int ProductId{ get; set; }
    public string Name{ get; set; }
    public string Description{ get; set; }
    public string AllergenWarning{ get; set; }
    public string ImageUrl{ get; set; }
    public float Price { get; set; }
    public Status Status {get; set;}
    public ProductCategory ProductCategory {get; set;}
    public DateTime RecordDate {get;set;}

    public IList<RestaurantProduct> RestaurantProducts { get; set; }
    public IList<HotelMenuProduct> HotelMenuProducts { get; set; }
}