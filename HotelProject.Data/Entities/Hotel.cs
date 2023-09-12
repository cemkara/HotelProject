public class Hotel{
    public int HotelId { get; set; }
    public string Name { get; set; }
    public Address Address { get; set; }
    public Status Status { get; set; }
    public string LogoUrl{ get; set;}
    public DateTime RecordDate { get; set; }
    
    public ICollection<HotelRoom> HotelRoom { get; set; }
    public ICollection<HotelPhoneNumber> HotelPhoneNumbers { get; set; }
    public ICollection<HotelEmail> HotelEmails { get; set; }
    public ICollection<HotelRestaurant> HotelRestaurants { get; set; }
    public ICollection<Order> Orders { get; set; }
    public ICollection<HotelCommission> HotelCommissions { get; set; }
    public ICollection<HotelCommissionEarning> HotelCommissionEarnings{get; set;}
    public ICollection<Transfer> Transfers { get; set; }
    public ICollection<MyUser> Users { get; set; }
}