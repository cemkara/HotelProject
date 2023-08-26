public class Review
{
    public int ReviewId { get; set; }
    public Rating Rating { get; set; } 
    public string Comment { get; set; } 
    public DateTime ReviewDate { get; set; }
    
    public Order Order { get; set; }
}