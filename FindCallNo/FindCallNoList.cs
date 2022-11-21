using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeweyDecimalClassification.FindCallNo
{
    public class FindCallNoList
    {
        private static Random random = new Random();
        public string decriptionLabel;
        public int index;
        public int secondIndex;
        public int number;

        public static List<string> leafNodeshundred = new List<string>()
        {
             "Ontology",  "Cosmology",  " Space",
             "Epistemology (Theory of knowledge)", "Causation", " Determinism and indeterminism", 
             "Parapsychological and occult methods for achieving well-being, happiness, success", 
             "Specific topics in parapsychology and occultism", "Dreams and mysteries", 
             "Idealism and related systems and doctrines", "Critical philosophy", "Bergsonism and intuitionism",
             "Sensory perception, movement, emotions, and physiological drives", 
             "Conscious mental processes and intelligence", "Subconscious and altered states and processes"
        };

        public static List<string> leafNodestwohun = new List<string>()
        {
            "Concepts of God", "Existence, ways of knowing God, attributes of God", "Creation", "Old Testament",
            "Historical books of Old Testament", "Poetic books of Old Testament", "God", "Jesus Christ and his family", 
            "Humankind", "Christian ethics", "Devotional literature", "Evangelistic writings for individuals and families", 
            "Preaching (Homiletics)", "Texts of sermons", "Pastoral office and work (Pastoral theology)"
        };

        public static List<string> leafNodesthrehun = new List<string>()
        {
            "General statistics of Europe", "General statistics of Asia", "General statistics of Africa", 
            "Systems of governments and states", "Relation of state to organized groups and their members", 
            "Civil and political rights", "Labor economics", "Financial economics", "Economics of land and energy", 
            "Law of nations", "Constitutional and administrative law", 
            "Military, defense, public property, public finance, tax, commerce (trade), industrial law", 
            "Public administration", "General considerations of public administration", 
            "Specific fields of public administration"
        };

        public static List<string> leafNodesfourhun = new List<string>()
        {
            "Writing systems of standard forms of languages", "Etymology of standard forms of languages", 
            "Dictionaries of standard forms of languages", 
            "Dictionaries of standard English", "Writing system, phonology, phonetics of standard English", 
            "Etymology of standard English", "Dictionaries of standard German", "Writing systems, phonology, phonetics of standard German", 
            "Etymology of standard German", " Writing systems, phonology, phonetics of standard French", "Etymology of standard French", 
            "Dictionaries of standard French", "Writing systems, phonology, phonetics of standard Italian", 
            "Etymology of standard Italian", "Dictionaries of standard Italian"
        };

        public static List<string> leafNodesfivehun = new List<string>()
        {
            "Mathematics", "General principles of mathematics", "Algebra", "Celestial mechanics", 
            "Techniques, procedures, apparatus, equipment, materials", "Specific celestial bodies and phenomena", 
            "Classical mechanics", "Fluid mechanics", "Pneumatics (Gas mechanics)",  "Physical chemistry", 
            "Techniques, procedures, apparatus, equipment, materials", 
            "Analytical chemistry", "Geology, hydrology, meteorology", "Petrology", "Economic geology"
        };

        public static List<string> hun = new List<string>()
        {
            "110 Metaphysics", "120 Epistemology", "130 Parapsychology and occultism", "140 Philosophical schools and thoughts", 
            "150 Psychology"
        };

        public static List<string> two = new List<string>()
        {
            "210 The Bible", "220 Christianity", "230 Philosophy and theory of religion", "240 Christian orders and local church", 
            "250 Christian practice and observance"
        };

        public static List<string> three = new List<string>()
        {
            "310 Statistics", "320 Political science", "330 Economics", "340 Law", "350 Public administration and military science"
        };

        public static List<string> four = new List<string>()
        {
            "410 Linguistics", "420 English and Old English languages", "430 German and related languages", "440 French and related languages", "450 Italian, Romanian and related languages"
        };

        public static List<string> five = new List<string>()
        {
            "510 Mathematics", "520 Astronomy", "530 Physics", "540 Chemistry", "550 Earth sciences and geology"
        };

        //get lists method
        public List<string> Get100LeafList()
        {
            return leafNodeshundred;
        }  
        public List<string> Get200LeafList()
        {
            return leafNodestwohun;
        }
        public List<string> Get300LeafList()
        {
            return leafNodesthrehun;
        }
        public List<string> Get400LeafList()
        {
            return leafNodesfourhun;
        }
        public List<string> Get500LeafList()
        {
            return leafNodesfivehun;
        }
        public List<string> Get100List()
        {
            return hun;
        }
        public List<string> Get200List()
        {
            return two;
        }
        public List<string> Get300List()
        {
            return three;
        }
        public List<string> Get400List()
        {
            return four;
        }
        public List<string> Get500List()
        {
            return five;
        }

        //get random description method
        public void getRandomDescription()
        {
            number = random.Next(1, 5);

            if(number == 1)
            {
                index = random.Next(leafNodeshundred.Count);
                decriptionLabel = leafNodeshundred[index];
            }
            else if(number == 2)
            {
                index = random.Next(leafNodestwohun.Count);
                decriptionLabel = leafNodestwohun[index];
            }
            else if(number == 3)
            {
                index = random.Next(leafNodesthrehun.Count);
                decriptionLabel = leafNodesthrehun[index];
            }
            else if (number == 4)
            {
                index = random.Next(leafNodesfourhun.Count);
                decriptionLabel = leafNodesfourhun[index];
            }
            else if (number == 5)
            {
                index = random.Next(leafNodesfivehun.Count);
                decriptionLabel = leafNodesfivehun[index];
            }
        }

        
    }

}

