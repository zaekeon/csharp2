using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            //EVENTS

            //a mechanism for communication between objects...it can notify objects something has happened.
            //used in building loosely coupled applications
            //helps extending applications

            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder();  //this is the publisher
            var mailService = new MailService(); //this is the subscriber
            var messageService = new MessageService();

            //call and create the subscription
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}
