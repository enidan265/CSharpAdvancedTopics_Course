using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    // E-Mail schicken, wenn das Video encoded ist 
    public class MailService
    {
        // Methode, die zu Signatur des Delegates passt 
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"MailService: Sending an email... {e.Video.Title}");
        }
    }
}
