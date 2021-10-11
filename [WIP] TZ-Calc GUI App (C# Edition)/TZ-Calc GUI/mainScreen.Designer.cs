
namespace TZ_Calc_GUI
{
    partial class mainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.eventTimeLabel = new System.Windows.Forms.Label();
            this.timezonePicker = new System.Windows.Forms.ComboBox();
            this.timezoneLabel = new System.Windows.Forms.Label();
            this.customTimezoneCheckBox = new System.Windows.Forms.CheckBox();
            this.getClipboardBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datePicker.CalendarFont = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Checked = false;
            this.datePicker.CustomFormat = "dd-MMM-yyyy, ddd @ HH:mm";
            this.datePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.datePicker.Font = new System.Drawing.Font("Rockwell", 15.75F);
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(48, 78);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(406, 32);
            this.datePicker.TabIndex = 0;
            this.datePicker.Value = new System.DateTime(2021, 10, 11, 21, 42, 55, 0);
            // 
            // eventTimeLabel
            // 
            this.eventTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventTimeLabel.AutoSize = true;
            this.eventTimeLabel.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventTimeLabel.Location = new System.Drawing.Point(44, 55);
            this.eventTimeLabel.Name = "eventTimeLabel";
            this.eventTimeLabel.Size = new System.Drawing.Size(119, 20);
            this.eventTimeLabel.TabIndex = 1;
            this.eventTimeLabel.Text = "Event Time";
            // 
            // timezonePicker
            // 
            this.timezonePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timezonePicker.DropDownHeight = 150;
            this.timezonePicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timezonePicker.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timezonePicker.FormattingEnabled = true;
            this.timezonePicker.IntegralHeight = false;
            this.timezonePicker.ItemHeight = 21;
            this.timezonePicker.Items.AddRange(new object[] {
            "-12:00",
            "-11:00",
            "-10:00",
            "-09:00",
            "-08:00",
            "-07:00",
            "-06:00",
            "-05:00",
            "-04:00",
            "-03:00",
            "-02:00",
            "-01:00",
            " 00:00",
            "+01:00",
            "+02:00",
            "+03:00",
            "+04:00",
            "+05:00",
            "+06:00",
            "+07:00",
            "+08:00",
            "+09:00",
            "+10:00",
            "+11:00",
            "+12:00",
            "+13:00",
            "+14:00"});
            this.timezonePicker.Location = new System.Drawing.Point(273, 116);
            this.timezonePicker.MaxLength = 6;
            this.timezonePicker.Name = "timezonePicker";
            this.timezonePicker.Size = new System.Drawing.Size(181, 29);
            this.timezonePicker.TabIndex = 2;
            // 
            // timezoneLabel
            // 
            this.timezoneLabel.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timezoneLabel.Location = new System.Drawing.Point(44, 116);
            this.timezoneLabel.Name = "timezoneLabel";
            this.timezoneLabel.Size = new System.Drawing.Size(223, 29);
            this.timezoneLabel.TabIndex = 3;
            this.timezoneLabel.Text = "Timezone in UTC/GMT";
            this.timezoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customTimezoneCheckBox
            // 
            this.customTimezoneCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customTimezoneCheckBox.Font = new System.Drawing.Font("Roboto Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTimezoneCheckBox.Location = new System.Drawing.Point(273, 151);
            this.customTimezoneCheckBox.Name = "customTimezoneCheckBox";
            this.customTimezoneCheckBox.Size = new System.Drawing.Size(181, 19);
            this.customTimezoneCheckBox.TabIndex = 4;
            this.customTimezoneCheckBox.Text = "set custom timezone";
            this.customTimezoneCheckBox.UseVisualStyleBackColor = true;
            this.customTimezoneCheckBox.CheckedChanged += new System.EventHandler(this.customTimezoneCheckBox_CheckedChanged);
            // 
            // getClipboardBtn
            // 
            this.getClipboardBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getClipboardBtn.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getClipboardBtn.Location = new System.Drawing.Point(48, 13);
            this.getClipboardBtn.Name = "getClipboardBtn";
            this.getClipboardBtn.Size = new System.Drawing.Size(406, 27);
            this.getClipboardBtn.TabIndex = 5;
            this.getClipboardBtn.Text = "Paste Time Info from Clipboard";
            this.getClipboardBtn.UseVisualStyleBackColor = true;
            // 
            // mainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 331);
            this.Controls.Add(this.getClipboardBtn);
            this.Controls.Add(this.customTimezoneCheckBox);
            this.Controls.Add(this.timezoneLabel);
            this.Controls.Add(this.timezonePicker);
            this.Controls.Add(this.eventTimeLabel);
            this.Controls.Add(this.datePicker);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "mainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timezone Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label eventTimeLabel;
        private System.Windows.Forms.ComboBox timezonePicker;
        private System.Windows.Forms.Label timezoneLabel;
        private System.Windows.Forms.CheckBox customTimezoneCheckBox;
        private System.Windows.Forms.Button getClipboardBtn;
    }
}

