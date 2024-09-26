using System;
using System.Collections.Generic;
using System.Text;

namespace MediaCodec
{
    class Video : Media, IImageStandard, IAudioStandard
    {
        private string imageCodec;
        private string audioCodec;
        public Video(string fileName, string imageCodec, string audioCodec) : base(fileName)
        {
            this.imageCodec = imageCodec;
            this.audioCodec = audioCodec;
        }

        public string getImageCodec()
        {
            return "Image codec: " + this.imageCodec;
        }

        public string getAudioCodec()
        {
            return "Audio codec: " + this.audioCodec;
        }

        public override string getMediaInfo()
        {
            return "Video ID: " + base.getId() + "\nVideo Name: " + base.getFileName() + "\n" + this.getImageCodec() + "\n" + this.getAudioCodec();
        }
        
    }
}