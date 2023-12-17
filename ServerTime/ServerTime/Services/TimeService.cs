using System;

// TimeService.cs implementation
public class TimeService : ITimeService
{
    public string GetCurrentTime()
    {
        return DateTime.UtcNow.ToString("HH:mm:ss");
    }
}
