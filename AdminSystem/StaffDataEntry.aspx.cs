using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtStaffName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtStaffNo_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        // Creates a new instance of clsStaff.
        clsStaff sampleStaffData = new clsStaff();
        // Captures the user's input data.
        //Sets the Staff Number. TODO - make this unable to have an input + have a find method attached.
        sampleStaffData.StaffNo = Convert.ToInt32(txtStaffNo.Text);
        // Adds a staff name.
        sampleStaffData.StaffName = txtStaffName.Text;
        // Adds a staff role.
        sampleStaffData.StaffRole = txtStaffRole.Text;
        // Adds salary as an integer.
        sampleStaffData.StaffSalary = Convert.ToInt32(txtStaffSalary.Text); 
        // Adds date, so long as it adheres to the DateTime format - dd/mm/yyyy - hh:mm:ss
        sampleStaffData.DateAdded = Convert.ToDateTime(txtDateOfEmployment.Text);
        // Adds checkbox data for whether they're employed or not.
        sampleStaffData.IsEmployed = chkIsEmployed.Checked;
        // Store the input data in the session object.
        Session["sampleStaffData"] = sampleStaffData;
        // This will make it navigate to the Viewer page.
        Response.Redirect("StaffViewer.aspx");
    }
}