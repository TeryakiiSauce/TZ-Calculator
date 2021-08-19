import re
import tzlocal
import datetime
import time

isDone = False
while isDone == False:
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

    isValid = False
    while isValid == False:
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
                  re.sub(".{7}$", "", str(timeDiff)) + " ~\n")

            isValid = True
        except KeyboardInterrupt as k:
            print("\nGoodbye! ^-^")
            time.sleep(1.5)
            exit()

        except Exception as e:
            print("\nIncorrect date format entered or other error occured!\n*More info: " +
                  str(e) + ". Try again...\n")

    timeoutSecs = 15
    while timeoutSecs:
        timer = "Press [Ctrl + C] key to exit or wait " + \
            "{:02d}s to redo...".format(timeoutSecs)
        print(timer, end="\r")

        try:
            time.sleep(1)
        except KeyboardInterrupt:
            print("Goodbye! ^-^")
            time.sleep(1.5)
            exit()
        timeoutSecs -= 1
