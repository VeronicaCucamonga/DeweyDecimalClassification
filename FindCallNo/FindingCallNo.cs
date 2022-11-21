
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DeweyDecimalClassification.TreeClass;

namespace DeweyDecimalClassification
{
    public partial class FindingCallNo : Form
    {
        //random created
        private static Random random = new Random();
        private static string actualAnswer;
        private static int points = 0;

        //my list of call numbers used
        private static List<string> callNos = new List<string>
        { "100", "200", "300", "400", "500" };

        //calling classes
        CreateTree createTree = new CreateTree();
        IdentifyingAreas.DictionaryClass dictionary = new IdentifyingAreas.DictionaryClass();
        FindCallNo.FindCallNoList findCallNoList = new FindCallNo.FindCallNoList();

        public FindingCallNo()
        {
            InitializeComponent();
            //creates the tree
            createTree.makeTree();
            //clearing dictionary before adding the call numbers and description 
            dictionary.GetAreaDict().Clear();
            dictionary.AddAreas();
        }

        //when form is loaded
        private void FindingCallNo_Load(object sender, EventArgs e)
        {
            
            //called method
            loadDescAndCallNum();

        }

        //when check button is clicked
        private void checkBtn_Click(object sender, EventArgs e)
        {
            //called method checkIfCorrect
            checkIfCorrect();
        }

        //method generates the third level description and displays the top level call numbers and description
        private void loadDescAndCallNum()
        {
            //calls method that gets random index number for description from the FindCallNoList class
            findCallNoList.getRandomDescription();

            //clears the callNos List and repopulates the list 
            callNos.Clear();
            callNos.Add("100");
            callNos.Add("200");
            callNos.Add("300");
            callNos.Add("400");
            callNos.Add("500");

            //clears the combo box before adding anything new
            comboBox1.Items.Clear();

            
            //displays the description on the label
            descriptionLbl.Text = findCallNoList.decriptionLabel;

            //if the index number is equal 1 then it must add the top level call number and desc to combobox and so on for 2, 3, 4...
            if (findCallNoList.number == 1)
            {
                comboBox1.Items.Add(callNos[0] + " " + dictionary.GetAreaDict()[callNos[0]]);
                callNos.Remove(callNos[0]);
            }
            else if (findCallNoList.number == 2)
            {
                comboBox1.Items.Add(callNos[1] + " " + dictionary.GetAreaDict()[callNos[1]]);
                callNos.Remove(callNos[1]);
            }
            else if (findCallNoList.number == 3)
            {
                comboBox1.Items.Add(callNos[2] + " " + dictionary.GetAreaDict()[callNos[2]]);
                callNos.Remove(callNos[2]);
            }
            else if (findCallNoList.number == 4)
            {
                comboBox1.Items.Add(callNos[3] + " " + dictionary.GetAreaDict()[callNos[3]]);
                callNos.Remove(callNos[3]);
            }
            else if (findCallNoList.number == 5)
            {
                comboBox1.Items.Add(callNos[4] + " " + dictionary.GetAreaDict()[callNos[4]]);
                callNos.Remove(callNos[4]);
            }

            //randomly add 3 more call numbers and desc to the combobox
            for (int i = 0; i < 3; i++)
            {
                int number = random.Next(callNos.Count());
                //add to combo box
                comboBox1.Items.Add(callNos[number] + " " + dictionary.GetAreaDict()[callNos[number]]);

                //remove it from list avoid repeats
                callNos.Remove(callNos[number]);

            }
        }

        //method that checks if users answer is correct to actual answer
        private void checkIfCorrect()
        {
            //clears the callNos List and repopulates the list 
            callNos.Clear();
            callNos.Add("100");
            callNos.Add("200");
            callNos.Add("300");
            callNos.Add("400");
            callNos.Add("500");

            string expectedAnswer;

            //if the description label shown to user belongs to one of the 5 lists then the expected answer is dependent which list its from
            //eg if the description label is 131 it belongs to the 100s leafnode list and the expected answer should be 100 Philosaphy and Psychology
            if (findCallNoList.Get100LeafList().Contains(findCallNoList.decriptionLabel))
            {
                //call method check users actual answer
                checkActualAnswer();

                expectedAnswer = callNos[0];
                //check if they are equal or not
                if (actualAnswer != expectedAnswer)
                {
                    MessageBox.Show("Sorry This Is Not Correct\nTry Again!!!");
                    //wrong answer - restart
                    loadDescAndCallNum();
                }
                else
                {
                    MessageBox.Show("Congratulations!!! You Have Identified the areas correctly!\nHeres a point for your score.");
                    //right answer - add point
                    points++;
                    lblScore.Text = Convert.ToString(points);
                    loadSecondDescAndCallNum();
                }
            }
            else if (findCallNoList.Get200LeafList().Contains(findCallNoList.decriptionLabel))
            {
                checkActualAnswer();
                expectedAnswer = callNos[1];
                if (actualAnswer != expectedAnswer)
                {
                    MessageBox.Show("Sorry this is not Correct\nTry Again!!!");
                    loadDescAndCallNum();
                }
                else
                {
                    MessageBox.Show("Congratulations!!! You Have Identified the areas correctly!\nHeres a point for your score.");
                    points++;
                    lblScore.Text = Convert.ToString(points);
                    loadSecondDescAndCallNum();
                }
            }
            else if (findCallNoList.Get300LeafList().Contains(findCallNoList.decriptionLabel))
            {
                checkActualAnswer();
                expectedAnswer = callNos[2];
                if (actualAnswer != expectedAnswer)
                {
                    MessageBox.Show("Sorry this is not Correct\nTry Again!!!");
                    loadDescAndCallNum();
                }
                else
                {
                    MessageBox.Show("Congratulations!!! You Have Identified the areas correctly!\nHeres a point for your score.");
                    points++;
                    lblScore.Text = Convert.ToString(points);
                    loadSecondDescAndCallNum();
                }
            }
            else if (findCallNoList.Get400LeafList().Contains(findCallNoList.decriptionLabel))
            {
                checkActualAnswer();
                expectedAnswer = callNos[3];
                if (actualAnswer != expectedAnswer)
                {
                    MessageBox.Show("Sorry this is not Correct\nTry Again!!!");
                    loadDescAndCallNum();
                }
                else
                {
                    MessageBox.Show("Congratulations!!! You Have Identified the areas correctly!\nHeres a point for your score.");
                    points++;
                    lblScore.Text = Convert.ToString(points);
                    loadSecondDescAndCallNum();
                }
            }
            else if (findCallNoList.Get500LeafList().Contains(findCallNoList.decriptionLabel))
            {
                checkActualAnswer();
                expectedAnswer = callNos[4];
                if (actualAnswer != expectedAnswer)
                {
                    MessageBox.Show("Sorry this is not Correct\nTry Again!!!");
                    loadDescAndCallNum();
                }
                else
                {
                    MessageBox.Show("Congratulations!!! You Have Identified the areas correctly!\nHeres a point for your score.");
                    points++;
                    lblScore.Text = Convert.ToString(points);
                    loadSecondDescAndCallNum();
                }
            }
        }

        //method that determines the actual answer
        private void checkActualAnswer()
        {
            //we get the users actual answer from the combobox in string format
            string actualAnswerFromBox = comboBox1.GetItemText(comboBox1.SelectedItem);
            
            //if the answer chosen is equal to index 0 of the callNos list then the actual answer is so 
            //eg users answer is 500 Science then the answer is index 4 of callNos so we can match the callNo index of the expected answer
            if(actualAnswerFromBox.Equals(callNos[0] + " " + dictionary.GetAreaDict()[callNos[0]]))
            {
                actualAnswer = callNos[0];
            }
            else if (actualAnswerFromBox.Equals(callNos[1] + " " + dictionary.GetAreaDict()[callNos[1]]))
            {
                actualAnswer = callNos[1];
            }
            else if (actualAnswerFromBox.Equals(callNos[2] + " " + dictionary.GetAreaDict()[callNos[2]]))
            {
                actualAnswer = callNos[2];
            }
            else if (actualAnswerFromBox.Equals(callNos[3] + " " + dictionary.GetAreaDict()[callNos[3]]))
            {
                actualAnswer = callNos[3];
            }
            else if (actualAnswerFromBox.Equals(callNos[4] + " " + dictionary.GetAreaDict()[callNos[4]]))
            {
                actualAnswer = callNos[4];
            }
            
        }

        private void loadSecondDescAndCallNum()
        {
            //if the index number is equal 1 then it must add the top level call number and desc to combobox and so on for 2, 3, 4...
            if (findCallNoList.number == 1)
            {
                comboBox1.Items.Clear();

                for (int i = 0; i<3; i++)
                {
                    int number = random.Next(findCallNoList.Get100List().Count());
                    //add to combo box
                    comboBox1.Items.Add(findCallNoList.Get100List()[number]);

                }
                
            }
            else if (findCallNoList.number == 2)
            {
                comboBox1.Items.Clear(); 

                for (int i = 0; i < 3; i++)
                {
                    int number = random.Next(findCallNoList.Get200List().Count());
                    //add to combo box
                    comboBox1.Items.Add(findCallNoList.Get200List()[number]);

                }
            }
            else if (findCallNoList.number == 3)
            {
                comboBox1.Items.Clear();

                for (int i = 0; i < 3; i++)
                {
                    int number = random.Next(findCallNoList.Get300List().Count());
                    //add to combo box
                    comboBox1.Items.Add(findCallNoList.Get300List()[number]);

                }
            }
            else if (findCallNoList.number == 4)
            {
                comboBox1.Items.Clear();

                for (int i = 0; i < 3; i++)
                {
                    int number = random.Next(findCallNoList.Get400List().Count());
                    //add to combo box
                    comboBox1.Items.Add(findCallNoList.Get400List()[number]);

                }
            }
            else if (findCallNoList.number == 5)
            {
                comboBox1.Items.Clear(); 

                for (int i = 0; i < 3; i++)
                {
                    int number = random.Next(findCallNoList.Get500List().Count());
                    //add to combo box
                    comboBox1.Items.Add(findCallNoList.Get500List()[number]);

                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            loadDescAndCallNum();
                
        }
    }
}
