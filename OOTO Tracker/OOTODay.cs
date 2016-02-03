using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTO_Tracker
{
    public class OOTODay
    {
        

        public TimeSpan Duration { get; set; }
        public string Reason { get; set; }

        public DateTime Date { get; set; }

        public OOTODay(TimeSpan durationOfLeave, string reason, DateTime date)
        {
            Duration = durationOfLeave;
            Reason = reason;
            Date = date;

}

    }
}
