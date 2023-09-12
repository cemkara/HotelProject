public class NotificationLog
{
    public int NotificationLogID { get; set; }
    public NotificationLogType NotificationLogType { get; set; } 
    public string Message { get; set; }
    public DateTime SentDate { get; set; }

    public MyUser User { get; set; }
    public Hotel? Hotel { get; set; }
    public Restaurant? Restaurant { get; set; }
}




