using System;
using System.Collections.Generic;
using System.Text;

namespace MediaCodec
{
    class Music : Media, IAudioStandard
    {
        private string audioCodec;
        public Music(string fileName, string audioCodec) : base(fileName)
        {
            this.audioCodec = audioCodec;
        }

        public string getAudioCodec()
        {
            return "Audio codec: " + this.audioCodec;
        }

        public override string getMediaInfo()
        {
            return "Music ID: " + base.getId() + "\nMusic Name: " + base.getFileName() + "\n" + this.getAudioCodec();
        }
        
    }
}