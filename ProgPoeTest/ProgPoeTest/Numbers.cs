using System;
using System.Collections.Generic;
using System.Text;

namespace ProgPoeTest
{
    class Numbers
    {
        // declares lists and parameters
        public List<CallNumber> nums = new List<CallNumber>();
        public List<CallNumber> checks = new List<CallNumber>();
        int y;
        public void RandomNumber()
        {
            // declarations
            StringBuilder builder = new StringBuilder();
            StringBuilder strbuilder = new StringBuilder();
            Random random = new Random();
            char letter;
            // Generates the random call numbers
            for (int i = 0; i <= 9; i++)
            {
                builder.Clear();
                strbuilder.Clear();
                for (int x = 0; x <= 5; x++)
                {
                    var call1 = random.Next(0, 10);
                    builder.Append(call1);
                }
                for (int z = 0; z <= 2; z++)
                {
                    double flt = random.NextDouble();
                    int shift = Convert.ToInt32(Math.Floor(25 * flt));
                    letter = Convert.ToChar(shift + 65);
                    strbuilder.Append(letter);
                }

                y = Convert.ToInt32(builder.ToString());
                // adds the values to the lists
                nums.Add(new CallNumber(y, strbuilder.ToString()));
                checks.Add(new CallNumber(y, strbuilder.ToString()));
            }
        }
        public void bubbleSort(List<CallNumber> checks)
        {
            //Sorts the second list
            for (int i = 0; i < checks.Count - 1; i++)
            {
                for (int k = (i + 1); k < checks.Count; k++)
                {
                    if (checks[i].CompareTo(checks[k]) == 1)
                    {
                        CallNumber temp = checks[i];
                        checks[i] = checks[k];
                        checks[k] = temp;
                    }
                }
            }
        }
    }
}

