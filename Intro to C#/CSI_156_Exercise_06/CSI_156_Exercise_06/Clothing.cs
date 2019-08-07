/* Author: Matthew Powers
 * Date: 5/25/19
 * Description: Creates a RetailItem Class with properties and a constructor as well as an override
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI_156_Exercise_06
{
    class RetailItem
    {
        // Fields
        private string _description;
        private int _unitsOnHand;
        private decimal _price;

        // Properties
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public int UnitsOnHand
        {
            get { return _unitsOnHand; }
            set { _unitsOnHand = value; }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        
        // Constructor
        public RetailItem(string description, int unitsOnHand, decimal price)
        {
            Description = description;
            UnitsOnHand = unitsOnHand;
            Price = price;
        }

        // ToString Method
        public override string ToString()
        {
            return string.Format("Description: {0}, Units on hand: {1}, Price: {2}", Description, UnitsOnHand, Price);
        }
    }
}
