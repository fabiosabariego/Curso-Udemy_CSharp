using System;
using System.Timers;

public class Example
{
    private static System.Timers.Timer aTimer;

    public static void Main()
    {
        SetTimer();

        Console.ReadLine();
        aTimer.Stop();
        aTimer.Dispose();

        Console.WriteLine("Terminating the application...");
    }

    private static void SetTimer()
    {
        // Create a timer with a two second interval.
        aTimer = new System.Timers.Timer(2000);
        // Hook up the Elapsed event for the timer. 
        aTimer.Elapsed += OnTimedEvent;
        aTimer.AutoReset = true;
        aTimer.Enabled = true;
    }

    private static void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        Console.WriteLine($"The Elapsed event was raised at {e.SignalTime}");
    }
}