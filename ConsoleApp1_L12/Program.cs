using System;
using System.Globalization;
using System.Threading;

namespace AlarmApp
{
    // Define delegate for the event
    public delegate void AlarmEventHandler(object sender, EventArgs e);

    // Publisher class
    public class AlarmClock
    {
        public event AlarmEventHandler raiseAlarm; // Event declaration
        private TimeSpan targetTime;

        public AlarmClock(TimeSpan userTime)
        {
            targetTime = userTime;
        }

        // Check system time every second
        public void Start()
        {
            Console.WriteLine("Alarm is set for: " + targetTime);

            while (true)
            {
                TimeSpan currentTime = DateTime.Now.TimeOfDay;

                // Trimming to seconds only
                TimeSpan trimmedCurrentTime = new TimeSpan(currentTime.Hours, currentTime.Minutes, currentTime.Seconds);

                if (trimmedCurrentTime == targetTime)
                {
                    OnRaiseAlarm();
                    break;
                }

                Thread.Sleep(1000); // Wait for 1 second
            }
        }

        // Raise the alarm event
        protected virtual void OnRaiseAlarm()
        {
            if (raiseAlarm != null)
            {
                raiseAlarm(this, EventArgs.Empty); // Trigger event
            }
        }
    }

    // Subscriber class
    public class AlarmSubscriber
    {
        public void Ring_alarm(object sender, EventArgs e)
        {
            Console.WriteLine("Alarm ringing!");
        }
    }

    // Main program
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter target time (HH:MM:SS): ");
            string input = Console.ReadLine();

            TimeSpan userTime;

            while (!TimeSpan.TryParseExact(input, "c", CultureInfo.InvariantCulture, out userTime))
            {
                Console.WriteLine("Invalid format! Please enter time in HH:MM:SS format.");
                Console.Write("Enter target time (HH:MM:SS): ");
                input = Console.ReadLine();
            }

            AlarmClock alarmClock = new AlarmClock(userTime);
            AlarmSubscriber subscriber = new AlarmSubscriber();

            // Subscribe to the event
            alarmClock.raiseAlarm += subscriber.Ring_alarm;

            // Start the clock monitoring
            alarmClock.Start();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
