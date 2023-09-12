using Microsoft.AspNetCore.Identity;

public class MyUser : IdentityUser<int>
{
    public int MyUserId { get; set; }
    public string Name { get; set; }
    public int StatusId { get; set; }
    public int UserTypeId { get; set; }
    public Status Status { get; set; }
    public UserType UserType { get; set; }
    public DateTime LastLoginDate { get; set; }
    public DateTime RecordDate { get; set; }

    public ICollection<UserPhoneNumber> UserPhoneNumbers { get; set; }
    public ICollection<UserEmail> UserEmails { get; set; }
    public ICollection<Restaurant> Restaurants { get; set; }
    public ICollection<Hotel> Hotels { get; set; }
    public ICollection<DriverAssignment> DriverAssignments { get; set; }
}