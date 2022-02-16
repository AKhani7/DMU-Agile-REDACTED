using System;

namespace ClassLibrary
{
    public class clsStaff
    {

        // Adds private DateAdded variable.
        private DateTime mDateAdded;
        public DateTime DateAdded
        {
            get
            {
                // Returns the private data.
                return mDateAdded;
            }
            set
            {
                // Sets the private data.
                mDateAdded = value;
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
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfEmployment"]);               
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
    }
}