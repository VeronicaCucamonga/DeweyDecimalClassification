using System;
using System.Collections.Generic;
using System.Text;

namespace DeweyDecimalClassification.TreeClass
{
    //----------CODE ATTRIBUTION----------
    //Name: Beginning Data Structures and Algorithms in C# : Basic Trees | packtpub.com
    //Publisher: Packt
    //Date: 8 October 2018
    //URL: https://youtu.be/K0-qs--naUo
    //This code preforms creates the dewey decimal tree
    public class CallNumbers
    {
        public string CallNum { get; set; }
        public string Description { get; set; }

        public CallNumbers() { }

        public CallNumbers(string callNum, string description)
        {
            CallNum = callNum;
            Description = description;
        }
    }
    //----------CODE ATTRIBUTION ENDS----------
}
