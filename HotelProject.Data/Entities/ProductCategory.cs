public class ProductCategory{
    public int ProductCategoryId{ get; set; }
    public string Name { get; set; }
    public Status Status {get; set;}
    public int OrderNumber {get; set;}
    public string ImageUrl {get; set;}

    public ICollection<Product> Products { get; set; }
}