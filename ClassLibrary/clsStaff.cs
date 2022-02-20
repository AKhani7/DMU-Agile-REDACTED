using System;
using System.Text.RegularExpressions;

namespace ClassLibrary
{
    public class clsStaff
    {

        // Adds private DateofEmployment variable.
        private DateTime mDateofEmployment;
        public DateTime DateofEmployment
        {
            get
            {
                // Returns the private data.
                return mDateofEmployment;
            }
            set
            {
                // Sets the private data.
                mDateofEmployment = value;
            }
        }

        // Adds private IsEmployed Boolean variable.
        private Boolean mIsEmployed;
        public bool IsEmployed
        {
            get
            {
                // Returns the private data.
                return mIsEmployed;
            }
            set
            {
                // Sets the private data.
                mIsEmployed = value;
            }
        }

        // Adds private StaffName String variable.
        private string mStaffName;
        public string StaffName
        {
            get
            {
                // Returns the private data.
                return mStaffName;
            }
            set
            {
                // Sets the private data.
                mStaffName = value;
            }
        }

        // Adds private StaffNo integer variable.
        private Int32 mStaffNo;
        public int StaffNo
        {
            get
            {
                // Returns the private data.
                return mStaffNo;
            }
            set
            {
                // Sets the private data.
                mStaffNo = value;
            }
        }

        // Adds private StaffRole string variable.
        private string mStaffRole;
        public string StaffRole
        {
            get
            {
                // Returns the private data.
                return mStaffRole;
            }
            set
            {
                // Sets the private data.
                mStaffRole = value;
            }
        }

        // Adds private StaffSalary integer variable.
        private Int32 mStaffSalary;
        public int StaffSalary
        {
            get
            {
                // Returns the private data.
                return mStaffSalary;
            }
            set
            {
                // Sets the private data.
                mStaffSalary = value;
            }
        }



        public bool Find(int staffNo)
        {

            // Creates an instance of the database connection.
            clsDataConnection DB = new clsDataConnection();
            // Adds a parameter for the Staff Number to search for.
            DB.AddParameter("@StaffNo", staffNo);
            // Executes the stored procedure.
            DB.Execute("sproc_tblStaff_FilterByStaffNo");
            // If at least 1 record exists in the DB, it will allow the rest of the method to function.
            if (DB.Count == 1)
            {
                // Copies the data from the database to the private variables.
                mStaffNo = Convert.ToInt32(DB.DataTable.Rows[0]["StaffNo"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mStaffRole = Convert.ToString(DB.DataTable.Rows[0]["StaffRole"]);
                mDateofEmployment = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfEmployment"]);               
                mStaffSalary = Convert.ToInt32(DB.DataTable.Rows[0]["StaffSalary"]);
                mIsEmployed = Convert.ToBoolean(DB.DataTable.Rows[0]["IsEmployed"]);

                // If everything went okay, it'll return true.
                return true;
            }
            // However, if no record is found, it will return false.
            else
            {
                return false;
            }
        }

        // Method for public validation.
        public string Validation(string staffName, string staffRole, string dateOfEmployment)
            // Accepting 3 parameters, the method returns a string containing any error message. If no errors are found, a blank message is returned.
        {
            DateTime TempDate;

            // Stores error message.
            String Errormsg = "";

            // Regex variable that'll be used to check if a given string contains illegal numbers.
            Regex rejexs = new Regex("[0-9]");
            
            // This section handles special cases for the staffName variable.
            if (staffName.Length == 0)
            {
                // Records the error
                Errormsg = Errormsg + "The staff name cannot be blank : ";
            }
            if (staffName.Length > 64)
            {
                // Records the error
                Errormsg = Errormsg + "The name must be less than 64 characters : ";
            }
            if (rejexs.IsMatch(staffName))
            {
                // Records the error.
                Errormsg = Errormsg + "Staff names cannot contain numbers : ";
            }

            // This section handles special cases for the staffRole variable.
            if (staffRole.Length == 0)
            {
                // Records the error.
                Errormsg = Errormsg + "The staff role cannot be blank : ";
            }
            if (staffRole.Length > 64)
            {
                // Records the error.
                Errormsg = Errormsg + "The staff role cannot exceed 64 characters : ";
            }
            if (rejexs.IsMatch(staffRole))
            {
                // Records the error.
                Errormsg = Errormsg + "Staff roles cannot contain numbers : ";
            }

            // This section handles special cases for the dateOfEmployment variable.
            // The following variable will copy the dateOfEmployment value to the TempDate variable.
            TempDate = Convert.ToDateTime(dateOfEmployment);
            try
            {
                if (TempDate < DateTime.Now.Date)
                {
                    // Records the error.
                     Errormsg = Errormsg + "The date cannot be in the past : ";
                }
                if (TempDate > DateTime.Now.Date)
                {
                    // Records the error.
                    Errormsg = Errormsg + "The date cannot be in the future : ";
                }
            } 
            catch
            {
                Errormsg = Errormsg + "The date wasn't a valid date : ";
            }

            return Errormsg;
        }
    }
}