using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OOPS.Others
{ 
        //Define a delegate
        //Define an event based on that delegate
        //Raise the event
        internal class Events
        {
            public static void MainMethod()
            {
                var video = new Video() { Title = "Video 1" };
                var videoEncoder = new VideoEncoder();

                var mailService = new MailService();
                var messageService = new MessageService();
                videoEncoder.VideoEncoded += mailService.onVideoEncoded;
                videoEncoder.VideoEncoded += messageService.onVideoEncoded;
                videoEncoder.Encode(video);
                Console.ReadLine();
            }
        }
        public class Video
        {
            public string Title { get; set; }
        }
        //Publisher  Old way of declaring
        public class VideoEncoderOld
        {
            public delegate void VideoEncodedEventHandler(object source, EventArgs e);
            public event VideoEncodedEventHandler VideoEncoded;
            public void Encode(Video video)
            {
                Console.WriteLine("Encoding Video");
                Thread.Sleep(3000);
                OnVideoEncoded();
            }
            protected void OnVideoEncoded()
            {
                if (VideoEncoded != null)
                {
                    VideoEncoded(this, EventArgs.Empty);
                }
            }
        }

        public class VideoEventArgs : EventArgs
        {
            public Video video { get; set; }
        }
        //Publisher
        public class VideoEncoder
        {
            public delegate void VideoEncodedEventHandler(object source, VideoEventArgs e);
            public event VideoEncodedEventHandler VideoEncoded;
            public void Encode(Video video)
            {
                Console.WriteLine("Encoding Video");
                Thread.Sleep(3000);
                OnVideoEncoded(video);
            }
            protected void OnVideoEncoded(Video video)
            {
                if (VideoEncoded != null)
                {
                    VideoEncoded(this, new VideoEventArgs() { video = video });
                }
            }
        }

        //Publisher
        public class VideoEncoderNew
        {
            public EventHandler<VideoEventArgs> VideoEncoded;
            public void Encode(Video video)
            {
                Console.WriteLine("Encoding Video");
                Thread.Sleep(3000);
                OnVideoEncoded(video);
            }
            protected void OnVideoEncoded(Video video)
            {
                if (VideoEncoded != null)
                {
                    VideoEncoded(this, new VideoEventArgs() { video = video });
                }
            }
        }

        //Subscriber
        public class MailService
        {
            public void onVideoEncoded(object source, VideoEventArgs e)
            {
                Console.WriteLine("Mail Service:,Sending an email {0}", e.video.Title);
            }
        }

        //Subscriber
        public class MessageService
        {
            public void onVideoEncoded(object source, VideoEventArgs e)
            {

                Console.WriteLine("Message Service:,Sending an Message {0}", e.video.Title);
            }
        }

    }


