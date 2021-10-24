using System;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;

class Class1
{
    static void Main()
    {
        string ScheduledTime = System.Configuration.ConfigurationManager.AppSettings["ScheduledTime"];
        string[] ScheduledTimeParts = ScheduledTime.Split(new char[1] { ':' });

        Console.WriteLine("The Scheduled time for the Function --> {0}", ScheduledTime);

        while (true)
        {
            DateTime currentDate = DateTime.Now;

            DateTime ScheduledDateTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, int.Parse(ScheduledTimeParts[0]), int.Parse(ScheduledTimeParts[1]), int.Parse(ScheduledTimeParts[2]));

            TimeSpan ts;

            if (ScheduledDateTime > currentDate)
                ts = ScheduledDateTime - currentDate;
            else
            {
                ScheduledDateTime = ScheduledDateTime.AddDays(1);
                ts = ScheduledDateTime - currentDate;
            }

            Task.Delay(ts).Wait();
            DisplayMessage();


        }
        Console.Read();
    }

    static void DisplayMessage()
    {
        Console.WriteLine("***********Method is called at {0}***********",DateTime.Now);
    }
}

