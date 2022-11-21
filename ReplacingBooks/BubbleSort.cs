using System;
using System.Collections.Generic;
using System.Text;

namespace DeweyDecimalClassification.ReplacingBooks
{
    //bubble sorting algorithm
    public class BubbleSort
    {
        ListClass listClass = new ListClass();

        //----------CODE ATTRIBUTION----------
        //Name: C# Sharp Exercises: Sorts the strings of an array using bubble sort
        //Publisher: W3Resources
        //Date: 19 August 2022
        //URL: https://www.w3resource.com/csharp-exercises/string/csharp-string-exercise-12.php
        //This code preforms bubble sorting algorithm 
        public void preformBubbleSort()
        {
            string temp;

            for (int i = 0; i < listClass.GetNoList().Count; i++)
            {
                for (int j = 0; j < listClass.GetNoList().Count - 1; j++)
                {
                    if (listClass.GetNoList()[j].CompareTo(listClass.GetNoList()[j + 1]) > 0)
                    {
                        temp = listClass.GetNoList()[j];
                        listClass.GetNoList()[j] = listClass.GetNoList()[j + 1];
                        listClass.GetNoList()[j + 1] = temp;
                    }
                }
            }
        }
        //----------CODE ATTRIBUTION ENDS----------
    }
}

