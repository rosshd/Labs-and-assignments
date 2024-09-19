using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Driver
    {
        public static void Main(string[] args)
        {
            List<WeatherEvent> forecast = new List<WeatherEvent>();
            Console.WriteLine("[Weather Tracking System]");
            while(true)
            {
                Console.WriteLine("1. Add weather event");
                Console.WriteLine("2. Update location");
                Console.WriteLine("3. Update active");
                Console.WriteLine("4. View all events");
                Console.WriteLine("5. Quit");

                Console.Write("Enter your option: ");
                var action = Int32.Parse(Console.ReadLine());

                if(action == 5) 
                {
                    Console.WriteLine("Shutting off...");
                    break;
                }
                else if(action == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("1. Rain");
                    Console.WriteLine("2. Snow");
                    Console.WriteLine("3. Fog");
                    Console.WriteLine("4. Particle");

                    Console.Write("What type of weather event is being added? ");
                    var eventType = Int32.Parse(Console.ReadLine());

                    Console.Write("Where is the event happening? ");
                    var location = Console.ReadLine();

                    if(eventType == 1)
                    {
                        Console.Write("What is the rate of fall? (in/h) ");
                        var rateOfFall = Double.Parse(Console.ReadLine());
                        
                        Console.Write("What is the diameter of the drops? (in) ");
                        var diameter = Double.Parse(Console.ReadLine());

                        Rain rain = new Rain(location, true, rateOfFall, diameter);
                        forecast.Add(rain);
                        Console.WriteLine("Rain event added");
                    }
                    else if(eventType == 2)
                    {
                        Console.Write("What is the rate of fall? (in/h) ");
                        var rateOfFall = Double.Parse(Console.ReadLine());
                        
                        Console.Write("What is the temperature? (F) ");
                        var temperature = Double.Parse(Console.ReadLine());

                        Snow snow = new Snow(location, true, rateOfFall, temperature);
                        forecast.Add(snow);
                        Console.WriteLine("Snow event added");
                    }
                    else if(eventType == 3)
                    {
                        Console.Write("What is the visibility? (1/8mi) ");
                        var visibility = Int32.Parse(Console.ReadLine());
                        
                        Console.Write("Is the fog freezing? (y/n) ");
                        var cold = Console.ReadLine();
                        if(cold.ToUpper() == "Y")
                        {
                            Fog fog = new Fog(location, true, visibility, true);
                            forecast.Add(fog);
                        }
                        else
                        {
                            Fog fog = new Fog(location, true, visibility, false);
                            forecast.Add(fog);
                        } 

                        Console.WriteLine("Fog event added");
                    }
                    else
                    {
                        Console.Write("What is the visibility? (1/8mi) ");
                        var visibility = Int32.Parse(Console.ReadLine());
                        
                        Console.Write("What is the obstruction made of? (Sand/Dust/Ash/Other) ");
                        var particleType = Console.ReadLine();

                        Particle particle = new Particle(location, true, visibility, particleType);
                        forecast.Add(particle);
                        Console.WriteLine("Particle event added");
                    }
                     
                }
                else if(action == 2)
                {
                    Console.WriteLine("Enter id of weather event: ");
                    var id = Int32.Parse(Console.ReadLine());

                    if(forecast.Count == 0 || !(id < forecast.Count && id >= 0))
                    {
                        Console.WriteLine("No event with that id.");
                    }
                    else
                    {
                        Console.WriteLine("Enter the new location of the weather event (currently \"" + forecast[id].getLocation() + "\": ");
                        var newLocation = Console.ReadLine();

                        forecast[id].setLocation(newLocation);
                        Console.WriteLine("Location updated");
                    }
                }
                else if(action == 3)
                {
                    Console.WriteLine("Enter id of weather event: ");
                    var id = Int32.Parse(Console.ReadLine());

                    if(forecast.Count == 0 || !(id < forecast.Count && id >= 0))
                    {
                        Console.WriteLine("No event with that id.");
                    }
                    else
                    {
                        if(forecast[id].isActive())
                        {
                            forecast[id].setActive(false);
                            Console.WriteLine("Event set to \"inactive\"");
                        }
                        else
                        {
                            forecast[id].setActive(true);
                            Console.WriteLine("Event set to \"active\"");
                        }
                    }
                }
                else if(action == 4)
                {
                    Console.WriteLine();
                    foreach(WeatherEvent weather in forecast)
                    {
                        Console.WriteLine(weather.toString());
                    }
                }
                else Console.WriteLine("Invalid Option!");


                Console.WriteLine();
            }
        }
    }
}