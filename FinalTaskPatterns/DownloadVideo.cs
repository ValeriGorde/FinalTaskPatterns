using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;
using YoutubeExplode.Videos;

namespace FinalTaskPatterns
{
    class DownloadVideo: Command
    {
        Receiver _receiver;
        public string videoUrl, videoDir;

        public DownloadVideo(Receiver receiver, string videoUrl, string videoDir) 
        {
            _receiver = receiver;
            this.videoUrl = videoUrl;
            this.videoDir = videoDir;
        }
        
        public async Task Download()
        {
            YoutubeClient youtube = new YoutubeClient();
            try
            {
                var video =  await youtube.Videos.GetAsync(videoUrl);
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);
                var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
                await youtube.Videos.Streams.DownloadAsync(streamInfo, $"{videoDir}/{video.Title}.{streamInfo.Container}");            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public override async Task Start()
        {
            await Download();
            _receiver.InfoDownload();
        }
    }
}
