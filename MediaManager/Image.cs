using System;
using System.Collections.Generic;
using System.Text;

namespace MediaCodec
{
    class Image : Media, IImageStandard
    {
        private string imageCodec;
        public Image(string fileName, string imageCodec) : base(fileName)
        {
            this.imageCodec = imageCodec;
        }

        public string getImageCodec()
        {
            return "Image codec: " + this.imageCodec;
        }

        public override string getMediaInfo()
        {
            return "Image ID: " + base.getId() + "\nImage Name: " + base.getFileName() + "\n" + this.getImageCodec();
        }
        
    }
}