using System;
using System.Collections.Generic;
using System.Text;

namespace MediaCodec
{
    interface IAudioStandard : IMediaStandard
    {
        public string getAudioCodec();
    }
}