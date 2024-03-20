using System;
using System.Collections.Generic;
using System.Text;

namespace ProgPoeTest
{
    public class Dewey
    {

        /// Gets or sets the call description of the Dewey item.
        public string callDesc { get; set; }

        /// Gets or sets the call number of the Dewey item.
        public string callNum { get; set; }

        public Dewey(string callNum, string callDesc)
        {
            this.callDesc = callDesc;
            this.callNum = callNum;
        }

        /// Returns a string representation of the Dewey item.
        public override string ToString()
        {
            string re = $"{this.callNum} {this.callDesc}";
            return re;
        }

        /// Determines whether the specified Dewey object is equal to the current Dewey object based on call description.
        protected bool Equals(Dewey obj)
        {
            return callDesc == obj.callDesc;
        }

        /// Determines whether the specified object is equal to the current Dewey object.
        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Dewey)obj);
        }

        /// Serves as the default hash function.
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
