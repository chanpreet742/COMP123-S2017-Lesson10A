using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Chanpreet Mudhar
 * Date: July 11, 2017
 * Description: This is the SuperHuman class that extends the Human abstract class
 * Version: 0.7 - Added the DisplaySkills() stub method to satisfy the Human Superclass method.
 */

namespace COMP123_S2017_Lesson10A
{
    /// <summary>
    /// This is the SuperHuman sub class.
    /// It inherits from the Human Superclass.
    /// </summary>
    public class SuperHuman : Human
    {
        // PRIVATE FIELDS
        private List<Power> _powers;

        // PUBLIC PROPERTIES
        public List<Power> Powers
        {
            get
            {
                return this._powers; // returns a reference to the Powers List
            }
        }


        // CONSTRUCTORS
        public SuperHuman(string name)
            : base(name)
        {
            this._initialize();
        }

        // PRIVATE METHODS

        /// <summary>
        /// This method initializes and assigns default values to Class Fields
        /// </summary>
        private void _initialize()
        {
            this._powers = new List<Power>();
        }

        // PUBLIC METHODS

        /// <summary>
        /// This method adds a Power to the Power List
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public void AddPower(string name, int rank)
        {
            this.Powers.Add(new Power(name, rank));
        }

        public void DisplayPowers()
        {
            foreach (var power in Powers)
            {
                Console.WriteLine("Name: " + power.Name + " Rank: " + power.Rank);
            }
        }
        public override string ToString()
        {
            string outputString = "------------------------------------";
            outputString += "Super Human Name" + this.Name + "\n";
            outputString = "-----------------------------------------------";
            foreach (Power power in this.Powers)
            {
                outputString += "Power:" + power.Name + "Rank:" + power.Rank + "\n";

            }
            outputString = "---------------------------------------------------";
            return outputString;
        }
        /// <summary>
        /// This method overrides the human abstract superclass DisplaySkills method.
        /// This method will display a list of skills in the console.
        /// </summary>
        public override void DisplaySkills()
        {
            Console.WriteLine("Not Implemented");
        }
    }
}