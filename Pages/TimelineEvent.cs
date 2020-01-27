using System;

public class TimelineEvent
{
    public string date { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public TimelineEvent[] children { get; set; }

    public DateTime Date => Convert.ToDateTime(date);
}