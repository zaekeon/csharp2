using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class MessageService
    {

        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("Sending message from message server");
        }
    }
}
