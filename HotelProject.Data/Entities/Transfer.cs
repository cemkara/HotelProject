public class Transfer
{
    public int TransferId { get; set; }
    public Hotel Hotel { get; set; }
    public HotelRoom HotelRoom { get; set; }
    public string TransferCompany { get; set; }
    public decimal TransferPrice {get; set;}
    public bool PaymentCompleted{ get; set;}
    public DateTime TransferTime { get; set; }
    public TransferStatus Status { get; set; }
    public DateTime RecordDate{ get; set; }
}