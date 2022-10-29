using AngleSharp.Browser;
using YoutubeExplode;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;

namespace FinalTaskPatterns
{
    internal class Program
    {
        public const string videoDir = @"C:\Users\Лера\Desktop";
        static async Task Main(string[] args)
        {
            //https://www.youtube.com/watch?v=S8CZ1mA5YBo&ab_channel=АнатолийШарий

            Console.WriteLine("Введите ссылку на видео с YouTube:");
            string videoUrl = Console.ReadLine();

            Sender sender = new Sender();
            Receiver receiver = new Receiver();

            var description = new GetDescription(receiver, videoUrl, videoDir);
            sender.SetCommand(description);
            await sender.Start();

            var download = new DownloadVideo(receiver, videoUrl, videoDir);
            sender.SetCommand(download);
            await sender.Start();

        }
    }
}