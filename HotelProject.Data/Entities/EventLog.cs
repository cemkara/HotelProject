public class EventLog
{
    public int EventLogID { get; set; }
    public EventType EventType { get; set; }
    public string Description { get; set; }
    public DateTime LogDate { get; set; }
    
    public Hotel? Hotel { get; set; }
    public MyUser? User { get; set; }
    public Restaurant? Restaurant { get; set; }
}