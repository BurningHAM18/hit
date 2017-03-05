using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YT2MP3
{
    public class brain
    {
        private YTMP3 v;

        public brain(YTMP3 v)
        {
            this.v = v;
        }

        internal static void eraseText(TextBox uRL)
        {
            uRL.Text = "";
        }
    }
}
