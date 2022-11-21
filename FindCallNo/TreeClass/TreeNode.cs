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
    public class TreeNode<T>
    {
        public T Data { get; set; }
        public TreeNode<T> Parent { get; set; }
        public List<TreeNode<T>> Children { get; set; }
        public int GetHeight()
        {
            int height = 1;
            TreeNode<T> current = this;
            while(current.Parent != null)
            {
                height++;
                current = current.Parent;
            }
            return height;
        }
    }
    //----------CODE ATTRIBUTION ENDS----------

}
