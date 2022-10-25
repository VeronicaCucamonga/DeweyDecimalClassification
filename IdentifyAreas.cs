using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DeweyDecimalClassification
{
    public partial class IdentifyAreas : Form
    {
        //Random 
        private static Random random = new Random();

        private static List<string> callNos = new List<string>
        {"000", "100", "200", "300", "400", "500", "600", "700", "800", "900" };
        private static List<string> desc = new List<string>
        {"General Knowledge", "Philosophy & Psychology", "Religion", "Social sciences", "Languages", "Science",
            "Technology", "Arts & Recreation", "Literature", "History & Geography" };
        private static List<string> generatedDesc = new List<string>();
        private static List<string> generatedCallNo = new List<string>();

        //Dictionaries 
        private static Dictionary<string, string> newAreas = new Dictionary<string, string>();
        private static Dictionary<string, string> areas = new Dictionary<string, string>();

        private static int points = 0;


        public IdentifyAreas()
        {
            InitializeComponent();

        }

        private void IdentifyAreas_Load(object sender, EventArgs e)
        {
            //----------CODE ATTRIBUTION----------
            //Name: PROG7312 - Dictionary
            //Publisher: VCSOIT
            //Date: 16 September 2020
            //URL: https://youtu.be/KTtcPbhpOtE
            //This code preforms storing the identify areas into dictionary
            areas.Add("000", "General Knowledge");
            areas.Add("100", "Philosophy & Psycology");
            areas.Add("200", "Religion");
            areas.Add("300", "Social Sciences");
            areas.Add("400", "Languages");
            areas.Add("500", "Science");
            areas.Add("600", "Technology");
            areas.Add("700", "Arts & Recreation");
            areas.Add("800", "Literature");
            areas.Add("900", "History & Geography");
            //----------CODE ATTRIBUTION ENDS----------

            //loops through the callNo list to get 4 random call numbers and their descriptions. 
            for (int i = 0; i < 4; i++)
            {
                //randomly picks number from callNo List
                int number = random.Next(callNos.Count);
                //adds it to the list box
                lsbCallNumbers.Items.Add(callNos[number]);

                //finds the value using the key in the dictionary and adds it to generated description list
                generatedDesc.Add(areas[callNos[number]]);

                //removes description from the desc list to avoid repetition
                desc.Remove(areas[callNos[number]]);

                //moves them to generated call number list
                generatedCallNo.Add(callNos[number]);

                //adds to comboboxes
                cmbNo1.Items.Add(callNos[number]);
                cmbNo2.Items.Add(callNos[number]);
                cmbNo3.Items.Add(callNos[number]);
                cmbNo4.Items.Add(callNos[number]);

                //removes call number from the callNo list to avoid repetition
                callNos.Remove(callNos[number]);

            }

            //randomly picks 3 extra descriptions and adds it to the generated decription list
            for (int i = 0; i < 3; i++)
            {
                int description = random.Next(desc.Count);
                generatedDesc.Add(desc[description]);
                desc.Remove(desc[description]);
            }

            //displays the generated List 
            for (int i = 0; i < 7; i++)
            {
                //displays it  without repetition in the list box 
                int description = random.Next(generatedDesc.Count);
                lsbDescriptions.Items.Add(generatedDesc[description]);

                //adds it to the combo boxes
                cmbDesc1.Items.Add(generatedDesc[description]);
                cmbDesc2.Items.Add(generatedDesc[description]);
                cmbDesc3.Items.Add(generatedDesc[description]);
                cmbDesc4.Items.Add(generatedDesc[description]);

                //removes it to avoid repitition
                generatedDesc.Remove(generatedDesc[description]);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //----------CODE ATTRIBUTION----------
            //Name: How to get selected text and selected value of comboBox in C#
            //Publisher: Programming for Everybody
            //Date: 18 October 2021
            //URL: https://youtu.be/18Z9v7jkERw
            //This code preforms getting the combobox selected text
            string call1 = cmbNo1.GetItemText(cmbNo1.SelectedItem);
            string call2 = cmbNo2.GetItemText(cmbNo2.SelectedItem);
            string call3 = cmbNo3.GetItemText(cmbNo3.SelectedItem);
            string call4 = cmbNo4.GetItemText(cmbNo4.SelectedItem);
            string desc1 = cmbDesc1.GetItemText(cmbDesc1.SelectedItem);
            string desc2 = cmbDesc2.GetItemText(cmbDesc2.SelectedItem);
            string desc3 = cmbDesc3.GetItemText(cmbDesc3.SelectedItem);
            string desc4 = cmbDesc4.GetItemText(cmbDesc4.SelectedItem);
            //----------CODE ATTRIBUTION ENDS----------

            //error handling if combobox is null
            if (call1.Equals("") || call2.Equals("") || call3.Equals("") || call4.Equals("") || desc1.Equals("") ||
                desc2.Equals("") || desc3.Equals("") || desc4.Equals(""))
            {
                MessageBox.Show("Empty Values are Not Allowed!");
            }
            //error handling if there is duplicates for call numbers
            else if ((call1 == call2) || (call1 == call3) || (call1 == call4) || (call2 == call3) || (call2 == call4)
                || (call3 == call4))
            {
                MessageBox.Show("Duplicates are Not Allowed!!!");
            }
            //error handling if there is duplicates for descriptions
            else if ((desc1 == desc2) || (desc1 == desc3) || (desc1 == desc4) || (desc2 == desc3) || (desc2 == desc4)
                || (desc3 == desc4))
            {
                MessageBox.Show("Duplicates are Not Allowed!!!");
            }
            //if everything is correct
            else
            {
                //clears the newAreas dictionary
                newAreas.Clear();
                //adds new values to newAreas dictionary
                newAreas.Add(call1, desc1);
                newAreas.Add(call2, desc2);
                newAreas.Add(call3, desc3);
                newAreas.Add(call4, desc4);

                int count = 0;
                bool exist = true;

                foreach (var itemA in areas)
                {
                    if (!newAreas.ContainsKey(itemA.Key) && !newAreas.ContainsValue(itemA.Value))
                    {
                        exist = false;
                    }
                    else if(!itemA.Value.Equals(newAreas[itemA.Key]))
                    {
                        MessageBox.Show("Sorry, One of the Items is do not matched. \nPlease Try Again!");
                    }
                    else
                    {
                        //if correct it counts how many is correct
                        count++;
                    }
                }

                if (count >= 4)
                {
                    //if 4 or more are correct it displays this message and adds points
                    MessageBox.Show("Congratulations!!! You Have Identified the areas correctly!\nHeres some points for your score.");

                    points += 4;
                    lblScore.Text = Convert.ToString(points);

                    //clears listbox items
                    lsbCallNumbers.Items.Clear();
                    lsbDescriptions.Items.Clear();
                    //clears combobox items
                    cmbNo1.Items.Clear();
                    cmbDesc1.Items.Clear();
                    cmbNo2.Items.Clear();
                    cmbNo3.Items.Clear();
                    cmbNo4.Items.Clear();
                    cmbDesc2.Items.Clear();
                    cmbDesc3.Items.Clear();
                    cmbDesc4.Items.Clear();
                    //clears the combobox text
                    cmbNo1.ResetText();
                    cmbDesc1.ResetText();
                    cmbNo2.ResetText();
                    cmbNo3.ResetText();
                    cmbNo4.ResetText();
                    cmbDesc2.ResetText();
                    cmbDesc3.ResetText();
                    cmbDesc4.ResetText();
                    //clears the dictionary and lists
                    callNos.Clear();
                    desc.Clear();
                    generatedDesc.Clear();
                    generatedCallNo.Clear();
                    newAreas.Clear();

                    //calls method to restart the application
                    generateAndLoad();
                }
                else if(exist == false)
                {
                    //if something is wrong displays error message
                    MessageBox.Show("Sorry, One of the Items is do not matched. \nPlease Try Again!");
                }

            }

        }

        //method to restart the game if the information is correct
        private void generateAndLoad()
        {
          List<string> callNos = new List<string>
           {"000", "100", "200", "300", "400", "500", "600", "700", "800", "900" };

          List<string> desc = new List<string>
           {"General Knowledge", "Philosophy & Psychology", "Religion", "Social sciences", "Languages", "Science",
            "Technology", "Arts & Recreation", "Literature", "History & Geography" };


            for (int i = 0; i < 4; i++)
            {
                //randomly picks number from callNo List
                int number = random.Next(callNos.Count);
                //adds it to the list box
                lsbCallNumbers.Items.Add(callNos[number]);

                //finds the value using key in the dictionary
                generatedDesc.Add(areas[callNos[number]]);

                //removes description from the desc list to avoid repetition
                desc.Remove(areas[callNos[number]]);

                //moves them to generated call number 
                generatedCallNo.Add(callNos[number]);

                //adds to combobox
                cmbNo1.Items.Add(callNos[number]);
                cmbNo2.Items.Add(callNos[number]);
                cmbNo3.Items.Add(callNos[number]);
                cmbNo4.Items.Add(callNos[number]);

                //removes call number from the callNo list to avoid repetition
                callNos.Remove(callNos[number]);

            }

            for (int i = 0; i < 3; i++)
            {
                int description = random.Next(desc.Count);
                generatedDesc.Add(desc[description]);
                desc.Remove(desc[description]);
            }

            //displays the generated List 

            for (int i = 0; i < 7; i++)
            {
                //displays it  without repetition in the list box 
                int description = random.Next(generatedDesc.Count);
                lsbDescriptions.Items.Add(generatedDesc[description]);

                //adds it to the combo boxes
                cmbDesc1.Items.Add(generatedDesc[description]);
                cmbDesc2.Items.Add(generatedDesc[description]);
                cmbDesc3.Items.Add(generatedDesc[description]);
                cmbDesc4.Items.Add(generatedDesc[description]);

                //removes it to avoid repitition
                generatedDesc.Remove(generatedDesc[description]);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
