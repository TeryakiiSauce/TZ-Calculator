using System;
using System.Threading;

namespace TZ_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(120, 40);
            Console.WriteLine(@"
    %%@(%%%#%%/%%%%##%%%%%#%#/%%%%%#%%%%##%&%&%%%%&%%%%#%%%%%%#%%(#(#/%(%&&&%&&&@(#&
    %%%#%%%#%(*#%#%&%&%%%%/%%##%%%%#*%%%##%%%&%%%%%%%%%(%%%%(%%%%(#/%(%%%%((%%&%&(%%
    %%/%%##(%%((%#%%%%%%%%/#%//%%%#%/#%%##&#%#%%%%%%%%%(%%%%*#%%%##/%(%%%%%%%%##&(%*
    %%*#%%%(%%((%%##%#%###(##(#(####(/#################(####(/##(##/#/#%##%%%%%%&(%*
    %&*#%%%(##(############/##(######(/###(###########((###/#(#####/#/##########%/%/
    %%/##%%###/#(##(#######((#/#(##(#(%/##((#########(/(##(#((#/##%(#/##(#########%#
    ##((####/#/##/##((###(((#((#%(((((/%/(///(((((((//#/((%#(###%##///##((######(###
    #(%(####/((####%&#(((####%#%%%%%%%%%%%%%&&&&%%%%%%%%%%%%%##(////**/(#(/((#(//#/#
    #(#//(%##(*.***,.,*/#%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%/.   %... ...*(((###
    .(##/,.  .......%#  ...**%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&#//...,*,,.........  ,*,
    ## .   . //,****/#(**/,*/,%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&,(*,**//.,/****,,**. .(.
    .#  .%#/,,**/((/..../((,/&&(%&&&&&&&&&&&&&&&&&&&&&&&&&#&&%*/((,..../((/%&,*#%%,.
    ,(,%%%%(&@&(((#*.... /*/%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&#(***,,...(#(((**#&&&%*
    #%*.%&&&%(/,/(%%%%%%%%%&&&&&&&&&&&&&&&&&%&&&&&&&&&&&&&&&&&&%%%%%%%%%%#**#&&&&/,%
    ##(#***/(####(%%%%%%%%%&&&&&&&&&&&&&&&&&%@@&&&&&&&&&&&&&&&&&&%%%%%%%%%(##/((/((@
    #%&/%%%##%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&#@@@&&&&&&&&&&&&&&&&%%%%%%%#%%%%%%%%%%/#
    %%%/%%%%%%%#%%%%#%%%%%%%&&&&&&&&&&&&&&&&%@@@@&&&&&&&&&&&&&&%%%%%%#%%%%#%%%%%%#@%
    %&&&/%%%%%%%#%#%%%%%%%%%%&&&&&&&&&&&&&&&%@@&&&&&&&&&&&&&&&&%%%%%%%%%#%%#%#%%%/&&
    (&&&&#%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%/&&&
    %#&&&(%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%%%%%%%%%%%(&&&#
    %(#&&%(%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%%%%%%%/%%%/*
    #%/(%%%#(%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%&%/%%##/%
    %%%/%/%%%%#&&&&&&&&&&&&&&&&&&&&&&&&&%(%@@@&*#&&&&&&&&&&&&&&&&&&&&&&&&&&/%%(%%(%(
    %%%//%%(/%%%(%&&&&&&&&&&&&&&&&&&&&#,,,,**,,*,,/&&&&&&&&&&&&&&&&&&&&%/#%/##%%(&%%
    %%%%((%%(%%#(((/**#&&&&&&&&&&&&&&*(((((/*///(((,&&&&&&&&&&&&&&&&&&&&%#(%%%%(#%#%
    %%%%%%#*#%%%&&*#%&&&&&&&&&&&&&&&%/((((((/#(((((((&&&&&&&&&&&&&&&&&%#(&&&%/%%&%(%
    %%%%%%%(%%%&@@%@(#%&&&&&&&&&&&&&&&*###((/(((((((&&&&&&&&&&&&&&&&%#(&&&&&%(%&&&*%
    %%%%%%%#&&#&&@%@@@@(%&&&&&&&&&&&&&&@(&###(#(#/&&@&&&&&&&&&&&&&#(@(&&&&&&%(%&&&/%
    %%%%%%(#&&%&@&&@@@@@@&(%&&&&&&&&&&&&&&/###(*&&&&&&&&&&&&&&%##@@@@(&&&&&&%#&&&&#%
    %%%%%%(&&%&&&&@@@@@@@@(((##&&&&&&&&&&&&&@&&&&&&&&&&&&&%#(#*&@@@@@(&&&&&&%%&&&&##
    %%%%%#%&&#&&@%@@@@@@@@@(###((#%&&&&&&&&&&&&&&&&&&&%#((((##&@@@@@@(&&&&&&%@&&&&%/
    %%%%%(&&&%&&&#@@@@@@@@@(#,*#(((/(#%%&&&&&&&&&&%#(((((,,/#(@@@@@@@#&&&&&&%@%&&&&(
");

            // Program Start
            Console.WriteLine("\nEnter time [Format: YYYY/MM/DD 24HH:MM:SS +/-UTC|GMT timezone) || Example: 2021/07/21 06:00:00 +0900]:");
            string tempInputTime = Console.ReadLine();

            // Program Processing
            //   a. Getting System Timezone
            TimeZoneInfo detectedTimeZone = TimeZoneInfo.Local;
            Console.WriteLine($"\nDetected local timezone(s): {detectedTimeZone.DisplayName}\n");

            //   b. Getting the Local Time
            DateTime resultTime;
            if (DateTime.TryParse(tempInputTime, out resultTime))
            {
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
                }
                else
                {
                    //new Program().DisplayRemainingPeriod("past", timeDiff);
                    Console.WriteLine($"Happened {timeDiff.ToString("%d")} Day(s) & {timeDiff.ToString(@"hh\:mm\:ss")} Hour(s) ago");
                }

            }
            else
            {
                Console.WriteLine("[FAIL] Incorrect date entry! Exiting...");
            }

            // Program Exit
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
            Console.WriteLine("\n\nGoodbye! ^-^");
            Thread.Sleep(750);
        }
    }
}
