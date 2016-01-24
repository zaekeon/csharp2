using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class PhotoProcessor
    {
        //below is the actual delegate syntax.
        public delegate void PhotoFilterHandler(Photo photo);  //need define signature of method you're responsible for calling

        //we could use a generic delegate
        //no need to delcare
        //I put an example called SuperProcess


        public void Process(string path, PhotoFilterHandler filterHandler)
        {

            //built in delegates
            //System.Action - points to void method
            //System.Func<> - returns a value
            var photo = Photo.Load(path);
            filterHandler(photo);
            

            photo.Save();

            
       
        }

        public void SuperProces(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);
            filterHandler(photo);
        }
      
    }
}
