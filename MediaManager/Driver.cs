using System;
using System.Collections.Generic;
using System.Text;

namespace MediaCodec
{
    class Driver
    {
        public static void Main(string[] args)
        {
            List<Media> allMedia = new List<Media>();
            
            Console.WriteLine("[Media Manager]\n");

            while(true)
            {
                
                Console.WriteLine("1-Add Image");
                Console.WriteLine("2-Add Music");
                Console.WriteLine("3-Add Video");
                Console.WriteLine("4-Show Images");
                Console.WriteLine("5-Show Music");
                Console.WriteLine("6-Show Videos");
                Console.WriteLine("7-Show Images and Videos");
                Console.WriteLine("8-Show Music and Videos");
                Console.WriteLine("9-Exit");
                Console.Write("Enter option:");

                var action = Int32.Parse(Console.ReadLine());
                Console.WriteLine();

                if(action == 9)
                {
                    Console.WriteLine("\nShutting Down...");
                    break;
                }
                else if(action == 1)
                {
                    Console.Write("Enter file name: ");
                    var fileName = Console.ReadLine();
                    Console.WriteLine("Enter image codec: ");
                    var codec1 = Console.ReadLine();
                    
                    Media newMedia = new Image(fileName, codec1);
                    allMedia.Add(newMedia);
                }
                else if(action == 2)
                {
                    Console.Write("Enter file name: ");
                    var fileName = Console.ReadLine();
                    Console.WriteLine("Enter audio codec: ");
                    var codec1 = Console.ReadLine();
                    
                    Media newMedia = new Music(fileName, codec1);
                    allMedia.Add(newMedia);
                }
                else if(action == 3)
                {
                    Console.Write("Enter file name: ");
                    var fileName = Console.ReadLine();
                    Console.WriteLine("Enter image codec: ");
                    var codec1 = Console.ReadLine();
                    Console.WriteLine("Enter audio codec: ");
                    var codec2 = Console.ReadLine();
                    
                    Media newMedia = new Video(fileName, codec1, codec2);
                    allMedia.Add(newMedia);
                }
                else if(action == 4)
                {
                    foreach(Media media in allMedia)
                    {
                        if(media.GetType() == typeof(Image))
                        {
                            Console.WriteLine(media.getMediaInfo());
                            Console.WriteLine();
                        }
                        
                    }
                }
                else if(action == 5)
                {
                    foreach(Media media in allMedia)
                    {
                        if(media.GetType() == typeof(Music))
                        {
                            Console.WriteLine(media.getMediaInfo());
                            Console.WriteLine();
                        }
                        
                    }
                }
                else if(action == 6)
                {
                    foreach(Media media in allMedia)
                    {
                        if(media.GetType() == typeof(Video))
                        {
                            Console.WriteLine(media.getMediaInfo());
                            Console.WriteLine();
                        }
                        
                    }
                }
                else if(action == 7)
                {
                    foreach(Media media in allMedia)
                    {
                        if(media.GetType() == typeof(Image) || media.GetType() == typeof(Video))
                        {
                            Console.WriteLine(media.getMediaInfo());
                            Console.WriteLine();
                        }
                        
                    }
                }
                else if(action == 8)
                {
                    foreach(Media media in allMedia)
                    {
                        if(media.GetType() == typeof(Music) || media.GetType() == typeof(Video))
                        {
                            Console.WriteLine(media.getMediaInfo());
                            Console.WriteLine();
                        }
                        
                    }
                }
                else Console.WriteLine("Invalid Choice, try again");

            }
        }
    }
}
