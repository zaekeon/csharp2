using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTO_Tracker
{
    public class Person
    {
        public readonly List<OOTODay> _timeOff;
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            _timeOff = new List<OOTODay>();
        }

        public TimeSpan GetTotalTimeOff()
        {

            if (_timeOff == null)
            {
                System.Windows.MessageBox.Show("No time off has been entered");
                throw new InvalidOperationException();
            }

            TimeSpan totalTime = new TimeSpan();



            foreach (var item in _timeOff)
            {
                totalTime += item.Duration;
            }

            return totalTime;
        }

        public void AddTimeOff(double hours, string reason)
        {
            OOTODay ooto = new OOTODay(TimeSpan.FromHours(hours), reason, DateTime.Now);

            _timeOff.Add(ooto);
        }

        public List<OOTODay> GetOOTODays()
        {
            return _timeOff;
        }



            }
     
}
