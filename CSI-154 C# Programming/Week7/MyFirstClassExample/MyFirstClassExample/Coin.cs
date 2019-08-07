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
        private string face;

        //2. behavior:
        // expressed as actions using methods
        public void Toss()
        {
            Random rd = new Random();
            if (rd.Next(2) == 0) // heads
            {
                face = "heads";
            } 
            else // tails
            {
                face = "tails";
            }
        }

        public string Outcome()
        {
            return face;
        }
    }
}
