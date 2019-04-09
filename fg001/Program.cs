using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Worldline
{
    class Program
    {
        static string First;
        static int Second;
        static int Third;
        static int Fourth;
        static int Fifth;
        static int Sixth;
        static int Seventh;
        static int deshimaru;
        static int[] InputTime = new int[6];
        static void Main(string[] args)
        {
            //As of v1.0, it takes approximately 6.5ms to calculate the code
            //As of v1.1, it takes approximately 8ms to calculate the code
            Console.SetWindowSize(120, 30);
            Random RNG = new Random();
            First = "";
            int af = RNG.Next(1, 100);
            if(af == 1)
            {
                First = "1";
            }
            else if (af == 2)
            {
                First = "2";
            }
            else if (af == 3)
            {
                First = "3";
            }
            else if (af == 4)
            {
                First = " ";
            }
            else
            {
                First = "0";
            }
            Second = RNG.Next(0, 9);
            Third = RNG.Next(0, 9);
            Fourth = RNG.Next(0, 9);
            Fifth = RNG.Next(0, 9);
            Sixth = RNG.Next(0, 9);
            Seventh = RNG.Next(0, 9);
            bool quit = false;
            while (quit != true)
            {
                InputTime[0] = DateTime.Now.Day;
                InputTime[1] = DateTime.Now.Month;
                InputTime[2] = DateTime.Now.Year;
                InputTime[3] = DateTime.Now.TimeOfDay.Hours;
                InputTime[4] = DateTime.Now.TimeOfDay.Minutes;
                InputTime[5] = DateTime.Now.TimeOfDay.Seconds;
                deshimaru = DecimalTime(InputTime);
                Console.WriteLine("\rFG001 'Divergence Meter' v1.2");
                Console.WriteLine("\r");
                Console.WriteLine("\rUNIX Time since epoch - 32bit - ");
                Console.WriteLine("\rFri, 1 Jan 1970 8:00:00 GMT+8:00");
                Console.WriteLine("");
                Console.WriteLine("\rTime");
                Console.Write($"\r{CurrentTime(InputTime)}");
                Console.WriteLine(@"
");
                Console.WriteLine("\rDECIMAL");
                Console.Write($"\r{deshimaru}");
                Console.WriteLine(@"
");
                Console.WriteLine("BINARY");
                Console.Write($"\r{BinaryTime(deshimaru)}");
                Console.WriteLine(@"
");
                Console.WriteLine("\rThe End of UNIX Time (32-bit)");
                Console.WriteLine("\rTue, 19 Jan 2038 11:14:08 GMT+8:00");
                Console.WriteLine(@"");
                Console.WriteLine("\rDivergence Number");
                Console.WriteLine($@"{First}.{Second}{Third}{Fourth}{Fifth}{Sixth}{Seventh}{"",-42}STEIN'S GATE: 1.048596");
                Console.WriteLine($"\r{"",-50}ALPHA ATTRACTOR FIELD: 0.000000 -- 0.999999");
                Console.WriteLine($"\r{"",-50}BETA  ATTRACTOR FIELD: 1.000000 -- 1.999999");
                Console.WriteLine($"\r{"",-50}GAMMA ATTRACTOR FIELD: 2.000000 -- 2.999999");
                Console.WriteLine($"\r{"",-50}DELTA ATTRACTOR FIELD: 3.000000 -- 3.999999");
                Console.WriteLine($"\r{"",-50}OMEGA ATTRACTOR FIELD:  .000000 --  .999999");
                //Debug.WriteLine(DateTime.Now.TimeOfDay);
                //Debug.WriteLine("");
                Thread.Sleep(992);
                Console.Clear();
            }
        }
        public static string CurrentTime(int[] input)
        {
            string Time = "";
            Time += DateTime.Now.ToString("ddd") + ", ";
            Time += TwoDigit(input[0]) + " ";
            Time += CheckMonth(input[1]) + " ";
            Time += input[2] + " ";
            Time += TwoDigit(input[3]) + ":";
            Time += TwoDigit(input[4]) + ":";
            Time += TwoDigit(input[5]) + " GMT+8:00";
            return Time;
        }
        public static int DecimalTime(int[] input)
        {
            int Time = 0;
            Time += 31536000 * (input[2] - 1970); //year
            Time += 2628000 * input[1];
            Time += 86400 * input[0];
            Time += 3600 * (input[3] - 8);
            Time += 60 * input[4];
            Time += input[5];
            Time += 3600 * 8;
            return Time;
        }
        public static string BinaryTime(int input)
        {
            string binary = "";
            binary = Convert.ToString(input, 2);
            return binary;
        }
        public static string CheckMonth(int input)
        {
            string output = "";
            switch(input)
            {
                case 1:
                    output = "Jan";
                    break;
                case 2:
                    output = "Feb";
                    break;
                case 3:
                    output = "Mar";
                    break;
                case 4:
                    output = "Apr";
                    break;
                case 5:
                    output = "May";
                    break;
                case 6:
                    output = "Jun";
                    break;
                case 7:
                    output = "Jul";
                    break;
                case 8:
                    output = "Aug";
                    break;
                case 9:
                    output = "Sep";
                    break;
                case 10:
                    output = "Oct";
                    break;
                case 11:
                    output = "Nov";
                    break;
                case 12:
                    output = "Dec";
                    break;
            }
            return output;
        }
        public static string TwoDigit(int input)
        {
            string output = "";
            if(input < 10)
            {
                output = "0" + input.ToString();
            }
            else
            {
                output = input.ToString();
            }
            return output;
        }
        public static string Hour(int input)
        {
            string output = "";
            if(input < 10)
            {
                output = "0" + input.ToString();
            }
            else
            {
                output = input.ToString();
            }
            return output;
        }
        public static string Seconds(int input)
        {
            string output = "";
            if(input < 10)
            {
                output = "0" + input.ToString();
            }
            else
            {
                output = input.ToString();
            }
            return output;
        }
        public static int divergence_calc(int input)
        {

            return input;
        }
    }
}
