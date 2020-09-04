using System;
using System.Data;

namespace BrushUpStudentM
{
    public class Student : Person
    {
        private int _semester;

        /// <summary>
        /// Student class contains semester as a studentspecific property for the person class. 
        /// </summary>
        /// <param name="semester"> Semester propety, must be between values 1 and 8 </param>

        public Student(string name, string address, int semester, GenderPicker gender) : base (name, address, gender)
        {
            Semester = semester;
        }
        public int Semester
        {
            get { return _semester; }
            set
            {
                if (value<=00 || value>=9)
                {
                    throw new Exception();
                }
                _semester = value;
            }
        }

        /// <summary>
        /// Override of ToString to print out property values for a student.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "student name is " + Name + " student address is: " + Address + " student is at " + Semester + " semester, and has the gander " + Gender;
        }


    }
}
