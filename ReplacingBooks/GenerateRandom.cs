using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeweyDecimalClassification.ReplacingBooks
{
    //generate random call numbers
    public class GenerateRandom
    {
        private static Random random = new Random();
        ListClass listClass = new ListClass();

        //----------CODE ATTRIBUTION----------
        //Name: C# Random [Step By Step Tutorial for using C# Random] - Generate Random Numbers, Random Strings etc.
        //Publisher: Coding Droplets
        //Date: 30 March 2021
        //URL: https://youtu.be/Zql7tz5Pzfg
        //This code generated a random call number
        public string GenerateRandomNo(int stringLength)
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
            listClass.GetNoList().Add(randomNumber); 

            return randomNumber;
        }

        //----------CODE ATTRIBUTION ENDS----------
    }
}
