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
    public partial class IdentifyAreas : Form
    {
        //Random 
        private static Random random = new Random();

        IdentifyingAreas.DictionaryClass dictionaryClass = new IdentifyingAreas.DictionaryClass();

        private static int points = 0;


        public IdentifyAreas()
        {
            InitializeComponent();
        }

        private void IdentifyAreas_Load(object sender, EventArgs e)
        {
            dictionaryClass.GetAreaDict().Clear();
            dictionaryClass.GetNewDict().Clear();
       

            //loops through the callNo list to get 4 random call numbers and their descriptions. 
            generateAndLoad();

        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            int count = 0;
            //----------CODE ATTRIBUTION----------
            //Name: How to get selected text and selected value of comboBox in C#
            //Publisher: Programming for Everybody
            //Date: 18 October 2021
            //URL: https://youtu.be/18Z9v7jkERw
            //This code preforms getting the combobox selected text
            string callNo1 = cmbCallNo_1.GetItemText(cmbCallNo_1.SelectedItem);
            string callNo2 = cmbCallNo_2.GetItemText(cmbCallNo_2.SelectedItem);
            string callNo3 = cmbCallNo_3.GetItemText(cmbCallNo_3.SelectedItem);
            string callNo4 = cmbCallNo_4.GetItemText(cmbCallNo_4.SelectedItem);

            string description1 = cmbDescription_1.GetItemText(cmbDescription_1.SelectedItem);
            string description2 = cmbDescription_2.GetItemText(cmbDescription_2.SelectedItem);
            string description3 = cmbDescription_3.GetItemText(cmbDescription_3.SelectedItem);
            string description4 = cmbDescription_4.GetItemText(cmbDescription_4.SelectedItem);
            //----------CODE ATTRIBUTION ENDS----------

            //error handling if combobox is null
            if (callNo1.Equals("") || callNo2.Equals("") || callNo3.Equals("") || callNo4.Equals("") || description1.Equals("") ||
                description2.Equals("") || description3.Equals("") || description4.Equals(""))
            {
                MessageBox.Show("Empty Values are Not Allowed!");
            }
            //error handling if there is duplicates for call numbers
            else if ((callNo1 == callNo2) || (callNo1 == callNo3) || (callNo1 == callNo4) || (callNo2 == callNo3) || 
                (callNo2 == callNo4) || (callNo3 == callNo4))
            {
                MessageBox.Show("Duplicates are Not Allowed!!!\nTry Reseting the Page");
            }
            //error handling if there is duplicates for descriptions
            else if ((description1 == description2) || (description1 == description3) || (description1 == description4) 
                || (description2 == description3) || (description2 == description4) || (description3 == description4))
            {
                MessageBox.Show("Duplicates are Not Allowed!!!\nTry Reseting the Page");
            }
            //if everything is correct
            else
            {

                //adds new values to newAreas dictionary
                dictionaryClass.GetNewDict().Add(callNo1, description1);
                dictionaryClass.GetNewDict().Add(callNo2, description2);
                dictionaryClass.GetNewDict().Add(callNo3, description3);
                dictionaryClass.GetNewDict().Add(callNo4, description4);

                //----------CODE ATTRIBUTION----------
                //Name: How to compare two dictionaries in C#?
                //Publisher: TutorialsPoint
                //Date: n.d.
                //URL: https://www.tutorialspoint.com/How-to-compare-two-dictionaries-in-Chash
                //This code compares the two dictionaries created the areas and usersAreas dictionaries 
                bool equal = false;
                foreach (var pair in dictionaryClass.GetAreaDict())
                {
                    string value;
                    if (dictionaryClass.GetNewDict().TryGetValue(pair.Key, out value))
                    {
                        if (value != pair.Value)
                        {
                            equal = false;
                            break;
                        }
                        
                    }
                    else
                    {
                        count+=1;

                    }

                }
                //----------CODE ATTRIBUTION ENDS----------

                if (count >= 4)
                {
                    MessageBox.Show(Convert.ToString(count));
                    //if 4 or more are correct it displays this message and adds points
                    MessageBox.Show("Congratulations!!! You Have Identified the areas correctly!\nHeres some points for your score.");

                    points += 4;
                    lblScore.Text = Convert.ToString(points);

                    clearBoxes();

                    //calls method to restart the application
                    generateAndLoad();

                }

                else if (equal == false)
                {
                    //if something is wrong displays error message
                    MessageBox.Show("Sorry, One of the Items is do not matched. \nPlease Try Again!");
                    dictionaryClass.GetNewDict().Clear();
                }

            }

            }

        //method to restart the game if the information is correct
        private void generateAndLoad()
        {
            dictionaryClass.GetAreaDict().Clear();
            dictionaryClass.AddAreas();

            for (int i = 0; i < 4; i++)
            {
                //avoid repitition
                int index;

                index = random.Next(dictionaryClass.GetAreaDict().Count);

                KeyValuePair<string, string> pair = dictionaryClass.GetAreaDict().ElementAt(index);

                cmbCallNo_1.Items.Add(pair.Key);
                cmbCallNo_2.Items.Add(pair.Key);
                cmbCallNo_3.Items.Add(pair.Key);
                cmbCallNo_4.Items.Add(pair.Key);

                cmbDescription_1.Items.Add(pair.Value);
                cmbDescription_2.Items.Add(pair.Value);
                cmbDescription_3.Items.Add(pair.Value);
                cmbDescription_4.Items.Add(pair.Value);

                dictionaryClass.GetAreaDict().Remove(dictionaryClass.GetAreaDict().ElementAt(index).Key);
            }

            for(int i = 0; i<3; i++)
            {
                int index = random.Next(dictionaryClass.GetAreaDict().Count);

                KeyValuePair<string, string> pair = dictionaryClass.GetAreaDict().ElementAt(index);

                cmbDescription_1.Items.Add(pair.Value);
                cmbDescription_2.Items.Add(pair.Value);
                cmbDescription_3.Items.Add(pair.Value);
                cmbDescription_4.Items.Add(pair.Value);
            }

        }

        private void clearBoxes()
        {
            //clears combobox items
            cmbCallNo_1.Items.Clear();
            cmbDescription_1.Items.Clear();
            cmbCallNo_2.Items.Clear();
            cmbCallNo_3.Items.Clear();
            cmbCallNo_4.Items.Clear();
            cmbDescription_2.Items.Clear();
            cmbDescription_3.Items.Clear();
            cmbDescription_4.Items.Clear();
            //clears the combobox text
            cmbCallNo_1.ResetText();
            cmbDescription_1.ResetText();
            cmbCallNo_2.ResetText();
            cmbCallNo_3.ResetText();
            cmbCallNo_4.ResetText();
            cmbDescription_2.ResetText();
            cmbDescription_3.ResetText();
            cmbDescription_4.ResetText();
            dictionaryClass.GetNewDict().Clear();
        }
        
    }
}
    

