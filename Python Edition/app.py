import re
import tzlocal
import datetime


print("""
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
""")


isProgramFinished = False

while isProgramFinished == False:
    print(
        "Enter time in this format: YYYY/MM/DD 24H:MM ZZ (refer UTC/GMT) [[ EXAMPLE: 2021/08/20 09:00 +/-04:00 ]]")

    try:
        inputTime = input()  # 2021/08/20 09:00 -04:00
        inputTimestamp = datetime.datetime.strptime(
            inputTime, "%Y/%m/%d %H:%M %z")

        # Gets the timezone
        currentLocalTimezone = tzlocal.get_localzone()
        print("\nDetected system timezone: " + str(currentLocalTimezone))

        # Converts the inputTimestamp from UTC to the one detected by the program & formats it beautifully
        resultLocalTime = inputTimestamp.astimezone(currentLocalTimezone)

        timeDiff = datetime.datetime(
            resultLocalTime.year, resultLocalTime.month, resultLocalTime.day, resultLocalTime.hour, resultLocalTime.minute, resultLocalTime.second) - datetime.datetime.now()

        print("\n== { " + resultLocalTime.strftime("%A, %b %d %Y @ %Hh:%Mm:%Ss") +
              " [24H] } ==")

        print("~ Event happening in " +
              re.sub(".{7}$", "", str(timeDiff)) + "\n")

        # Countdown (not the best but it's fine)
        # wholeTime = str(timeDiff)[7:15]
        # hoursToSecs = int(wholeTime[0:2]) * 3600
        # minToSecs = int(wholeTime[3:5]) * 60
        # secToSecs = int(wholeTime[6:8])
        # totalTimeInSecs = hoursToSecs + minToSecs + secToSecs
        # # print(wholeTime + " in seconds = " + str(totalTimeInSecs))  # testing

        # while totalTimeInSecs:
        #     hours = totalTimeInSecs // 3600
        #     mins = totalTimeInSecs // 60
        #     secs = totalTimeInSecs % 60

        #     timer = "~ Event happening in " + re.sub(".{17}$", "", str(
        #         timeDiff)) + ", " + "{:02d}h:{:02d}m:{:02d}s ~ (press Ctrl + C to exit)".format(hours, mins, secs)
        #     print(timer, end="\r")  # replaces current line

        #     try:
        #         time.sleep(1)
        #     except KeyboardInterrupt as e:
        #         print("Goodbye! ^-^")
        #         exit()

        #     totalTimeInSecs -= 1

        isProgramFinished = True
    except KeyboardInterrupt as k:
        print("\nGoodbye! ^-^")
        exit()

    except Exception as e:
        print("\nIncorrect date format entered or other error occured!\n*More info: " +
              str(e) + ". Try again...\n")
