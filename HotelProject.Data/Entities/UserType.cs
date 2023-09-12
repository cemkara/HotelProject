using System.ComponentModel.DataAnnotations;

public class UserType
{
    [Key]
    public int UserTypeId { get; set; }
    public string Name { get; set; }
    //Admin = 1,
    //HotelUser = 2,
    //RestourantUser = 3,
    //DeliveryDriver = 4
}