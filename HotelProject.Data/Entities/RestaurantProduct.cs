public class RestaurantProduct
{
    public int RestaurantProductId{get; set;} 
    public Restaurant Restaurant { get; set; }
    public Product Product { get; set; }
}