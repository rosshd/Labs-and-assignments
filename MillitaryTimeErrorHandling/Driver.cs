using System;

namespace Lab8
{
    class Driver
    {
        public static int getSeconds(string str)
        {
            string[] time = str.Split(":",3);
            if(time.Length < 3 || time.Length > 3)
            {
                throw new InvalidTimeException("Enter a valid time.");
            }
            
            var seconds = 0;
            for(int i = 0; i < 3; i++)
            {
                try
                {
                    Int32.Parse(time[i]);
                }
                catch
                {
                    throw new InvalidTimeException("Time uses invalid charactors/symbols");
                }
                
                if(i == 0){
                    if(Int32.Parse(time[i]) < 0 || Int32.Parse(time[i]) > 23)
                    {
                        throw new InvalidTimeException("Not a valid hour");
                    }
                    else
                    { 
                        seconds += (int)(3600 / Math.Pow(60, i)) * Int32.Parse(time[i]);
                    }
                }if(i == 1){
                    if(Int32.Parse(time[i]) > 59)
                    {
                        throw new InvalidTimeException("Minutes must be less than 60");
                    }
                    else if (Int32.Parse(time[i]) < 0)
                    {
                        throw new InvalidTimeException("Minutes must be greater than 0");
                    }
                    else
                    {
                        seconds += (int)(3600 / Math.Pow(60, i)) * Int32.Parse(time[i]);
                    }
                }if(i == 2){
                    if(Int32.Parse(time[i]) > 59)
                    {
                        throw new InvalidTimeException("Seconds must be less than 60");
                    }
                    else if (Int32.Parse(time[i]) < 0)
                    {
                        throw new InvalidTimeException("Seconds must be greater than 0");
                    }
                    else
                    {
                        seconds += (int)(3600 / Math.Pow(60, i)) * Int32.Parse(time[i]);
                    }
                }

            }
            return seconds;
        }
        static void Main(string[] args)
        {
                var time1Seconds = 0;
                var time1 = "";
                var time2Seconds = 0;
                var time2 = "";
            try
            {
                Console.WriteLine("Please enter a time in the form hh:mm:ss");
                time1 = Console.ReadLine() ?? "";
                time1Seconds = getSeconds(time1);

                Console.WriteLine("Please enter a second time in the form hh:mm:ss");
                time2 = Console.ReadLine() ?? "";
                time2Seconds = getSeconds(time2);

                Console.WriteLine("Difference in seconds: " +  Math.Abs(time1Seconds - time2Seconds) );
            }   
            catch(InvalidTimeException badTime)
            {
                Console.Write(badTime.Message);
            }

        }
    }
}