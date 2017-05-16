using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                return RemoveIllegalPathCharacters(title);
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
            this.Title = RemoveIllegalPathCharacters( info.Title);
            this.Url = info.Url;
            this.Duration = info.Duration;
        }

        public YoutubeVideo(string title, string url)
        {
            this.Title = RemoveIllegalPathCharacters(title);
            string nuurl = url;

            if (url.StartsWith("https://youtu.be/"))
            {
                nuurl = "https://www.youtube.com/watch?v=" + url.Substring("https://youtu.be/".Length);
                
            }
            this.Url = nuurl;
        }

        private static string RemoveIllegalPathCharacters(string path)
        {
            string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            var r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
            return r.Replace(path, "");
        }

        public override string ToString()
        {
            return RemoveIllegalPathCharacters(Title) + " - " + Duration;
        }

        public string GetThumbnail()
        {
            return Info.Thumbnail;
        }
    }
}
