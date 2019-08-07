using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstClassExample
{
    class Coin // Class header
    {
        // Members
        // 1: Characteristics are stored in variables called fields
        // Characteristics are always private
        private string _face = "tails:"; // default value

        // Constructor: Assigns values to the fields when an instance of this class (an object) is created in memory
        // 1: Parameterless constructor/default constructor
        public Coin()
        {
            _face = "tails";
        }
        
        // 2: Parameterized constructor, where parameters are values to initilize the fields of the object
        public Coin(string face)
        {
            _face = face;
        }

        // Properties are accessors for the fields they represent. The fields are called backing fields
        public string Face
        {
            // Read operation is a GET operation
            get { return _face; }

            // Write/modify operation is a SET operation
            set { _face = value; }
        }

        // 2: Behavior
        // Behavior is expressed as actions using methods
        public void Toss()
        {
            Random rd = new Random();
            if (rd.Next(2) == 0) // heads
            {
                _face = "heads";
            }
            else // tails
            {
                _face = "tails";
            }
        }

        public string Outcome()
        {
            return _face;
        }
    }
}
