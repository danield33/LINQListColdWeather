using System;
using System.Linq;
using System.Collections.Generic;
namespace LINQListColdWeather {
    class Program {

        static void Main(string[] args) {

            List<Weather> daysForcasted = new List<Weather>();
            daysForcasted.Add(new Weather(DayOfWeek.Tue, 32, 26));
            daysForcasted.Add(new Weather(DayOfWeek.Wed, 37, 28));
            daysForcasted.Add(new Weather(DayOfWeek.Thu, 37, 29));
            daysForcasted.Add(new Weather(DayOfWeek.Fri, 39, 29));
            daysForcasted.Add(new Weather(DayOfWeek.Sat, 42, 34));

            var coldDays = from day in daysForcasted
                           where day.HighTemp < 40
                           select day;

            foreach(var day in coldDays) {
                Console.WriteLine("Cold weather on " + day.Day);
            }

        }
    }

    public enum DayOfWeek {
        Sun = 0,
        Mon = 1,
        Tue,
        Wed,
        Thu,
        Fri,
        Sat
    }

}
