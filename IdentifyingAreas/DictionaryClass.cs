using System;
using System.Collections.Generic;
using System.Text;

namespace DeweyDecimalClassification.IdentifyingAreas
{
    public class DictionaryClass
    {
        //Dictionaries 
        public static Dictionary<string, string> newAreas = new Dictionary<string, string>();
        public static Dictionary<string, string> areas = new Dictionary<string, string>();

        public Dictionary<string, string> GetAreaDict()
        {
            return areas;
        }

        public Dictionary<string, string> GetNewDict()
        {
            return newAreas;
        }

        public void AddAreas()
        {
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
        }

        
    }
}
