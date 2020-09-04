using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrushUpStudentM;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace BrushUpStudentM.Tests
{
    [TestClass()]
    public class StudentTests
    {
        private Student stud;

        [TestInitialize]
        public void Initialize() 
        {
            stud = new Student("Michelle","Unicornroad 33",3,GenderPicker.Female);
        }
            
        [TestMethod()]
        public void NameTest()
        {
            Assert.AreEqual("Michelle", stud.Name);
            stud.Name = "KK";
            Assert.AreEqual("KK", stud.Name);
            Assert.ThrowsException<NoNullAllowedException>(() => stud.Name = null);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => stud.Name = "K");
        }

        [TestMethod()]
        public void AddressTest()
        {
            Assert.AreEqual("Unicornroad 33",stud.Address);
            stud.Address = "Unicornstreet 10";
            Assert.AreEqual("Unicornstreet 10", stud.Address);
            Assert.ThrowsException<NoNullAllowedException>(() => stud.Address = null);
        }

        [TestMethod()]
        public void SemesterTest()
        {
            Assert.AreEqual(3, stud.Semester);
            stud.Semester = 4;
            Assert.AreEqual(4, stud.Semester);
            Assert.ThrowsException<Exception>(() => stud.Semester = 0);
            Assert.ThrowsException<Exception>(() => stud.Semester = -3);
            Assert.ThrowsException<Exception>(() => stud.Semester = 9);
        }
    }
}
