using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Creates an instance of the class we want to create.
            clsStaff sampleStaff = new clsStaff();
            // Test to see that it exists.
            Assert.IsNotNull(sampleStaff);
        }

        [TestMethod]
        public void DateOfEmploymentPropertyOk()
        {
            // Creates an instance of the class we want to create.
            clsStaff sampleStaff = new clsStaff();
            // Creates some test data to assign to property.
            DateTime fakeDate = DateTime.Now.Date;
            // Assign the data to a property.
            sampleStaff.DateAdded = fakeDate;
            // Check to see if both are the same.
            Assert.AreEqual(sampleStaff.DateAdded, fakeDate);
        }

        [TestMethod]
        public void IsEmployedPropertyOk()
        {
            // Creates an instance of the class we want to create.
            clsStaff sampleStaff = new clsStaff();
            // Creates some test data to assign to property.
            Boolean testData = true;
            // Assigns data to a property.
            sampleStaff.IsEmployed = testData;
            // Checks to see if both are the same.
            Assert.AreEqual(sampleStaff.IsEmployed, testData);
        }

        [TestMethod]
        public void StaffNamePropertyOk()
        {
            // Creates an instance of the class we want to create.
            clsStaff sampleStaff = new clsStaff();
            // Creates some test data to assign to property.
            string fakeName = "Bilbo Baggins";
            // Assigns the data to a property.
            sampleStaff.StaffName = fakeName;
            // Checks to see if they're both the same.
            Assert.AreEqual(sampleStaff.StaffName, fakeName);
        }

        [TestMethod]
        public void StaffNoPropertyOk()
        {
            // Creates an instance of the class we want to create.
            clsStaff sampleStaff = new clsStaff();
            // Creates some test data to assign to property.
            int testNo = 1;
            // Assigns the data to a property.
            sampleStaff.StaffNo = testNo;
            // Checks to see if they're both the same.
            Assert.AreEqual(sampleStaff.StaffNo, testNo);
        }

        [TestMethod]
        public void StaffRolePropertyOk()
        {
            // Creates an instance of the class we want to create.
            clsStaff sampleStaff = new clsStaff();
            // Creates some test data to assign to property.
            string fakeRole = "Team Manager";
            // Assigns the data to property.
            sampleStaff.StaffRole = fakeRole;
            // Checks to see if they're both the same.
            Assert.AreEqual(sampleStaff.StaffRole, fakeRole);
        }

        [TestMethod]
        public void StaffSalaryPropertyOk()
        {
            // Creates an instance of the class we want to create.
            clsStaff sampleStaff = new clsStaff();
            // Creates some test data to assign to property.
            int fakeSalary = 15500;
            // Assigns the data to property.
            sampleStaff.StaffSalary = fakeSalary;
            // Checks to see if they're both the same.
            Assert.AreEqual(sampleStaff.StaffSalary, fakeSalary);
        }
    }
}
