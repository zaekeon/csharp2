using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                //access youtube web service
                //read the data
                //create a list of video objects
                throw new Exception("Oops some low level YouTube Error");
            }
            catch (Exception ex)
            {

                //log
                throw new  YouTubeException("Could not fetch the videos from Youtube", ex);  //you pass the inner exception (original one) usually for torubleshooting.
                //we just created a new exception class that inherited from exception and had the constructor and send to base class.
            }  

            return new List<Video>();

        }

    }
}
