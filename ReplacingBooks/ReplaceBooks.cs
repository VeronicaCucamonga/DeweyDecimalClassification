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

        //calling methods from different classes
        ReplacingBooks.GenerateRandom generateRandom = new ReplacingBooks.GenerateRandom();
        ListClass listClass = new ListClass();
        ReplacingBooks.BubbleSort bubbleSort = new ReplacingBooks.BubbleSort();

        private static int points = 0;

        public ReplaceBooks()
        {
            InitializeComponent();
        }


        //displays 10 random call numbers when page loads
        private void ReplaceBooks_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 10; i++)
            {
                var randomNo = generateRandom.GenerateRandomNo(3);
                ltbNumbers.Items.Add(randomNo);
            }

        }


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


        //bubble sorts the numbers and displays it
        private void checkBtn_Click(object sender, EventArgs e)
        {
            ltbCheck.Items.Clear();
            listClass.GetSortList().Clear(); 

            bubbleSort.preformBubbleSort();

            for (int i = 0; i < listClass.GetNoList().Count; i++)
            {
                ltbCheck.Items.Add(listClass.GetNoList()[i]);
                listClass.GetSortList().Add(listClass.GetNoList()[i]);
            }

        }

        //checks to see if order is right
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
                    listClass.GetUserList().Add(ltbArrange.Items[i].ToString());
                }

                //checks if the two lists sequences are the same
                bool equal = Enumerable.SequenceEqual(listClass.GetUserList(), listClass.GetSortList());

                if (equal)
                {
                    //user gets it right they receive 10 points
                    MessageBox.Show("Congratulations!\nYour Call Numbers Are Ordered!\nHere is 10 points");
                   
                    points += 10;
                    lblScore.Text = Convert.ToString(points);

                    //clear listboxes
                    ltbArrange.Items.Clear();
                    ltbCheck.Items.Clear();
                    listClass.GetUserList().Clear();
                    listClass.GetSortList().Clear();
                    listClass.GetNoList().Clear();

                    //generate new 10 numbers
                    for (int i = 0; i < 10; i++)
                    {
                        var randomNo = generateRandom.GenerateRandomNo(3);
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
            listClass.GetUserList().Clear();
            listClass.GetSortList().Clear();
            
        }
    }
}
