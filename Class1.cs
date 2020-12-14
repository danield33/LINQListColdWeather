using System;
using System.Collections.Generic;
using System.Text;

namespace LINQListColdWeather {
    class Weather {

        public DayOfWeek Day{ get; set; }
        public int HighTemp { get; set; }
        public int LowTemp { get; set; }

        public Weather(DayOfWeek day, int high, int low) {
            this.Day = day;
            this.HighTemp = high;
            this.LowTemp = low;
        }

    }
}
