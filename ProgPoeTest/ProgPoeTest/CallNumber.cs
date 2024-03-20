using System;
using System.Collections.Generic;
using System.Text;

namespace ProgPoeTest
{
    public class CallNumber : IComparable<CallNumber>
    {
        // Defines properties for the call number and author.
        public int callNumber { get; set; }
        public string Author { get; set; }

        // It takes an integer (call number) and a string (author) as parameters.
        public CallNumber(int thecallNumber, string theAuthor)
        {
            // Initialize the callNumber and Author properties with the provided values.
            this.callNumber = thecallNumber;
            this.Author = theAuthor;
        }
      
        // Implementation of the CompareTo method.
        public int CompareTo(CallNumber call)
        {
            // Compare the call numbers of two CallNumber instances.
            int results = callNumber.CompareTo(call.callNumber);

            // If the call numbers are the same, compare the authors.
            if (results == 0)
            {
                results = Author.CompareTo(call.Author);
            }
            // Returns the comparison result.
            return results;
        }
    }
}