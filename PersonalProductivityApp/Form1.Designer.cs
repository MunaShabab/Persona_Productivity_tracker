namespace PersonalProductivityApp
{
    partial class PersonalProductivityApp
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
            this.categoryPromptLable = new System.Windows.Forms.Label();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.categoryGroupBox = new System.Windows.Forms.GroupBox();
            this.selectCategoryLabel = new System.Windows.Forms.Label();
            this.beginDateTimeLabel = new System.Windows.Forms.Label();
            this.beginDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTime = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.recordActivityButton = new System.Windows.Forms.Button();
            this.showDailyButton = new System.Windows.Forms.Button();
            this.analysisButton = new System.Windows.Forms.Button();
            this.dailyActivityLabel = new System.Windows.Forms.Label();
            this.analysisLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // categoryPromptLable
            // 
            this.categoryPromptLable.AutoSize = true;
            this.categoryPromptLable.Location = new System.Drawing.Point(70, 50);
            this.categoryPromptLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.categoryPromptLable.Name = "categoryPromptLable";
            this.categoryPromptLable.Size = new System.Drawing.Size(307, 31);
            this.categoryPromptLable.TabIndex = 0;
            this.categoryPromptLable.Text = "Please enter a category ";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(390, 50);
            this.categoryTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(216, 38);
            this.categoryTextBox.TabIndex = 1;
            this.categoryTextBox.TextChanged += new System.EventHandler(this.categoryTextBox_TextChanged);
            // 
            // categoryGroupBox
            // 
            this.categoryGroupBox.Location = new System.Drawing.Point(135, 167);
            this.categoryGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.categoryGroupBox.Name = "categoryGroupBox";
            this.categoryGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.categoryGroupBox.Size = new System.Drawing.Size(399, 330);
            this.categoryGroupBox.TabIndex = 4;
            this.categoryGroupBox.TabStop = false;
            this.categoryGroupBox.Text = "Categories";
            // 
            // selectCategoryLabel
            // 
            this.selectCategoryLabel.AutoSize = true;
            this.selectCategoryLabel.Location = new System.Drawing.Point(108, 118);
            this.selectCategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectCategoryLabel.Name = "selectCategoryLabel";
            this.selectCategoryLabel.Size = new System.Drawing.Size(463, 31);
            this.selectCategoryLabel.TabIndex = 5;
            this.selectCategoryLabel.Text = "Select one of the following categories";
            // 
            // beginDateTimeLabel
            // 
            this.beginDateTimeLabel.AutoSize = true;
            this.beginDateTimeLabel.Location = new System.Drawing.Point(568, 218);
            this.beginDateTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.beginDateTimeLabel.Name = "beginDateTimeLabel";
            this.beginDateTimeLabel.Size = new System.Drawing.Size(440, 31);
            this.beginDateTimeLabel.TabIndex = 6;
            this.beginDateTimeLabel.Text = "select the beginnning date and time";
            // 
            // beginDateTimePicker
            // 
            this.beginDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.beginDateTimePicker.Location = new System.Drawing.Point(1024, 218);
            this.beginDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.beginDateTimePicker.Name = "beginDateTimePicker";
            this.beginDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.beginDateTimePicker.ShowUpDown = true;
            this.beginDateTimePicker.Size = new System.Drawing.Size(259, 38);
            this.beginDateTimePicker.TabIndex = 7;
            // 
            // endDateTime
            // 
            this.endDateTime.AutoSize = true;
            this.endDateTime.Location = new System.Drawing.Point(576, 326);
            this.endDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endDateTime.Name = "endDateTime";
            this.endDateTime.Size = new System.Drawing.Size(389, 31);
            this.endDateTime.TabIndex = 8;
            this.endDateTime.Text = "select the ending date and time";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endDateTimePicker.Location = new System.Drawing.Point(1024, 319);
            this.endDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.ShowUpDown = true;
            this.endDateTimePicker.Size = new System.Drawing.Size(259, 38);
            this.endDateTimePicker.TabIndex = 9;
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Location = new System.Drawing.Point(638, 50);
            this.addCategoryButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(236, 56);
            this.addCategoryButton.TabIndex = 10;
            this.addCategoryButton.Text = "Add Category";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // recordActivityButton
            // 
            this.recordActivityButton.Location = new System.Drawing.Point(784, 392);
            this.recordActivityButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.recordActivityButton.Name = "recordActivityButton";
            this.recordActivityButton.Size = new System.Drawing.Size(260, 64);
            this.recordActivityButton.TabIndex = 11;
            this.recordActivityButton.Text = "Record Activity";
            this.recordActivityButton.UseVisualStyleBackColor = true;
            this.recordActivityButton.Click += new System.EventHandler(this.recordActivityButton_Click);
            // 
            // showDailyButton
            // 
            this.showDailyButton.Location = new System.Drawing.Point(251, 524);
            this.showDailyButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.showDailyButton.Name = "showDailyButton";
            this.showDailyButton.Size = new System.Drawing.Size(333, 65);
            this.showDailyButton.TabIndex = 12;
            this.showDailyButton.Text = "Show Daily Activity";
            this.showDailyButton.UseVisualStyleBackColor = true;
            this.showDailyButton.Click += new System.EventHandler(this.showDailyButton_Click);
            // 
            // analysisButton
            // 
            this.analysisButton.Location = new System.Drawing.Point(697, 524);
            this.analysisButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.analysisButton.Name = "analysisButton";
            this.analysisButton.Size = new System.Drawing.Size(324, 61);
            this.analysisButton.TabIndex = 14;
            this.analysisButton.Text = "Analysis";
            this.analysisButton.UseVisualStyleBackColor = true;
            this.analysisButton.Click += new System.EventHandler(this.analysisButton_Click);
            // 
            // dailyActivityLabel
            // 
            this.dailyActivityLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dailyActivityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyActivityLabel.Location = new System.Drawing.Point(178, 609);
            this.dailyActivityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dailyActivityLabel.Name = "dailyActivityLabel";
            this.dailyActivityLabel.Size = new System.Drawing.Size(452, 237);
            this.dailyActivityLabel.TabIndex = 15;
            // 
            // analysisLabel
            // 
            this.analysisLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.analysisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analysisLabel.Location = new System.Drawing.Point(638, 609);
            this.analysisLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.analysisLabel.Name = "analysisLabel";
            this.analysisLabel.Size = new System.Drawing.Size(489, 239);
            this.analysisLabel.TabIndex = 16;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(492, 874);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(296, 61);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "Clear Data";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // PersonalProductivityApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1323, 996);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.analysisLabel);
            this.Controls.Add(this.dailyActivityLabel);
            this.Controls.Add(this.analysisButton);
            this.Controls.Add(this.showDailyButton);
            this.Controls.Add(this.recordActivityButton);
            this.Controls.Add(this.addCategoryButton);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.endDateTime);
            this.Controls.Add(this.beginDateTimePicker);
            this.Controls.Add(this.beginDateTimeLabel);
            this.Controls.Add(this.selectCategoryLabel);
            this.Controls.Add(this.categoryGroupBox);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.categoryPromptLable);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PersonalProductivityApp";
            this.RightToLeftLayout = true;
            this.Text = "Personal Productivity App";
            this.Load += new System.EventHandler(this.PersonalProductivityApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label categoryPromptLable;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.GroupBox categoryGroupBox;
        private System.Windows.Forms.Label selectCategoryLabel;
        private System.Windows.Forms.Label beginDateTimeLabel;
        private System.Windows.Forms.DateTimePicker beginDateTimePicker;
        private System.Windows.Forms.Label endDateTime;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.Button recordActivityButton;
        private System.Windows.Forms.Button showDailyButton;
        private System.Windows.Forms.Button analysisButton;
        private System.Windows.Forms.Label dailyActivityLabel;
        private System.Windows.Forms.Label analysisLabel;
        private System.Windows.Forms.Button clearButton;
    }
}

