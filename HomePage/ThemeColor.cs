using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DeweyDecimalClassification
{
    //----------CODE ATTRIBUTION----------
    //Name: Modern Flat UI, Random MultiColor, Highlight button-Active Form, WinForm, C#, V-0.1
    //Publisher: RJ Code Advance EN
    //Date: 13 December 2019
    //URL: https://youtu.be/BtOEztT1Qzk
    //This code handles the home page form
    public static class ThemeColor
    {
        //list of different colours
        public static List<string> ColorList = new List<string>()
        {
            "#3F5185",
            "#009688",
            "#FF5722",
            "#607D8B",
            "#FF9800",
            "#9C27B0",
            "#2196F3",
            "#EA676C",
            "#E41A4A"
        };

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
    //----------CODE ATTRIBUTION ENDS----------
}
