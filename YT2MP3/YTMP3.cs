
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;
using YoutubeSearch;

namespace YT2MP3
{
    public partial class YTMP3 : Form
    {
        private string directoryPath = "";
        private static int version = 2;
        private static ProgressBar p;

        public YTMP3()
        {
            InitializeComponent();
            brain b = new YT2MP3.brain(this);
        }

        private void eraseContent(object sender, EventArgs e)
        {
            if(URL.Text.Equals("Paste URL here")) brain.eraseText(URL);
        }

        private void selectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dir = new FolderBrowserDialog();

            if (dir.ShowDialog() == DialogResult.OK)
            {
                directoryPath = dir.SelectedPath;
                directory.Enabled = false;
                directory.Text = directoryPath;
            }
        }

        private void r_button_Click(object sender, EventArgs e)
        {
            object selected = URLS.SelectedItem;
            if (selected == null)
            {
                MessageBox.Show("Cannot remove the void, man");
            }
            else
            {
                URLS.Items.Remove(selected);
            }
        }

        private void d_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (directoryPath.Equals("")) MessageBox.Show("Cannot download into the void, man");
                else if (URLS.Items.Count == 0) MessageBox.Show("Cannot download the void, man");
                else
                {
                    MessageBox.Show("Have a sit and take a coffee, man");
                    foreach (YoutubeVideo item in URLS.Items)
                    {
                        string link = item.Url;

                        IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(link, false);

                        VideoInfo video = videoInfos.First(info => info.VideoType == VideoType.Mp4); // youtube gives always mp4
                       /* if (video.RequiresDecryption)
                        {
                            DownloadUrlResolver.DecryptDownloadUrl(video);
                        }*/
                        //DownloadAudio(videoInfos, directoryPath, progress);

                        WebClient wc = new WebClient();
                        string tempF = directoryPath + "\\Downloaded\\";
                        if (!Directory.Exists(tempF)) Directory.CreateDirectory(tempF);

                        wc.DownloadProgressChanged += gestoreBarra;
                        wc.DownloadFileAsync(new Uri(string.Format("http://www.youtubeinmp3.com/fetch/?video={0}", link)), tempF + video.Title + ".mp3");

                    }
                    //MessageBox.Show("Download finished, man");
                }
            }catch
            {
                MessageBox.Show("Invalid URL, man");
            }
            URLS.Items.Clear();
        }

        private void gestoreBarra(object sender, DownloadProgressChangedEventArgs e)
        {
            progress.Value= e.ProgressPercentage;
        }


        /*
        private static void DownloadAudio(IEnumerable<VideoInfo> videoInfos, string dir, ProgressBar progress)
        {

            p = progress;

            
            VideoInfo video = videoInfos.First(info => info.VideoType == VideoType.Mp4); // youtube gives always mp4
            if (video.RequiresDecryption)
            {
                DownloadUrlResolver.DecryptDownloadUrl(video);
            }

            string tempF =dir + "\\Downloaded";
            if (!Directory.Exists(tempF)) Directory.CreateDirectory(tempF);

            var videoDownloader = new VideoDownloader(video, Path.Combine(dir+ "/Downloaded", video.Title + video.AudioExtension));
            videoDownloader.DownloadStarted += progress_zero;
            videoDownloader.DownloadProgressChanged += pregress_changed;
            videoDownloader.DownloadFinished += progress_full;
            videoDownloader.Execute();

            // Convert mp4 to mp3
            // -------------------
            var inputFile = new MediaFile { Filename = Path.Combine(dir + "/Downloaded", video.Title + video.AudioExtension) };
            var outputFile = new MediaFile { Filename = Path.Combine(dir + "/Downloaded", video.Title + ".mp3") };
            progress.Value = 0;
            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);
                progress.Value = 70;
                engine.Convert(inputFile, outputFile);
                progress.Value = 100;
            }
            File.Delete(Path.Combine(dir + "/Downloaded", video.Title + video.AudioExtension));
            
        }

        private static void progress_full(object sender, EventArgs e)
        {
            p.Value = 100;
        }

        private static void pregress_changed(object sender, ProgressEventArgs e)
        {
            if(p.Value<100) p.Value ++;
        }

        private static void progress_zero(object sender, EventArgs e)
        {
            p.Value = 0;
        }
        */

        private void a_button_Click(object sender, EventArgs e)
        {
            if (URL.Text.Equals("") || URL.Text.Equals("Paste URL here"))
            {
                MessageBox.Show("No URL here, man");
                
            }
            else
            {
                string[] targets = URL.Lines;
                string rejected = "";
                foreach (string target in targets)
                {
                    if (!target.Equals("") && (target.Contains("youtube") || target.Contains("youtu.be")) && target.Contains("http"))
                    {
                        IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(target, false);
                        VideoInfo video = videoInfos.First(info => info.VideoType == VideoType.Mp4); // youtube gives always mp4

                        YoutubeVideo add = new YoutubeVideo(video.Title, target);
                        URLS.Items.Add(add);
                    }
                    else rejected += target + "\n";
                }
                URL.Text = rejected;
            }
            
        }



        private static string RemoveIllegalPathCharacters(string path)
        {
            string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            var r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
            return r.Replace(path, "");
        }

       

        private void u_button_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] b_version_local = Encoding.UTF8.GetBytes(YT2MP3.Properties.Resources.version);
                WebClient client = new WebClient();
                //byte[] host2 = 
                client.DownloadFile("https://raw.githubusercontent.com/BurningHAM18/yt2mp3/master/YT2MP3/version.txt","wversion.txt");
                
                byte[] bytes = System.IO.File.ReadAllBytes("wversion.txt");


                if (b_version_local[0]==bytes[3]) MessageBox.Show("You have the last version, man");
                else MessageBox.Show("Found new version, go to my GitHub, man");

                File.Delete("wversion.txt");
            }
            catch(Exception e3)
            {
                MessageBox.Show("Error, enjoy this version, man");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            System.Diagnostics.Process.Start("https://github.com/BurningHAM18");

        }

        private void s_button_Click(object sender, EventArgs e)
        {
            if (tosearch.Text == "") return;

            risultati.Items.Clear();
            YoutubeSearch.VideoSearch search = new VideoSearch();
            List<VideoInformation> results;
            results = search.SearchQuery(tosearch.Text, 3);
            foreach(VideoInformation infos in results)
            {
                risultati.Items.Add(new YoutubeVideo(infos));
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/cttynul");

        }

        private void c_butt_Click(object sender, EventArgs e)
        {
            risultati.Items.Clear();
            panel1.BackgroundImage = null;
            Search.BackgroundImage = null;
        }

        private void add_butt_Click(object sender, EventArgs e)
        {
            if (risultati.SelectedItem == null) ;
            else URLS.Items.Add(risultati.SelectedItem);
        }

        private void enterpressed(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                s_button_Click(sender, e);
            }
        }

        private void mostrathumbnail(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            byte[] thumb = wc.DownloadData(((YoutubeVideo)risultati.SelectedItem).GetThumbnail());
            Image img = byteArrayToImage(thumb);
            Bitmap background = new Bitmap(img, new Size(747, 413));
            Bitmap pannello = new Bitmap(img, new Size(323, 262));
            Search.BackgroundImage=background;
            panel1.BackgroundImage=pannello;

            
        }

        private void mouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (risultati.SelectedItem == null) ;
            else URLS.Items.Add(risultati.SelectedItem);
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
                ms.Write(byteArrayIn, 0, byteArrayIn.Length);
                Image returnImage = Image.FromStream(ms, true);
                return returnImage;
            }
            catch { }
            return null;
        }
    }
}