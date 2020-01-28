using System;

public class TimelineEvent
{
    public string date { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public TimelineEvent[] children { get; set; }

    public DateTime Date => Convert.ToDateTime(date);

    public TimelineEvent(string date)
    {
        this.date = date;
        this.title = null;
        this.description = null;
        this.children = null;
    }

    public TimelineEvent(){}
}