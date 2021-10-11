using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
