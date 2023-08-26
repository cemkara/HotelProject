public class Hotel(){
    public int HotelId { get; set; }
    public string Name { get; set; }
    public Address Address { get; set; }
    public User ResponsibleUser { get; set; }
    public Status Status { get; set; }
    public string LogoUrl{ get; set;}
    public Datetime RecordDate { get; set; }
    
    public IList<HotelRoom> HotelRoom { get; set; }
    public IList<HotelPhoneNumber> HotelPhoneNumbers { get; set; }
    public IList<HotelEmail> HotelEmails { get; set; }
    public IList<HotelRestaurant> HotelRestaurants { get; set; }
    public IList<Order> Orders { get; set; }
    public IList<HotelCommission> HotelCommissions { get; set; }
    public IList<HotelCommissionEarning> HotelCommissionEarnings{get; set;}
    public IList<Transfer> Transfers { get; set; }
    public IList<User> Users { get; set; }
}