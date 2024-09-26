using System;
using System.Collections.Generic;
using System.Text;

namespace MediaCodec
{
    interface IImageStandard : IMediaStandard
    {
        public string getImageCodec();
    }
}