/* Author: Matthew Powers
 * Date: 5/26/17
 * Class: CSI_154
 * Assignment: Lab Assignment 5
 * Description: Creates a ProfessorRating class with various fields, properties, and methods
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI156LabAssignment6
{
    class ProfessorRating
    {
        // Creates the fields for the class
        private int _professorID;
        private int _helpfullness;
        private int _clarity;
        private int _easiness;

        // Creates the properties for the class
        public int Helpfullness
        {
            get { return _helpfullness; }
            set { _helpfullness = value; }
        }

        public int Clarity
        {
            get { return _clarity; }
            set { _clarity = value; }
        }

        public int Easiness
        {
            get { return _easiness; }
            set { _easiness = value; }
        }

        public int ProfessorID
        {
            get { return _professorID; }
            private set { _professorID = value; }
        }

        // Creates the methods for the classes
        public ProfessorRating(int proID, int hlpRating, int clrRating, int ezRating)
        {
            _professorID = proID;
            _helpfullness = hlpRating;
            _clarity = clrRating;
            _easiness = ezRating;
        }

        public override string ToString()
        {
            return string.Format("Helpfullness: {0}, Clarity: {1}, Easiness: {2}", Helpfullness, Clarity, Easiness);
        }
    }
}
