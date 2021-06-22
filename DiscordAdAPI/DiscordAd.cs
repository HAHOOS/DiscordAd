using System;
using Discord_Ad;

namespace DiscordAdAPI
{
    public class DiscordAd
    {
        public long ClientId { get; set; }
        public string Details { get; set; }
        public string State { get; set; }
        public string LargeImage_key { get; set; }
        public string LargeImage_text { get; set; }
        public string SmallImage_key { get; set; }
        public string SmallImage_text { get; set; }
        public bool Start_Time { get; set; }
        public void Stop()
        {
            
        }  

        

    }
}
