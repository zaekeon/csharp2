using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class MailService
    {
    
        //so now we are creating the event handler based on the source.
        //other subscribers would have to match the delegate the same way
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("Sending mail message");
        }
    }
}
