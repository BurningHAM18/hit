using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExtractor;
using YoutubeSearch;

namespace YT2MP3
{
    class YoutubeVideo
    {
        VideoInformation info;
        string title = "";
        string duration = "";
        string url = "";

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string Duration
        {
            get
            {
                return duration;
            }

            set
            {
                duration = value;
            }
        }

        public string Url
        {
            get
            {
                return url;
            }

            set
            {
                url = value;
            }
        }

        public VideoInformation Info
        {
            get
            {
                return info;
            }

            set
            {
                info = value;
            }
        }

        public YoutubeVideo(VideoInformation info)
        {
            this.Info = info;
            this.Title = info.Title;
            this.Url = info.Url;
            this.Duration = info.Duration;
        }

        public YoutubeVideo(string title, string url)
        {
            this.Title = title;
            string nuurl = url;

            if (url.StartsWith("https://youtu.be/"))
            {
                nuurl = "https://www.youtube.com/watch?v=" + url.Substring("https://youtu.be/".Length);
                
            }
            this.Url = nuurl;
        }

        public override string ToString()
        {
            return Title + " - " + Duration;
        }

        public string GetThumbnail()
        {
            return Info.Thumbnail;
        }
    }
}
