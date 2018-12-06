using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPDemo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LabelError.Text = "";


                try
                {
                    // string connString = DataLayer.DB.ConnectionString;
                    DataLayer.DB.ApplicationName = "ASPDemo Application";
                    DataLayer.DB.ConnectionTimeout = 30;
                    SqlConnection conn = DataLayer.DB.GetSqlConnection();

                    GridViewAppLog.DataSource = DataLayer.ApplicationLog.GetLog("ASPDemo Application");
                    GridViewAppLog.DataBind();
                }
                catch(SqlException sqlex)
                {
                    LabelError.Text = sqlex.Message;
                }
                catch { }
            }
        }

        protected void LinkButtonGetEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                DataLayer.Employees es = new DataLayer.Employees();
                DataLayer.Employee employee = es.GetEmployee(int.Parse(TextBoxEID.Text));

                TextBoxFirstName.Text = employee.FirstName;
                TextBoxLastName.Text = employee.LastName;
                TextBoxDepartment.Text = employee.DepartmentName;
                LabelDeptId.Text = employee.DepartmentId.ToString();
                LabelOldName.Text = employee.DepartmentName;

                DataLayer.ApplicationLog.Add4("Searched for user id: " + TextBoxEID.Text);

                GridViewAppLog.DataSource = DataLayer.ApplicationLog.GetLog("ASPDemo Application");
                GridViewAppLog.DataBind();
            }
            catch (SqlException sqlex)
            {
                LabelError.Text = sqlex.Message;
            }
            catch { }
        }

        protected void LinkButtonUpdateDeptName_Click(object sender, EventArgs e)
        {
            try
            {
                // A serach must first be performed
                if (TextBoxEID.Text.Length > 0 && TextBoxDepartment.Text.Length > 0)
                {
                    DataLayer.Employees employees = new DataLayer.Employees();
                    int deptId = int.Parse(LabelDeptId.Text);
                    employees.UpdateDepartmentName(deptId, TextBoxDepartment.Text, LabelOldName.Text);
                }
            }
            catch (SqlException sqlex)
            {
                LabelError.Text = sqlex.Message;
            }
            catch { }
        }

        protected void LinkButtonDeleteLogApplication_Click(object sender, EventArgs e)
        {
            DataLayer.ApplicationLog.DeleteAppLog("ASPDemo Application");
        }
    }
}