using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class YouTubeAPI
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                // Access YouTube web serivce
                // Read the data
                // Create a list of video objects
                throw new Exception("Oops some low level YouTube error.");
            }
            catch(Exception ex)
            {
                // Log
                
                throw new YouTubeException("Could not fetch the videos from Youtube", ex);
            }

            return new List<Video>();
        }
    }
}
