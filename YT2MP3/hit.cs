
using _hit_;
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
        private string directorySongsPath = "";
        private static int version = 3;
        private static ProgressBar p;
        private int count = 0;

        //


        private int index=0;
        private bool paused=false;
        private bool shuffleEnabled = false;
        private bool repeatOne = false;

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
                directory.Text = directoryPath+"\\Dowloaded";
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
                    count = URLS.Items.Count;
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
                        wc.DownloadFileCompleted += decreasecount;
                        //string nome = tempF + video.Title.Normalize();
                        string nome = tempF + RemoveIllegalPathCharacters(video.Title);

                        wc.DownloadFileAsync(new Uri(string.Format("http://www.youtubeinmp3.com/fetch/?video={0}", link)), nome + ".mp3");

                        
                    }
                    //MessageBox.Show("Download finished, man");
                }
            }catch
            {
                MessageBox.Show("Invalid URL, man");
            }
            URLS.Items.Clear();
        }

        private void decreasecount(object sender, AsyncCompletedEventArgs e)
        {
            count--;
            if(count==0) MessageBox.Show("Download finished, man");
        }

        private void gestoreBarra(object sender, DownloadProgressChangedEventArgs e)
        {
            progress.Value = e.ProgressPercentage;
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
                byte[] b_version_local = Encoding.UTF8.GetBytes(_hit_.Properties.Resources.version);
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
            /* DEPRECATO */
            WebClient wc = new WebClient();
            byte[] thumb = wc.DownloadData(((YoutubeVideo)risultati.SelectedItem).GetThumbnail());
            Image img = byteArrayToImage(thumb);
            Bitmap background = new Bitmap(img, new Size(747, 413));
            Bitmap pannello = new Bitmap(img, new Size(323, 262));
            Search.BackgroundImage=background;
            panel1.BackgroundImage=pannello;
            

            YoutubeVideo selected = (YoutubeVideo)risultati.SelectedItem;

            if (player1.playlist.isPlaying) player1.playlist.stop();
            player1.playlist.items.clear();
            player1.playlist.add(selected.Url);


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
        

        private void selectSongsPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dir = new FolderBrowserDialog();

            if (dir.ShowDialog() == DialogResult.OK)
            {
                directorySongsPath = dir.SelectedPath;
                songsPath.Enabled = false;
                songsPath.Text = directorySongsPath;
                loadSongs(songsPath.Text);
            }
        }

        private void loadSongs(string songsPath)
        {
            string[] files = Directory.GetFiles(songsPath);
            foreach(string s in files)
            {
                if (s.EndsWith(".mp3"))
                {
                    Song song = new _hit_.Song(Path.GetFileNameWithoutExtension(s), "file:///"+s);
                    songs.Items.Add(song);
                }
            }
            if (songs.Items.Count > 0)
            {
                play.Enabled = true;
                pause.Enabled = true;
                next.Enabled = true;
                previous.Enabled = true;
                shuffle.Enabled = true;
                repeat.Enabled = true;
            }
        }

        private void vlc_play(string url)
        {
            if (player2.playlist.isPlaying) player2.playlist.stop();
            player2.playlist.items.clear();
            player2.playlist.add(url);
            player2.playlist.play();
        }


        private void playSong(object sender, EventArgs e)
        {
            index = songs.SelectedIndex;
            Song selected = (Song)songs.SelectedItem;
            playingsong.Text = selected.Name;
            vlc_play(selected.Url);
            playingsong.Text = selected.Name;
        }

        private void resetLablePlaying(object sender, EventArgs e)
        {
            //playingsong.Text = "(none)";
        }

        private void SongEnded(object sender, EventArgs e)
        {
            if (repeatOne == false && shuffleEnabled == false) index++;
            else if (repeatOne == false && shuffleEnabled == true)
            {
                Random r = new Random();
                do { index = r.Next(0,songs.Items.Count); }
                while (index >= songs.Items.Count);
            }
            if (index < songs.Items.Count)
            {
                Song selected = (Song)songs.Items[index];
                songs.SelectedIndex = index;
                playingsong.Text = selected.Name;
                vlc_play(selected.Url);
                playingsong.Text = selected.Name;
            }
            else
            {
                index = 0;
                Song selected = (Song)songs.Items[0];
                songs.SelectedIndex = 0;
                playingsong.Text = selected.Name;
                vlc_play(selected.Url);
                playingsong.Text = selected.Name;
            }
        }

        private void reloadSong(object sender, MouseEventArgs e)
        {
            index = songs.SelectedIndex;
            Song selected = (Song)songs.SelectedItem;
            playingsong.Text = selected.Name;
            vlc_play(selected.Url);
            playingsong.Text = selected.Name;
        }

        private void previousSong(object sender, MouseEventArgs e)
        {
            index--;
            if (index >= 0)
            {
                Song selected = (Song)songs.Items[index];
                songs.SelectedIndex = index;
                playingsong.Text = selected.Name;
                vlc_play(selected.Url);
                playingsong.Text = selected.Name;
            }
            else
            {
                index = 0;
                Song selected = (Song)songs.Items[0];
                songs.SelectedIndex = index;
                playingsong.Text = selected.Name;
                vlc_play(selected.Url);
                playingsong.Text = selected.Name;
            }
        }

        private void playSong(object sender, MouseEventArgs e)
        {
            if (paused == false)
            {
                if(player2.playlist.isPlaying) player2.playlist.stop();

                if (songs.SelectedItem != null)
                {
                    index = songs.SelectedIndex;
                    Song selected = (Song)songs.SelectedItem;
                    playingsong.Text = selected.Name;
                    vlc_play(selected.Url);
                    playingsong.Text = selected.Name;
                }
                else
                {
                    index = 0;
                    Song selected = (Song)songs.Items[index];
                    songs.SelectedIndex = index;
                    playingsong.Text = selected.Name;
                    vlc_play(selected.Url);
                    playingsong.Text = selected.Name;
                }
            }
            else
            {
                player2.playlist.togglePause();
                paused = false;
            }
        }

        private void pauseSong(object sender, MouseEventArgs e)
        {
            paused = true;
            player2.playlist.pause();
        }

        private void nextSong(object sender, MouseEventArgs e)
        {

            if (shuffleEnabled==false) index++;
            else if(shuffleEnabled == true)
            {
                Random r = new Random();
                do { index = r.Next(0,songs.Items.Count); }
                while (index >= songs.Items.Count);
            }
            if (index < songs.Items.Count)
            {
                
                Song selected = (Song)songs.Items[index];
                songs.SelectedIndex = index;
                playingsong.Text = selected.Name;
                vlc_play(selected.Url);
                playingsong.Text = selected.Name;
            }
            else
            {
                index = 0;
                Song selected = (Song)songs.Items[index];
                songs.SelectedIndex = index;
                playingsong.Text = selected.Name;
                vlc_play(selected.Url);
                playingsong.Text = selected.Name;
            }
        }

       

        private void shuffle_Paint(object sender, MouseEventArgs e)
        {
            if (shuffleEnabled == false)
            {
                shuffleEnabled = true;
                shuffle.BackgroundImage = _hit_.Properties.Resources.ONshuffle;
            }
            else
            {
                shuffleEnabled = false;
                shuffle.BackgroundImage = _hit_.Properties.Resources.shuffle;
            }
        }

        private void repeat_Paint(object sender, MouseEventArgs e)
        {
            if (repeatOne == false)
            {
                repeatOne = true;
                repeat.BackgroundImage = _hit_.Properties.Resources.ONrepeat;
            }
            else
            {
                repeatOne = false;
                repeat.BackgroundImage = _hit_.Properties.Resources.repeat;
            }
        }

        private void refreshSongs(object sender, EventArgs e)
        {
            if (!songsPath.Text.Equals(""))
            {
                songs.Items.Clear();
                
                loadSongs(songsPath.Text);
            }
        }
    }
}