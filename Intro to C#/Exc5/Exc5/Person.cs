/* Author: Matthew Powers
 * Class: CSI_156
 * Assignment: Exercise 5
 * Date: 5/18/17
 * Descritpion: Creates the person class and gives it properties and methods for the program
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc5
{
    class Person
    {
        // Initalizes the fields
        private string _name; // first and last
        private int _age; // in years
        private double _height; // in inches


        // Properties of the class
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        } // End of Name

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        } // End of Age

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        } // End of Height

        // Methods of the class
        public Person()
        {
            Name = "Bob Smith";
            Age = 30;
            Height = 71;
        } // End of Person

        public Person(string name, int age, double height)
        {
            Name = name;
            Age = age;
            Height = height;
        } // End of Person

        // ToString override
        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}, Height {2:f1}", Name, Age, Height);
        } // end of ToString
    } // End of class
} // End of namespace
