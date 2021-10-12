using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Timers;
using System.Threading;

namespace TZ_Calc_GUI
{
    public partial class mainScreen : Form
    {
        public mainScreen()
        {
            InitializeComponent();
        }

        private void customTimezoneCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (customTimezoneCheckBox.Checked == false)
            {
                timezonePicker.DropDownStyle = ComboBoxStyle.DropDownList;
            } else
            {
                timezonePicker.DropDownStyle = ComboBoxStyle.DropDown;
            }
        }

        private void setContinueBtnStatus(string dropDownStyle)
        {
            if (dropDownStyle == "list")
            {
                if (timezonePicker.SelectedItem == null)
                {
                    continueBtn.Enabled = false;
                }
                else
                {
                    continueBtn.Enabled = true;
                }

            } else if (dropDownStyle == "manual")
            {
                if (timezonePicker.Text == string.Empty)
                {
                    continueBtn.Enabled = false;
                }
                else
                {
                    Regex filter = new Regex(@"^(?:Z|[+-](?:2[0-3]|[01][0-9]):[0-5][0-9])$"); // makes sure that the input is: [+/-][00-23]:[00-59]
                    if (filter.Match(timezonePicker.Text.ToString()).Success == true && timezonePicker.Text.Length == 6)
                    {
                        continueBtn.Enabled = true;
                    }
                    else if (filter.Match(timezonePicker.Text.ToString()).Success == false && timezonePicker.Text.Length == 6)
                    {
                        continueBtn.Enabled = false;
                        MessageBox.Show("Please enter the timezone in the correct format (24Hr)!\nIf it is 00:00 then you can add a '+' or '-'.", "Incorrect Format!");
                    }
                }
            } else
            {
                Console.WriteLine("Please check the parameters passed!");
            }
        }

        private void timezonePicker_TextUpdate(object sender, EventArgs e)
        {
            setContinueBtnStatus("manual");
        }

        private void timezonePicker_SelectionChangeCommitted(object sender, EventArgs e)
        {
            setContinueBtnStatus("list");
        }

        System.Timers.Timer timer = new System.Timers.Timer(10);

        private void continueBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(datePicker.Value.ToString() + " " + timezonePicker.Text.ToString());
            string inputTimeStr = datePicker.Value.ToString() + " " + timezonePicker.Text.ToString();
            DateTime inputTime = DateTime.Parse(inputTimeStr);
            TimeSpan timeToEvent = inputTime.Subtract(DateTime.Now);
            resultTextBox.Text = $"Event Date : {inputTime.ToString("dd-MMM-yyyy @ HH:mm")}\n" +
                                 $"Timezone   : {inputTime.ToString("zzz")}\n";

            timer.Elapsed += UpdateCountDown;
            timer.Start();
        }

        private void UpdateCountDown(Object source, ElapsedEventArgs e)
        {
            string inputTimeStr = datePicker.Value.ToString() + " " + timezonePicker.Text.ToString();
            DateTime inputTime = DateTime.Parse(inputTimeStr);
            TimeSpan timeToEvent = inputTime.Subtract(DateTime.Now);
            string[] lines = resultTextBox.Lines;
            lines[2] = $"Countdown  : {timeToEvent.Days} day(s), {timeToEvent.Hours}h:{timeToEvent.Minutes}m:{timeToEvent.Seconds}s:{timeToEvent.Milliseconds}ms";
            resultTextBox.Lines = lines;
        }

        private void getClipboardBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string clipboardText = Clipboard.GetText().ToString();
                DateTime t = DateTime.Parse(clipboardText);
                datePicker.Value = t;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please make sure to copy only the date and time (without the timezone; you can set it manually)!\nExample: [10/03/2021 08:00] instead of [10/03/2021 at 08:00 (UTC-4)]", "Incorrect Format");
            }
        }

        private void mainScreen_Shown(object sender, EventArgs e)
        {
            try
            {
                string clipboardText = Clipboard.GetText().ToString();
                DateTime t = DateTime.Parse(clipboardText);
                MessageBox.Show("Date & time information was detected from your clipboard!\nIt will be set now :)", "Time Info Detected from Clipboard");
                datePicker.Value = t;
            }
            catch (FormatException)
            {
                //do nothing
            }
        }
    }
}
