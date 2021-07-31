using System;
using System.Threading;

namespace TZ_Calculator
{
    class Program
    {
        /// <summary>
        ///  I give up on this bc it's so unnecessary! Displays the time remaning or the time when it when it happened.</summary>
        /// <param name="pastOrFuture"></param>
        /// <param name="passedTimeDiff">Pass the time difference between today's date and the event date [data type: <c>TimeSpan</c>]</param>
        /// <value>
        ///     <list type="bullet">
        ///         <item>
        ///             <term><c>past</c></term>
        ///             <description>when the event happened BEFORE today's date.</description>
        ///         </item>
        ///         
        ///         <item>
        ///             <term><c>future</c></term>
        ///             <description>when the event would happen AFTER today's date.</description>
        ///         </item>
        ///     </list>
        /// </value>
        //[System.Obsolete("Do not use!")]
        //public void DisplayRemainingPeriod(string pastOrFuture, TimeSpan passedTimeDiff)
        //{
        //    string msg = "";
        //    if (pastOrFuture == "future")
        //    {
        //        msg = "Happening in ";
        //    }
        //    else if (pastOrFuture == "past")
        //    {
        //        msg = "Happened ";
        //    }
        //    else
        //    {
        //        Console.WriteLine("Incorrect parameter value for [pastOrFuture] passed! \n~ Developer's fault, ehe (╹ڡ╹ )");
        //    }

        //    double yrs; double months;
        //    if (Int32.Parse(passedTimeDiff.ToString("%d")) > 365 /* if more than one year */)
        //    {
        //        yrs = Math.Floor(Int32.Parse(passedTimeDiff.ToString("%d")) * 0.002738);
        //    }
        //    else if (Int32.Parse(passedTimeDiff.ToString("%d")) > 31 /* if more than one month */)
        //    {
        //        months = Math.Floor(Int32.Parse(passedTimeDiff.ToString("%d")) * 0.002738);
        //    }
        //}

        static void Main(string[] args)
        {
            // Program Start
            Console.WriteLine("\nEnter time [Format: YYYY/MM/DD 24HH:MM:SS +/-UTC|GMT timezone) || Example: 2021/07/21 06:00:00 +0900]:");
            string tempInputTime = Console.ReadLine();

            // Program Processing
            //   a. Getting System Timezone
            TimeZoneInfo detectedTimeZone = TimeZoneInfo.Local;
            Console.WriteLine($"\nDetected local timezone(s): {detectedTimeZone.DisplayName}\n");

            //   b. Getting the Local Time
            DateTime resultTime;
            if (DateTime.TryParse(tempInputTime, out resultTime)) {
                string abrv;
                switch (Convert.ToInt32(resultTime.ToString("dd")))
                {
                    case 1:
                    case 21:
                    case 31:
                        abrv = "st";
                        break;

                    case 2:
                    case 22:
                        abrv = "nd";
                        break;

                    case 3:
                    case 23:
                        abrv = "rd";
                        break;

                    default:
                        abrv = "th";
                        break;
                }

                Console.WriteLine($"{resultTime.ToString("MMM d")}{abrv} {resultTime.ToString("yyyy HH:mm:ss")} (24hr)");
                TimeSpan timeDiff = resultTime - DateTime.Now;

                //Console.WriteLine($"Happening(ed) (in) {timeDiff.ToString("%d")} Day(s) & {timeDiff.ToString(@"hh\:mm\:ss")} Hour(s) (ago)"); // Day(s) {timeDiff.TotalHours} Hour(s) {timeDiff.TotalMinutes} Minute(s) & {timeDiff.TotalSeconds} Second(s) (ago)"
                if (DateTime.Now < resultTime)
                {
                    //new Program().DisplayRemainingPeriod("future", timeDiff);
                    Console.WriteLine($"Happening in {timeDiff.ToString("%d")} Day(s) & {timeDiff.ToString(@"hh\:mm\:ss")} Hour(s)");
                } else
                {
                    //new Program().DisplayRemainingPeriod("past", timeDiff);
                    Console.WriteLine($"Happened {timeDiff.ToString("%d")} Day(s) & {timeDiff.ToString(@"hh\:mm\:ss")} Hour(s) ago");
                }
                
            } else
            {
                Console.WriteLine("[FAIL] Incorrect date entry! Exiting...");
            }

            // Program Exit
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
            Console.WriteLine("\n\nGoodbye! ^-^");
            Thread.Sleep(1000);
        }
    }
}
