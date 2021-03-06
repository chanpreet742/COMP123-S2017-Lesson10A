﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Chanpreet Mudhar
 * Date: July 11, 2017
 * Description: This is the abstract class Human which other subclasses will
 * derive from.
 * Version: 0.2 - Added abstract method DisplaySkills
 */


namespace COMP123_S2017_Lesson10A
{
    /// <summary>
    /// This is the Human Abstract class
    /// </summary>
    public abstract class Human
    {
        // PRIVATE FIELDS (INSTANCE VARIABLES)
        private string _name;

        // PUBLIC PROPERTIES -----------------------------------------
        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                this._name = value;
            }
        }

        // CONSTRUCTORS -----------------------------------------------

        /// <summary>
        /// This is the constructor for the Human abstract class.
        /// It requires one parameter - name (string).
        /// </summary>
        /// <param name="name"></param>
        public Human(string name)
        {
            this.Name = name;
        }
        //PRIVATE METHODS


        //PUBLIC METHODS
        public abstract void DisplaySkills();
    }
}