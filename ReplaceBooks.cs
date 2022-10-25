using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeweyDecimalClassification
{
    public partial class ReplaceBooks : Form
    {
        private static Random random = new Random();

        //Lists 
        private static List<string> callNos = new List<string>();
        private static List<string> userSort = new List<string>();
        private static List<string> sortedNos = new List<string>();

        private static int points = 0;

        public ReplaceBooks()
        {
            InitializeComponent();
        }

        //----------CODE ATTRIBUTION----------
        //Name: C# Random [Step By Step Tutorial for using C# Random] - Generate Random Numbers, Random Strings etc.
        //Publisher: Coding Droplets
        //Date: 30 March 2021
        //URL: https://youtu.be/Zql7tz5Pzfg
        //This code generated a random call number
        private static string GenerateRandomNo(int stringLength)
        {
            //generates random String
            const string allowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var randomString = new string(Enumerable.Repeat(allowedChars, stringLength)
                .Select(a => a[random.Next(a.Length)]).ToArray());

            //generates random numbers
            var randomNumber1 = random.Next(100, 999);
            var randomNumber2 = random.Next(10, 99);

            //joins the random string and number to make a call number
            string randomNumber = randomNumber1 + "." + randomNumber2 + " " + randomString;
            //adds the call number to the list
            callNos.Add(randomNumber);

            return randomNumber;
        }


        //displays 10 random call numbers when page loads
        private void ReplaceBooks_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                var randomNo = GenerateRandomNo(3);
                ltbNumbers.Items.Add(randomNo);
            }

        }
        //----------CODE ATTRIBUTION ENDS----------


        //----------CODE ATTRIBUTION----------
        //Name: ListBox Sort One Item and Move One Or Multiple items in c# sharp
        //Publisher: GnsCode
        //Date: 31 March 2020
        //URL: https://youtu.be/8KjE9q077dUPzfg
        //This code moves items in one list box to the other for rearranging
        private void mRightBtn_Click(object sender, EventArgs e)
        {
            //when button is clicked the user can select an item they want to reorder to the second listbox
            while (ltbNumbers.SelectedItems.Count != 0)
            {
                ltbArrange.Items.Add(ltbNumbers.SelectedItems[0]);
                ltbNumbers.Items.Remove(ltbNumbers.SelectedItems[0]);
            }
        }


        private void mLeftBtn_Click(object sender, EventArgs e)
        {
            //when button is clicked the user can select an item and move it to the first listbox
            while (ltbArrange.SelectedItems.Count != 0)
            {
                ltbNumbers.Items.Add(ltbArrange.SelectedItems[0]);
                ltbArrange.Items.Remove(ltbArrange.SelectedItems[0]);
            }
        }
        //----------CODE ATTRIBUTION ENDS----------


        //----------CODE ATTRIBUTION----------
        //Name: C# Sharp Exercises: Sorts the strings of an array using bubble sort
        //Publisher: W3Resources
        //Date: 19 August 2022
        //URL: https://www.w3resource.com/csharp-exercises/string/csharp-string-exercise-12.php
        //This code preforms bubble sorting algorithm 
        private void checkBtn_Click(object sender, EventArgs e)
        {
            ltbCheck.Items.Clear();
            sortedNos.Clear();

            string temp;

            for (int i = 0; i < callNos.Count; i++)
            {
                for (int j = 0; j < callNos.Count - 1; j++)
                {
                    if (callNos[j].CompareTo(callNos[j + 1]) > 0)
                    {
                        temp = callNos[j];
                        callNos[j] = callNos[j + 1];
                        callNos[j + 1] = temp;
                    }
                }
            }


            for (int i = 0; i < callNos.Count; i++)
            {
                ltbCheck.Items.Add(callNos[i]);
                sortedNos.Add(callNos[i]);
            }

        }
        //----------CODE ATTRIBUTION ENDS----------


        private void saveBtn_Click(object sender, EventArgs e)
        {
            

            //error handling
            if (ltbArrange.Items.Count == 0)
            {
                MessageBox.Show("Please Rearrange the Numbers");
            }
            else if (ltbCheck.Items.Count == 0)
            {
                MessageBox.Show("Please Click The Double Check Button");
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    //converts users reordered items to string and stores them into list
                    userSort.Add(ltbArrange.Items[i].ToString());
                }

                //checks if the two lists sequences are the same
                bool equal = Enumerable.SequenceEqual(userSort, sortedNos);

                if (equal)
                {
                    //user gets it right they receive 10 points
                    MessageBox.Show("Congratulations!\nYour Call Numbers Are Ordered!\nHere is 10 points");
                   
                    points += 10;
                    lblScore.Text = Convert.ToString(points);

                    //clear listboxes
                    ltbArrange.Items.Clear();
                    ltbCheck.Items.Clear();
                    userSort.Clear();
                    sortedNos.Clear();
                    callNos.Clear();

                    //generate new 10 numbers
                    for (int i = 0; i < 10; i++)
                    {
                        var randomNo = GenerateRandomNo(3);
                        ltbNumbers.Items.Add(randomNo);
                    }
                }
                else
                {
                    //user gets it wrong they try again
                    MessageBox.Show("Try Again!\nYour Call Numbers Are Not Ordered!");
                }
            }
            //lists are cleared after each test
            userSort.Clear();
            sortedNos.Clear();
            
        }

        private void ltbArrange_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
