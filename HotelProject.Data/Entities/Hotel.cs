using System.ComponentModel.DataAnnotations;

public class Hotel
{
    [Key]
    public int HotelId { get; set; }

    [Required(ErrorMessage = "This field cannot be left blank.")]
    public string Name { get; set; }
    public Address Address { get; set; }
    public Status Status { get; set; }

    [Required(ErrorMessage = "This field cannot be left blank.")]
    public string LogoUrl { get; set; } = "unknow.png";
    public DateTime RecordDate { get; set; }

    public ICollection<HotelRoom> HotelRoom { get; set; }
    public ICollection<HotelPhoneNumber> HotelPhoneNumbers { get; set; }
    public ICollection<HotelEmail> HotelEmails { get; set; }
    public ICollection<HotelRestaurant> HotelRestaurants { get; set; }
    public ICollection<Order> Orders { get; set; }
    public ICollection<HotelCommission> HotelCommissions { get; set; }
    public ICollection<HotelCommissionEarning> HotelCommissionEarnings { get; set; }
    public ICollection<Transfer> Transfers { get; set; }
    public ICollection<MyUser> Users { get; set; }

    public Hotel()
    {
        Users = new List<MyUser>();
        HotelEmails = new List<HotelEmail>();
        HotelPhoneNumbers = new List<HotelPhoneNumber>();
    }
}