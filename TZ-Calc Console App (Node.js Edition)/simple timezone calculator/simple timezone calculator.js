const prompt = require('prompt-sync')(
	{ sigint: true } /* for letting users exit */
);
const moment = require('moment');

console.log(
	'\nEnter time [Format: YYYY/MM/DD 24HH:MM:SS +/-UTC|GMT timezone) || Example: 2021/07/21 06:00:00 +0800]:'
);
const inputTime = new Date(prompt());
const clientTimezone = Intl.DateTimeFormat().resolvedOptions().timeZone; // to get client's timezone

console.log('\nDetected local timezone: ' + clientTimezone);

const resultTime = inputTime.toLocaleString('en-US', {
	timeZone: 'Asia/Riyadh',
});

console.log(
	`\n${moment(new Date(resultTime)).format(
		'MMMM Do YYYY HH:mm:ss'
	)}\nHappening(ed) ${moment(new Date(resultTime)).fromNow()} \n`
);

// not gunna use it but in case i need it in future i have it
/*
const tzs = {
    "American Samoa": "-1100",
    "International Date Line West": "-1100",
    "Midway Island": "-1100",
    "Hawaii": "-1000",
    "Alaska": "-0900",
    "Pacific Time (US & Canada)": "-0800",
    "Tijuana": "-0800",
    "Arizona": "-0700",
    "Chihuahua": "-0700",
    "Mazatlan": "-0700",
    "Mountain Time (US & Canada)": "-0700",
    "Central America": "-0600",
    "Central Time (US & Canada)": "-0600",
    "Guadalajara": "-0600",
    "Mexico City": "-0600",
    "Monterrey": "-0600",
    "Saskatchewan": "-0600",
    "Bogota": "-0500",
    "Eastern Time (US & Canada)": "-0500",
    "Indiana (East)": "-0500",
    "Lima": "-0500",
    "Quito": "-0500",
    "Caracas": "-0430",
    "Atlantic Time (Canada)": "-0400",
    "Georgetown": "-0400",
    "La Paz": "-0400",
    "Santiago": "-0400",
    "Newfoundland": "-0330",
    "Brasilia": "-0300",
    "Buenos Aires": "-0300",
    "Greenland": "-0300",
    "Mid-Atlantic": "-0200",
    "Azores": "-0100",
    "Cape Verde Is.": "-0100",
    "Casablanca": "+0000",
    "Dublin": "+0000",
    "Edinburgh": "+0000",
    "Lisbon": "+0000",
    "London": "+0000",
    "Monrovia": "+0000",
    "UTC": "+0000",
    "Amsterdam": "+0100",
    "Belgrade": "+0100",
    "Berlin": "+0100",
    "Bern": "+0100",
    "Bratislava": "+0100",
    "Brussels": "+0100",
    "Budapest": "+0100",
    "Copenhagen": "+0100",
    "Ljubljana": "+0100",
    "Madrid": "+0100",
    "Paris": "+0100",
    "Prague": "+0100",
    "Rome": "+0100",
    "Sarajevo": "+0100",
    "Skopje": "+0100",
    "Stockholm": "+0100",
    "Vienna": "+0100",
    "Warsaw": "+0100",
    "West Central Africa": "+0100",
    "Zagreb": "+0100",
    "Zurich": "+0100",
    "Athens": "+0200",
    "Bucharest": "+0200",
    "Cairo": "+0200",
    "Harare": "+0200",
    "Helsinki": "+0200",
    "Istanbul": "+0200",
    "Jerusalem": "+0200",
    "Kyiv": "+0200",
    "Pretoria": "+0200",
    "Riga": "+0200",
    "Sofia": "+0200",
    "Tallinn": "+0200",
    "Vilnius": "+0200",
    "Baghdad": "+0300",
    "Kuwait": "+0300",
    "Minsk": "+0300",
    "Moscow": "+0300",
    "Nairobi": "+0300",
    "Riyadh": "+0300",
    "St. Petersburg": "+0300",
    "Volgograd": "+0300",
    "Tehran": "+0330",
    "Abu Dhabi": "+0400",
    "Baku": "+0400",
    "Muscat": "+0400",
    "Tbilisi": "+0400",
    "Yerevan": "+0400",
    "Kabul": "+0430",
    "Ekaterinburg": "+0500",
    "Islamabad": "+0500",
    "Karachi": "+0500",
    "Tashkent": "+0500",
    "Chennai": "+0530",
    "Kolkata": "+0530",
    "Mumbai": "+0530",
    "New Delhi": "+0530",
    "Sri Jayawardenepura": "+0530",
    "Kathmandu": "+0545",
    "Almaty": "+0600",
    "Astana": "+0600",
    "Dhaka": "+0600",
    "Novosibirsk": "+0600",
    "Urumqi": "+0600",
    "Rangoon": "+0630",
    "Bangkok": "+0700",
    "Hanoi": "+0700",
    "Jakarta": "+0700",
    "Krasnoyarsk": "+0700",
    "Beijing": "+0800",
    "Chongqing": "+0800",
    "Hong Kong": "+0800",
    "Irkutsk": "+0800",
    "Kuala Lumpur": "+0800",
    "Perth": "+0800",
    "Singapore": "+0800",
    "Taipei": "+0800",
    "Ulaanbataar": "+0800",
    "Osaka": "+0900",
    "Sapporo": "+0900",
    "Seoul": "+0900",
    "Tokyo": "+0900",
    "Yakutsk": "+0900",
    "Adelaide": "+0930",
    "Darwin": "+0930",
    "Brisbane": "+1000",
    "Canberra": "+1000",
    "Guam": "+1000",
    "Hobart": "+1000",
    "Magadan": "+1000",
    "Melbourne": "+1000",
    "Port Moresby": "+1000",
    "Solomon Is.": "+1000",
    "Sydney": "+1000",
    "Vladivostok": "+1000",
    "New Caledonia": "+1100",
    "Auckland": "+1200",
    "Fiji": "+1200",
    "Kamchatka": "+1200",
    "Marshall Is.": "+1200",
    "Wellington": "+1200",
    "Nuku???alofa": "+1200",
    "Samoa": "+1200",
    "Tokelau Is.": "+1300"
};

const getAllTzs = utcOffset => {
    let allTzs = []
    for (var tzName in tzs) {
        if (tzs[tzName] == utcOffset) { allTzs.push(tzName) }
    }
    return allTzs;
};

let tzArray = getAllTzs(moment().format('ZZ'));
console.log(tzArray.toString());
*/
