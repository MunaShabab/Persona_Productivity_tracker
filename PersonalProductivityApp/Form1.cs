using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalProductivityApp
{
    public partial class PersonalProductivityApp : Form
    {
        int categoryCount = 0;
        private List<string> categoryNames = new List<string>();
        private List<int> timeSpentList = new List<int>();

        public PersonalProductivityApp()
        {
            InitializeComponent();
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            //determine if some text had been entered for the category textBox
            if (categoryTextBox.Text != "")
            {
                //increas the number of the categories every time the addCategoryButton is clicked
                categoryCount++;

                //if the number of categories is less than or equal to 6
                if (categoryCount <= 6)
                {
                    //create a new radio Button a assign it the name enterd by the user
                    var rdb = new RadioButton();
                    rdb.Text = categoryTextBox.Text;
                    //add the name of the category to the categoryName list
                    categoryNames.Add(categoryTextBox.Text);
                    
                    //add the radio button to the group box
                    categoryGroupBox.Controls.Add(value: rdb);
                    
                    //this will allign the radio button the top of the group box
                    rdb.Dock = DockStyle.Bottom;
                    categoryTextBox.Text = "";
                    timeSpentList.Add(0);

                }
                else
                {
                    MessageBox.Show("you can have up to six categories");
                }
                
            }
            else
            {
                MessageBox.Show("You must enter a category name!");
            }
            
            
        }

        private void PersonalProductivityApp_Load(object sender, EventArgs e)
        {

        }

        private void recordActivityButton_Click(object sender, EventArgs e)
        {
            //get the time from the date time picker and convert it to universal time
            DateTime beginTime=beginDateTimePicker.Value;
            DateTime endTime=endDateTimePicker.Value;

            //get the time in minutes, we can ignore the seconds
            int beginTimeInt = (beginTime.Hour * 60) + beginTime.Minute;
            int endTimeInt= (endTime.Hour * 60) + endTime.Minute;
            

            //calculate the time spent
            int timeSpent = endTimeInt-beginTimeInt;
            if (timeSpent < 0)
            {
                MessageBox.Show("Beginning time must be earlier than ending time");
            }

            else
            {
                //store the categories in a list
                var categories = categoryGroupBox.Controls.OfType<RadioButton>().ToList();
                //find out which radio button is selected 
                
                RadioButton rbSelected = categoryGroupBox.Controls
                             .OfType<RadioButton>()
                             .FirstOrDefault(r => r.Checked);
                //if a button is selected
                if(rbSelected!=null)
                {
                    for (int i = 0; i < categories.Count; ++i)
                    {
                        
                        if (categories[i] == rbSelected)
                        {
                            //make sure the category and the time spent are correct
                            //MessageBox.Show(categories[i].Text +timeSpent.ToString());
                            timeSpentList[i] += timeSpent;
                        }

                        
                    }

                }

                //if no button is selected propmt the user
                else
                {
                    MessageBox.Show("you must select a category");
                }


            }
            

            
        }

        private void showDailyButton_Click(object sender, EventArgs e)
        {
            //clear the label from previous data
            dailyActivityLabel.Text = "";
            //loop through the lists showing the name of each category and the time spent
            for (int i=0;i<categoryCount;++i)
            {
                dailyActivityLabel.Text += categoryNames[i]+" : "+timeSpentList[i].ToString()+" minutes\n" ;
            }
        }

        private void analysisButton_Click(object sender, EventArgs e)
        {
            //create varables to hold the data
            int minTime = timeSpentList.Min();
            int minIndex = timeSpentList.FindIndex(n => n== minTime);
            
            int maxTime = timeSpentList.Max();
            int maxIndex = timeSpentList.FindIndex(n => n == maxTime);
            double avgTime = timeSpentList.Average();
            int totalTime = timeSpentList.Sum();

            string minTimeCategory=categoryNames[minIndex];
            string maxTimeCategory=categoryNames[maxIndex];

            

            //clear the label from previous data
            analysisLabel.Text = "";
            //display the results
            analysisLabel.Text = "Least time spent is " + minTime.ToString() + " in " + minTimeCategory + " minutes\n" +
                "most time spent is " + maxTime.ToString() + " in " + maxTimeCategory + " minutes\n" +
                "avarage time spent is " + avgTime.ToString() +" minutes\n" +
                "total time spent is " + totalTime.ToString()+ " minutes";
                

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dailyActivityLabel.Text = "";
            analysisLabel.Text = "";

        }

        private void categoryTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
