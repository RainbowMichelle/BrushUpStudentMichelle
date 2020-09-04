using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrushUpStudentM;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace BrushUpStudentM.Tests
{
    [TestClass()]
    public class TeacherTests
    {
        private Teacher teach;

        [TestInitialize]

        public void initialize()
        {
            teach = new Teacher("Todd", "TeachTown", GenderPicker.Female, 200);
        }

        [TestMethod()]
        public void TeacherNameTest()
        {
            Assert.AreEqual("Todd", teach.Name);
            teach.Name = "Steve";
            Assert.AreEqual("Steve", teach.Name);
            Assert.ThrowsException<NoNullAllowedException>(() => teach.Name = null);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => teach.Name = "C");
        }

        [TestMethod()] 
        public void TeacherAddressTest()
        {
            Assert.AreEqual("TeachTown", teach.Address);
            teach.Address = "LA LA";
            Assert.AreEqual("LA LA", teach.Address);
            Assert.ThrowsException<NoNullAllowedException>(() => teach.Address = null);
        }

        [TestMethod()]
        public void TeacherSaleryTest()
        {
            Assert.AreEqual(200, teach.Salery);
            teach.Salery = 300;
            Assert.AreEqual(300, teach.Salery);
            Assert.ThrowsException<Exception>(() => teach.Salery = -10);
            Assert.ThrowsException<Exception>(() => teach.Salery = 0);
        }
    }
}