using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace FinalTaskPatterns
{
    class GetDescription : Command
    {
        public string videoUrl, videoDir;

        Receiver _receiver;
        public GetDescription(Receiver recivier, string videoUrl, string videoDir)
        {
            _receiver = recivier;
            this.videoUrl = videoUrl;
            this.videoDir = videoDir;
        }

        public async Task Description()
        {
            YoutubeClient youtube = new YoutubeClient();

            var video = await youtube.Videos.GetAsync(videoUrl);
            Console.WriteLine(video);
        }

        public override async Task Start()
        {
            await Description();
            _receiver.InfoDescription();
        }
    }
}
