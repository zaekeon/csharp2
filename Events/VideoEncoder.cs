using System;
using System.Threading;

namespace Events
{
    public class VideoEncoder
    {
        public VideoEncoder()
        {
        }




        //step 1 - declaring a delegate which holds a reference to a function that looks like it's signature.
        //
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        //step 2 - the event

        public event VideoEncodedEventHandler VideoEncoded;  //so here you're creating an event of the delegate type you created above...like an object sort of.


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded();
        }

        //step 3

        protected virtual void OnVideoEncoded()
        {
            //this method is responsble for notifying the subscribers

            if (VideoEncoded != null)
                {
                VideoEncoded(this, EventArgs.Empty);  //if you dont' want to send any event data you use the EventArgs.Empty.
            }
        }
    }
}

//three steps
// 1-define a delegate (determines signature of method and subscriber that will be called)
// 2-define an event based on that delegate
// 3-raise the event
//4-create your subscribers(the class/object that's going to call) and their event handlers (they must match the delegate)
//5-subscribe the subscribers to the event


    //to make things simpler...you don't have to create a delegate and event anymore..there are now these types
    //EvenHandler
    //Eventhandler<TEventArgs>

    //We can use those instead of creating our own.
    //you would still create the event, just not the delegate...so look below:

    //public event EventHandler<VideoEventArgs> VideoEncoded;

    //for an event with no data
    //public event EventHander VideoEncoded;

