using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstClassExample
{
    class Coin // class header
    {
        // members
        // 1. Characteristics:
        // are stored in variables called fields
        // always private
        private string _face = "tails"; // default value

        // Constructors: assign values to the fields when
        // an instance of the class (object) is created in
        // memory
        // 1. parmeterless constructor (default constructor)
        public Coin()
        {
            _face = "tails";
        }
        
        // 2. Parameterized constructor: parameters are values
        // to initiliaze the fields of the object
        public Coin(string face)
        {
            _face = face;
        }

        // Properties: accessors for the fields they represent
        // Their fields are called backing fields
        public string Face
        {
            // Read operation: GET operation
            get { return _face; }

            // Write/Modify operation: SET operation
            set { _face = value; }
        }

        //2. behavior:
        // expressed as actions using methods
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
