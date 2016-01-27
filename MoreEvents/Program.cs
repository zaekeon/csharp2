using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreEvents
{
    class Program
    {
        //this is not a good example.  these events/methods should be in a different class.
        public delegate void PriceChanged(object sender, PriceChangedEventArgs args);
        public event PriceChanged PriceChangedEvent;
        static void Main(string[] args)
        {
            Program bacon = new Program();

            bacon.PriceChangedEvent += bacon.PriceChangedEventSubscriber;

            //raise the event
            bacon.OnPriceChanged();
        }

        protected virtual void OnPriceChanged()
        {

            PriceChangedEventArgs args = new PriceChangedEventArgs(2, 4);
            if (PriceChangedEvent !=null)
            {
                PriceChangedEvent(this, args);
            }
        }

        public void PriceChangedEventSubscriber(object sender, PriceChangedEventArgs args)
        {
            Console.WriteLine("Old price was :" + args.LastPrice + " New price is: " + args.NewPrice);
        }
    }
}
