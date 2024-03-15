using System;
namespace md_01
{
    public class CalendarEvent
    {
        public string EventName;
        public DaysOfWeek EventDay;
        public CalendarEvent(string name, DaysOfWeek day)
        {
            EventName = name;
            EventDay = day;
        }
        public void PrintEventDetails()
        {
            Console.WriteLine($"Подія {EventName} відбудеться в день {EventDay}");
        }
    }
}
