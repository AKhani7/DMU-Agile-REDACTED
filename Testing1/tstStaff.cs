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

        // The following will be used to ensure the hard-coded Find method works.

        [TestMethod]
        public void FindMethodOk()
        {
            // Creates an instance of the class we wnat to create.
            clsStaff sampleStaff = new clsStaff();
            // Boolean variable that'll store the results of the validation check.
            Boolean Found = false;
            // Creates some sample test data to use with this method.
            Int32 StaffNo = 1;
            // Invokes the method.
            Found = sampleStaff.Find(StaffNo);
            // Tests to see if the result happens to be true.
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void StaffNoFindOk()
        {
            // Creates an instance of the class we want to create.
            clsStaff sampleStaff = new clsStaff();
            // Boolean variable that'll store the results of the validation check.
            Boolean Found = false;
            // Boolean variable to record if data is okay.
            Boolean dataOK = true;
            // Creates some sample test data to use with this method.
            Int32 StaffNo = 1;
            // Invokes the method.
            Found = sampleStaff.Find(StaffNo);
            // Checks the staff number. 
            if (sampleStaff.StaffNo != 1)
            {
                dataOK = false;                
            }
            Assert.IsTrue(dataOK);
        } 
        [TestMethod]
        public void StaffNameFindOk()
        {
            // Creates an instance of the class we want to create.
            clsStaff sampleStaff = new clsStaff();
            // Boolean variable that'll store the results of the validation check.
            Boolean Found = false;
            // Boolean variable to record if data is okay.
            Boolean dataOk = true;
            // Creates some sample test data to use with this method.
            Int32 StaffNo = 1;
            // Invokes the method.
            Found = sampleStaff.Find(StaffNo);
            // Checks the staff name.
            if(sampleStaff.StaffName != "John Doe")
            {
                dataOk = false;
            }
            Assert.IsTrue(dataOk);
        }
        [TestMethod]
        public void StaffRoleFindOk()
        {
            // Creates an instance of the class we want to create.
            clsStaff sampleStaff = new clsStaff();
            // Boolean variable that'll store the results of the validation check.
            Boolean Found = false;
            // Boolean variable to record if data is okay.
            Boolean dataOk = true;
            // Creates some sample test data to use with this method.
            Int32 StaffNo = 1;
            // Invokes the method.
            Found = sampleStaff.Find(StaffNo);
            // Checks the staff role.
            if (sampleStaff.StaffRole != "Manager")
            {
                dataOk = false;
            }
            Assert.IsTrue(dataOk);
        }
        [TestMethod]
        public void DateOfEmploymentFindOk()
        {
            // Creates an instance of the class we want to create.
            clsStaff sampleStaff = new clsStaff();
            // Boolean variable that'll store the results of the validation check.
            Boolean Found = false;
            // Boolean variable to record if data is okay.
            Boolean dataOk = true;
            // Creates some sample test data to use with this method.
            Int32 StaffNo = 1;
            // Invokes the method.
            Found = sampleStaff.Find(StaffNo);
            // Checks the date of employment.
            if (sampleStaff.DateAdded != Convert.ToDateTime("21/04/2022 21:45:21"))
            {
                dataOk = false;
            }
            Assert.IsTrue(dataOk);
        }
        [TestMethod]
        public void StaffSalaryFindOk()
        {
            // Creates an instance of the class we want to create.
            clsStaff sampleStaff = new clsStaff();
            // Boolean variable that'll store the results of the validation check.
            Boolean Found = false;
            // Boolean variable to record if data is okay.
            Boolean dataOk = true;
            // Creates some sample test data to use with this method.
            Int32 StaffNo = 1;
            // Invokes the method.
            Found = sampleStaff.Find(StaffNo);
            // Checks the staff salary.
            if (sampleStaff.StaffSalary != Convert.ToInt32(24000))
            {
                dataOk = false;
            }
            Assert.IsTrue(dataOk);
        }
        [TestMethod]
        public void IsEmployedFindOk()
        {
            // Creates an instance of the class we want to create.
            clsStaff sampleStaff = new clsStaff();
            // Boolean variable that'll store the results of the validation check.
            Boolean Found = false;
            // Boolean variable to record if data is okay.
            Boolean dataOk = true;
            // Creates some sample test data to use with this method.
            Int32 StaffNo = 1;
            // Invokes the method.
            Found = sampleStaff.Find(StaffNo);
            // Checks the boolean IsEmployed.
            if (sampleStaff.IsEmployed != true)
            {
                dataOk = false;
            }
            Assert.IsTrue(dataOk);
        }
    }
}
