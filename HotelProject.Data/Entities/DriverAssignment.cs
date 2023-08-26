public class DriverAssignment
{
    public int DriverAssignmentId { get; set; }
    public DateTime AssignmentDate { get; set; }
    public Order Order { get; set; }
    public User DeliveryUser { get; set; }
}