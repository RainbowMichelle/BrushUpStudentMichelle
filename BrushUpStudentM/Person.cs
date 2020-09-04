using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BrushUpStudentM
{
    /// <summary>
    /// Insert enum "GenderPicker" to allow only Female and Male as values.
    /// </summary>
    public enum GenderPicker
    {
        Female,
        Male
    }
    /// <summary>
    /// Superclass "Person" to contain all shared elements between student and teacher class.
    /// </summary>
    public class Person
    {
        private string _name;
        private string _address;
        private GenderPicker _gender;

        /// <summary>
        /// Constructor Person with 3 paramethers; name, address and gender.
        /// </summary>
        /// <param name="name"> name value will be run through 2 if loops, 
        /// first to check if the inserted value is null, after this to see 
        /// if the value is less than 2 charecters long.</param>
        /// <param name="address">address property will be run through similar loop as name, but must be atleast 3 charecters. </param>
        /// <param name="gender"> gender is specified by GenderPicker Enum</param>
        public Person (string name, string address, GenderPicker gender)
        {
            Name = name;
            Address = address;
            Gender = gender;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == null)
                {
                    throw new NoNullAllowedException();
                }
                if (value.Length <=1)
                {
                    throw new ArgumentOutOfRangeException();
                } 
                _name = value; 
            }
        }

        public string Address
        {
            get { return _address; }
            set
            {
                if (value == null)
                {
                    throw new NoNullAllowedException();
                }
                if (value.Length < 3)
                {
                    throw new Exception("please enter address with street name and number.");
                }
                //if 
                //{

                //}
                _address = value;
            }
        }

        public GenderPicker Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
    }
}
