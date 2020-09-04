using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BrushUpStudentM
{
    public class Teacher : Person
    {
        private int _salery;
        /// <summary>
        /// Teacher class to specify a person as teacher. contains salery. inherits name, address and gender from person class.
        /// </summary>
        /// <param name="salery"> salery property must be a positive number starting at 0. </param>
        public Teacher (string name, string address, GenderPicker gender, int salery) : base (name, address, gender)
        {
            Salery = salery;
        }

        public int Salery
        {
            get { return _salery; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception();
                }
                _salery = value; }
        }

        public override string ToString()
        {
            return "Teacher name is " + Name + " teacher address is: " + Address + " teacher earns " + Salery + 
                " moneys, and has the gender " + Gender;
        }


    }
}
