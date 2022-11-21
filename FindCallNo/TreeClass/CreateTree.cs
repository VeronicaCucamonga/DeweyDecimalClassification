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
    public class CreateTree
    {
        FindCallNo.FindCallNoList fcn = new FindCallNo.FindCallNoList();
        
        public void makeTree()
        {
            
            //-----------PARENT--------------
            Tree<CallNumbers> tree = new Tree<CallNumbers>();
            tree.Root = new TreeNode<CallNumbers>() { Data = new CallNumbers("Dewey", "Dewey") };


            //-----------TOP LEVEL--------------
            tree.Root.Children = new List<TreeNode<CallNumbers>>
            {                                                                                                             //Parent and Child
                new TreeNode<CallNumbers>(){Data = new CallNumbers("100", "Philosophy & Psychology"), Parent = tree.Root},// [0]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("200", "Religion"), Parent = tree.Root},               // [1]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("300", "Social Sciences"), Parent = tree.Root},        // [2]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("400", "Language"), Parent = tree.Root},               // [3]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("500", "Science"), Parent = tree.Root}                 // [4]
            };


            //-----------SECOND LEVEL--------------
            tree.Root.Children[0].Children = new List<TreeNode<CallNumbers>>()                                                                            //Philosophy & Psychology Children
            {                                                                                                                                             // Parent and Child
                new TreeNode<CallNumbers>(){Data = new CallNumbers("110", "Metaphysics"), Parent = tree.Root.Children[0]},                                //[0], [0]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("120", "Epistemology"), Parent = tree.Root.Children[0]},                               //[1], [0]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("130", "Parapsychology and occultism"), Parent = tree.Root.Children[0]},               //[2], [0]   
                new TreeNode<CallNumbers>(){Data = new CallNumbers("140", "Philosophical schools of thought"), Parent = tree.Root.Children[0]},           //[3], [0]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("150", "Psychology"), Parent = tree.Root.Children[0]}                                  //[4], [0]   
            };

            tree.Root.Children[1].Children = new List<TreeNode<CallNumbers>>()                                                        //Religon Children
            {                                                                                                                    // Parent and Child
                new TreeNode<CallNumbers>(){Data = new CallNumbers("210", "Philosophy and theory of religion"), Parent = tree.Root.Children[1]},          //[0], [1]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("220", "The Bible"), Parent = tree.Root.Children[1]},                                  //[1], [1]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("230", "Christianity"), Parent = tree.Root.Children[1]},                               //[2], [1]   
                new TreeNode<CallNumbers>(){Data = new CallNumbers("240", "Christian practice and observance"), Parent = tree.Root.Children[1]},          //[3], [1]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("240", "Christian orders and local church"), Parent = tree.Root.Children[1]}           //[4], [1]   
            };

            tree.Root.Children[2].Children = new List<TreeNode<CallNumbers>>()                                                        //Social Science Children
            {                                                                                                                    // Parent and Child
                new TreeNode<CallNumbers>(){Data = new CallNumbers("310", "Statistics"), Parent = tree.Root.Children[2]},                                 //[0], [2]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("320", "Political Science"), Parent = tree.Root.Children[2]},                          //[1], [2]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("330", "Economics"), Parent = tree.Root.Children[2]},                                  //[2], [2]   
                new TreeNode<CallNumbers>(){Data = new CallNumbers("340", "Law"), Parent = tree.Root.Children[2]},                                        //[3], [2]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("350", "Public administration and military science"), Parent = tree.Root.Children[2]}  //[4], [2]   
            };

            tree.Root.Children[3].Children = new List<TreeNode<CallNumbers>>()                                                        //Language Children
            {                                                                                                                    // Parent and Child
                new TreeNode<CallNumbers>(){Data = new CallNumbers("410", "Linguistics"), Parent = tree.Root.Children[3]},                                //[0], [3]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("420", "English and old English languages"), Parent = tree.Root.Children[3]},          //[1], [3]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("430", "German and related languages"), Parent = tree.Root.Children[3]},               //[2], [3]   
                new TreeNode<CallNumbers>(){Data = new CallNumbers("440", "French and related languages"), Parent = tree.Root.Children[3]},               //[3], [3]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("450", "Italian, Romanian, and related languages"), Parent = tree.Root.Children[3]}    //[4], [3]   
            };

            tree.Root.Children[4].Children = new List<TreeNode<CallNumbers>>()                                                        //Science Children
            {                                                                                                                    // Parent and Child
                new TreeNode<CallNumbers>(){Data = new CallNumbers("510", "Mathematics"), Parent = tree.Root.Children[4]},                                //[0], [4]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("520", "Astronomy"), Parent = tree.Root.Children[4]},                                  //[1], [4]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("530", "Physics"), Parent = tree.Root.Children[4]},                                    //[2], [4]   
                new TreeNode<CallNumbers>(){Data = new CallNumbers("540", "Chemistry"), Parent = tree.Root.Children[4]},                                  //[3], [4]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("550", "Earth Science and geology"), Parent = tree.Root.Children[4]}                   //[4], [4]   
            };


            //-----------THIRD LEVEL--------------

            //Philosophy & Psychology Children Children
            tree.Root.Children[0].Children[0].Children = new List<TreeNode<CallNumbers>>()                                                        //Philosophy & Psychology Children Children, Metaphysics
            {                                                                                                                                // Child - Leaf
                new TreeNode<CallNumbers>(){Data = new CallNumbers("111", "Ontology"), Parent = tree.Root.Children[0].Children[0]},                                   //[0], [0], [0]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("113", "Cosmology"), Parent = tree.Root.Children[0].Children[0]},                                  //[1], [0], [0]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("114", "Space"), Parent = tree.Root.Children[0].Children[0]}                                       //[2], [0], [0] 
            };

            tree.Root.Children[0].Children[1].Children = new List<TreeNode<CallNumbers>>()                                                        //Philosophy & Psychology Children Children, Epistemology
            {                                                                                                                                // Child - Leaf
                new TreeNode<CallNumbers>(){Data = new CallNumbers("121", "Epistemology (Theory of knowledge)"), Parent = tree.Root.Children[0].Children[1]},         //[0], [1], [0]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("122", "Causation"), Parent = tree.Root.Children[0].Children[1]},                                  //[1], [1], [0]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("123", "Determinism and indeterminism"), Parent = tree.Root.Children[0].Children[1]}               //[2], [1], [0] 
            };

            tree.Root.Children[0].Children[2].Children = new List<TreeNode<CallNumbers>>()                                                                                               //Philosophy & Psychology Children Children, Parapsychology and occultism
            {                                                                                                                                                                       // Child - Leaf
                new TreeNode<CallNumbers>(){Data = new CallNumbers("131", "Parapsychological and occult methods for achieving well-being, happiness, success"), Parent = tree.Root.Children[0].Children[2]}, //[0], [2], [0]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("133", "Specific topics in parapsychology and occultism"), Parent = tree.Root.Children[0].Children[2]},                                   //[1], [2], [0]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("135", "Dreams and mysteries"), Parent = tree.Root.Children[0].Children[2]}                                                               //[2], [2], [0] 
            };

            tree.Root.Children[0].Children[3].Children = new List<TreeNode<CallNumbers>>()                                                        //Philosophy & Psychology Children Children, Philosophical schools of thought
            {                                                                                                                                // Child - Leaf
                new TreeNode<CallNumbers>(){Data = new CallNumbers("141", "Idealism and related systems and doctrines"), Parent = tree.Root.Children[0].Children[3]}, //[0], [3], [0]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("142", "Critical philosophy"), Parent = tree.Root.Children[0].Children[3]},                        //[1], [3], [0]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("143", "Bergsonism and intuitionism"), Parent = tree.Root.Children[0].Children[3]}                 //[2], [3], [0] 
            };

            tree.Root.Children[0].Children[4].Children = new List<TreeNode<CallNumbers>>()                                                                              //Philosophy & Psychology Children Children, Psychology
            {                                                                                                                                                      // Child - Leaf
                new TreeNode<CallNumbers>(){Data = new CallNumbers("152", "Sensory perception, movement, emotions, and physiological drives"), Parent = tree.Root.Children[0].Children[4]}, //[0], [4], [0]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("153", "Conscious mental processes and intelligence"), Parent = tree.Root.Children[0].Children[4]},                      //[1], [4], [0]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("154", "Subconscious and altered states and processes"), Parent = tree.Root.Children[0].Children[4]}                     //[2], [4], [0] 
            };

            //Religon Children Children
            tree.Root.Children[1].Children[0].Children = new List<TreeNode<CallNumbers>>()                                                               //Religon Children Children, Philosophy and theory of religion
            {                                                                                                                                       // Child - Leaf
                new TreeNode<CallNumbers>(){Data = new CallNumbers("211", "Concepts of God"), Parent = tree.Root.Children[1].Children[0]},                                   //[0], [0], [1]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("212", "Existence, ways of knowing God, attributes of God"), Parent = tree.Root.Children[1].Children[0]}, //[1], [0], [1]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("213", "Creation"), Parent = tree.Root.Children[1].Children[0]}                                           //[2], [0], [1] 
            };

            tree.Root.Children[1].Children[1].Children = new List<TreeNode<CallNumbers>>()                                                        //Religon Children Children, Epistemology
            {                                                                                                                                // Child - Leaf
                new TreeNode<CallNumbers>(){Data = new CallNumbers("221", "Old Testament (Tanakh)"), Parent = tree.Root.Children[1].Children[1]},                     //[0], [1], [1]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("222", "Historical books of Old Testament"), Parent = tree.Root.Children[1].Children[1]},          //[1], [1], [1]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("223", "Poetic books of Old Testament"), Parent = tree.Root.Children[1].Children[1]}               //[2], [1], [1] 
            };

            tree.Root.Children[1].Children[2].Children = new List<TreeNode<CallNumbers>>()                                          //Religon Children Children, Parapsychology and occultism
            {                                                                                                                  // Child - Leaf
                new TreeNode<CallNumbers>(){Data = new CallNumbers("231", "God"), Parent = tree.Root.Children[1].Children[2]},                          //[0], [2], [1]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("232", "Jesus Christ and his family"), Parent = tree.Root.Children[1].Children[2]},  //[1], [2], [1]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("233", "Humankind"), Parent = tree.Root.Children[1].Children[2]}                     //[2], [2], [1] 
            };

            tree.Root.Children[1].Children[3].Children = new List<TreeNode<CallNumbers>>()                                                               //Religon Children Children, Philosophical schools of thought
            {                                                                                                                                       // Child - Leaf
                new TreeNode<CallNumbers>(){Data = new CallNumbers("241", "Christian ethics"), Parent = tree.Root.Children[1].Children[3]},                                  //[0], [3], [1]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("242", "Devotional literature"), Parent = tree.Root.Children[1].Children[3]},                             //[1], [3], [1]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("243", "Evangelistic writings for individuals and families"), Parent = tree.Root.Children[1].Children[3]} //[2], [3], [1] 
            };

            tree.Root.Children[1].Children[4].Children = new List<TreeNode<CallNumbers>>()                                                         //Religon Children Children, Psychology
            {                                                                                                                                 // Child - Leaf
                new TreeNode<CallNumbers>(){Data = new CallNumbers("251", "Preaching (Homiletics)"), Parent = tree.Root.Children[1].Children[4]},                      //[0], [4], [1]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("252", "Texts of sermons"), Parent = tree.Root.Children[1].Children[4]},                            //[1], [4], [1]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("253", "Pastoral office and work (Pastoral theology)"), Parent = tree.Root.Children[1].Children[4]} //[2], [4], [1] 
            };

            //Social Science Children Children
            tree.Root.Children[2].Children[0].Children = new List<TreeNode<CallNumbers>>()                                                               //Social Science Children Children, Philosophy and theory of religion
            {                                                                                                                                       // Child - Leaf
                new TreeNode<CallNumbers>(){Data = new CallNumbers("314", "General statistics of Europe"), Parent = tree.Root.Children[2].Children[0]},                      //[0], [0], [2]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("315", "General statistics of Asia"), Parent = tree.Root.Children[2].Children[0]},                        //[1], [0], [2]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("316", "General statistics of Africa"), Parent = tree.Root.Children[2].Children[0]}                       //[2], [0], [2] 
            };

            tree.Root.Children[2].Children[1].Children = new List<TreeNode<CallNumbers>>()                                                                     //Social Science Children Children, Epistemology
            {                                                                                                                                             // Child - Leaf
                new TreeNode<CallNumbers>(){Data = new CallNumbers("321", "Systems of governments and states"), Parent = tree.Root.Children[2].Children[1]},                       //[0], [1], [2]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("322", "Relation of state to organized groups and their members"), Parent = tree.Root.Children[2].Children[1]}, //[1], [1], [2]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("323", "Civil and political rights"), Parent = tree.Root.Children[2].Children[1]}                               //[2], [1], [2] 
            };

            tree.Root.Children[2].Children[2].Children = new List<TreeNode<CallNumbers>>()                                          //Social Science Children Children, Parapsychology and occultism
            {                                                                                                                  // Child - Leaf
                new TreeNode<CallNumbers>(){Data = new CallNumbers("331", "Labour economics"), Parent = tree.Root.Children[2].Children[2]},             //[0], [2], [2]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("332", "Financial economics"), Parent = tree.Root.Children[2].Children[2]},          //[1], [2], [2]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("333", "Economics of land and energy"), Parent = tree.Root.Children[2].Children[2]}  //[2], [2], [2] 
            };

            tree.Root.Children[2].Children[3].Children = new List<TreeNode<CallNumbers>>()                                                                                                      //Social Science Children Children, Philosophical schools of thought
            {                                                                                                                                                                              // Child - Leaf
                new TreeNode<CallNumbers>(){Data = new CallNumbers("341", "Law of nations"), Parent = tree.Root.Children[2].Children[3]},                                                                           //[0], [3], [2]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("342", "Constitutional and administrative law"), Parent = tree.Root.Children[2].Children[3]},                                                    //[1], [3], [2]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("343", "Military, defense, public property, public finance, tax, commerce (trade), industrial law"), Parent = tree.Root.Children[2].Children[3]} //[2], [3], [2] 
            };

            tree.Root.Children[2].Children[4].Children = new List<TreeNode<CallNumbers>>()                                                               //Social Science Children Children, Psychology
            {                                                                                                                                       // Child - Leaf
                new TreeNode<CallNumbers>(){Data = new CallNumbers("351", "Public administration"), Parent = tree.Root.Children[2].Children[4]},                             //[0], [4], [2]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("352", "General considerations of public administration"), Parent = tree.Root.Children[2].Children[4]},   //[1], [4], [2]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("353", "Specific fields of public administration"), Parent = tree.Root.Children[2].Children[4]}           //[2], [4], [2] 
            };

            //Language  Children Children
            tree.Root.Children[3].Children[0].Children = new List<TreeNode<CallNumbers>>()                                                               //Language Children Children, Philosophy and theory of religion
            {                                                                                                                                       // Child - Leaf
                new TreeNode<CallNumbers>(){Data = new CallNumbers("411", "Writing systems of standard forms of languages"), Parent = tree.Root.Children[3].Children[0]},    //[0], [0], [3]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("412", "Etymology of standard forms of languages"), Parent = tree.Root.Children[3].Children[0]},          //[1], [0], [3]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("413", "Dictionaries of standard forms of languages"), Parent = tree.Root.Children[3].Children[0]}        //[2], [0], [3] 
            };

            tree.Root.Children[3].Children[1].Children = new List<TreeNode<CallNumbers>>()                                                                      //Language Children Children, Epistemology
            {                                                                                                                                              // Child - Leaf
                new TreeNode<CallNumbers>(){Data = new CallNumbers("421", "Writing system, phonology, phonetics of standard English"), Parent = tree.Root.Children[3].Children[1]}, //[0], [1], [3]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("422", "Etymology of standard English"), Parent = tree.Root.Children[3].Children[1]},                            //[1], [1], [3]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("423", "Dictionaries of standard English"), Parent = tree.Root.Children[3].Children[1]}                          //[2], [1], [3] 
            };

            tree.Root.Children[3].Children[2].Children = new List<TreeNode<CallNumbers>>()                                                                         //Language Children Children, Parapsychology and occultism
            {                                                                                                                                                 // Child - Leaf
                new TreeNode<CallNumbers>(){Data = new CallNumbers("431", "Writing systems, phonology, phonetics of standard German"), Parent = tree.Root.Children[3].Children[2]},    //[0], [2], [3]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("432", "Etymology of standard German"), Parent = tree.Root.Children[3].Children[2]},                                //[1], [2], [3]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("433", "Dictionaries of standard German"), Parent = tree.Root.Children[3].Children[2]}                              //[2], [2], [3] 
            };

            tree.Root.Children[3].Children[3].Children = new List<TreeNode<CallNumbers>>()                                                                      //Language Children Children, Philosophical schools of thought
            {                                                                                                                                              // Child - Leaf
                new TreeNode<CallNumbers>(){Data = new CallNumbers("441", "Writing systems, phonology, phonetics of standard French"), Parent = tree.Root.Children[3].Children[3]}, //[0], [3], [3]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("442", "Etymology of standard French"), Parent = tree.Root.Children[3].Children[3]},                             //[1], [3], [3]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("443", "Dictionaries of standard French"), Parent = tree.Root.Children[3].Children[3]}                           //[2], [3], [3] 
            };

            tree.Root.Children[3].Children[4].Children = new List<TreeNode<CallNumbers>>()                                                                        //Language Children Children, Psychology
            {                                                                                                                                                // Child - Leaf
                new TreeNode<CallNumbers>(){Data = new CallNumbers("451", "Writing systems, phonology, phonetics of standard Italian"), Parent = tree.Root.Children[3].Children[4]},  //[0], [4], [3]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("452", "Etymology of standard Italian"), Parent = tree.Root.Children[3].Children[4]},                              //[1], [4], [3]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("453", "Dictionaries of standard Italian"), Parent = tree.Root.Children[3].Children[4]}                            //[2], [4], [3] 
            };

            //Science  Children Children
            tree.Root.Children[4].Children[0].Children = new List<TreeNode<CallNumbers>>()                                                  //Science Children Children, Philosophy and theory of religion
            {                                                                                                                          // Child - Leaf
                new TreeNode<CallNumbers>(){Data =  new CallNumbers("511", "General principles of mathematics"), Parent = tree.Root.Children[4].Children[0]},    //[0], [0], [4]
                new TreeNode<CallNumbers>(){Data =  new CallNumbers("512", "Algebra"), Parent = tree.Root.Children[4].Children[0]},                              //[1], [0], [4]
                new TreeNode<CallNumbers>(){Data =  new CallNumbers("513", "Arithmetic"), Parent = tree.Root.Children[4].Children[0]}                            //[2], [0], [4] 
            };

            tree.Root.Children[4].Children[1].Children = new List<TreeNode<CallNumbers>>()                                                                      //Science Children Children, Epistemology
            {                                                                                                                                              // Child - Leaf
                new TreeNode<CallNumbers>(){Data = new CallNumbers("521", "Celestial mechanics"), Parent = tree.Root.Children[4].Children[1]}, //[0], [1], [4]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("522", "Techniques, procedures, apparatus, equipment, materials"), Parent = tree.Root.Children[4].Children[1]},                            //[1], [1], [4]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("523", "Specific celestial bodies and phenomena"), Parent = tree.Root.Children[4].Children[1]}                          //[2], [1], [4] 
            };

            tree.Root.Children[4].Children[2].Children = new List<TreeNode<CallNumbers>>()                                       //Science Children Children, Parapsychology and occultism
            {                                                                                                               // Child - Leaf
                new TreeNode<CallNumbers>(){Data = new CallNumbers("531", "Classical mechanics"), Parent = tree.Root.Children[4].Children[2]},       //[0], [2], [4]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("532", "Fluid mechanics"), Parent = tree.Root.Children[4].Children[2]},           //[1], [2], [4]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("533", "Pneumatics (Gas mechanics)"), Parent = tree.Root.Children[4].Children[2]} //[2], [2], [4] 
            };

            tree.Root.Children[4].Children[3].Children = new List<TreeNode<CallNumbers>>()                                                                      //Science Children Children, Philosophical schools of thought
            {                                                                                                                                              // Child - Leaf
                new TreeNode<CallNumbers>(){Data = new CallNumbers("541", "Physical chemistry"), Parent = tree.Root.Children[4].Children[3]},                                       //[0], [3], [4]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("542", "Techniques, procedures, apparatus, equipment, materials"), Parent = tree.Root.Children[4].Children[3]},  //[1], [3], [4]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("543", "Analytical chemistry"), Parent = tree.Root.Children[4].Children[3]}                                      //[2], [3], [4] 
            };

            tree.Root.Children[4].Children[4].Children = new List<TreeNode<CallNumbers>>()                                                                        //Science Children Children, Psychology
            {                                                                                                                                                // Child - Leaf
                new TreeNode<CallNumbers>(){Data = new CallNumbers("551", "Geology, hydrology, meteorology"), Parent = tree.Root.Children[4].Children[4]},  //[0], [4], [4]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("552", "Petrology"), Parent = tree.Root.Children[4].Children[4]},                              //[1], [4], [4]
                new TreeNode<CallNumbers>(){Data = new CallNumbers("553", "Economic geology"), Parent = tree.Root.Children[4].Children[4]}                            //[2], [4], [4] 
            };

        }

        
    }
    //----------CODE ATTRIBUTION ENDS----------
}
