using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgPoeTest
{
     class DeweyClass
    {
        // Dictionary to store call numbes and descriptions as pairs
        public Dictionary<String, String> callNumberDescription = new Dictionary<string, string>();
        // Lists to store call numbers and descriptions
        public List<String> callNumbers = new List<String>();
        public List<String> description = new List<String>();
        // Generating random numbers
        public static Random rnd = new Random();

        public DeweyClass()
        {
            // Initialize the call  call numbes and descriptions dictionary with predefined values
            callNumberDescription.Add("000", "General Works");
            callNumberDescription.Add("100", "Philosophy");
            callNumberDescription.Add("200", "Religion");
            callNumberDescription.Add("300", "Social Sciences");
            callNumberDescription.Add("400", "Language");
            callNumberDescription.Add("500", "Science");
            callNumberDescription.Add("600", "Technology");
            callNumberDescription.Add("700", "The Arts");
            callNumberDescription.Add("800", "Literature");
            callNumberDescription.Add("900", "History, Geography");
        }

        // Initialize the list of descriptions
        public List<String> descriptionInitialization()
        {
            description.Add("General Works");
            description.Add("Philosophy");
            description.Add("Religion");
            description.Add("Social Science");
            description.Add("Language");
            description.Add("Science");
            description.Add("Technology");
            description.Add("The Arts");
            description.Add("Literature");
            description.Add("History, Geography");

            // Shuffles the list of descriptions
            description = shuffleList(description);

            return description;
        }

        // Initialize the list of call numbers
        public List<String> callNumberIntialization()
        {
            callNumbers.Clear();
            callNumbers.Add("000");
            callNumbers.Add("100");
            callNumbers.Add("200");
            callNumbers.Add("300");
            callNumbers.Add("400");
            callNumbers.Add("500");
            callNumbers.Add("600");
            callNumbers.Add("700");
            callNumbers.Add("800");
            callNumbers.Add("900");

            // Shuffles the list of call numbers
            callNumbers = shuffleList(callNumbers);

            return callNumbers;
        }

        // Shuffles a list of strings
        public List<String> shuffleList(List<String> dList)
        {
            List<String> tempList = new List<String>();
            int lastIndex = dList.Count();

            while (lastIndex > 0)
            {
                int randomIndex = rnd.Next(0, lastIndex - 1);

                if (!tempList.Contains(dList[randomIndex]))
                {
                    tempList.Add(dList[randomIndex]);
                    dList.RemoveAt(randomIndex);

                }
                lastIndex--;
            }


            return tempList;
        }

        // Generate a list of random call numbers
        public List<String> randonNumberGen()
        {
            String random = "";

            callNumbers.Clear();
            description.Clear();
            for (int i = 0; i < 4; i++)
            {
                random = rnd.Next(0, 10).ToString();
                random += "00";

                if (!callNumbers.Contains(random))
                {
                    callNumbers.Add(random);
                }
                else
                {
                    i--; // Retres if the generated call number already exists in the list
                }

            }

            return callNumbers;
        }



    }
}


