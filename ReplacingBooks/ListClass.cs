using System;
using System.Collections.Generic;
using System.Text;

namespace DeweyDecimalClassification
{
    //all lists used for replacing books
    public class ListClass
    {
        //Lists 
        public static List<string> callNos = new List<string>();
        public static List<string> userSort = new List<string>();
        public static List<string> sortedNos = new List<string>();

        public List<string> GetNoList()
        {
            return callNos;
        }
        public List<string> GetUserList()
        {
            return userSort;
        }
        public List<string> GetSortList()
        {
            return sortedNos;
        }
    }
}
