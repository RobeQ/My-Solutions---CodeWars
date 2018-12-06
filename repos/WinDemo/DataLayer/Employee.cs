using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Employees
    {
        public List<Employee> EmployeeList { get; set; }


        public Employee GetEmployee(int employeeId)
        {
            // EXEC GetEmployeeDetails 1

            Employee e = new Employee();

            using (SqlConnection conn = DB.GetSqlConnection())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"GetEmployeeDetails";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter p1 = new SqlParameter("businessEntityId", System.Data.SqlDbType.Int);
                    p1.Value = employeeId;

                    cmd.Parameters.Add(p1);

                    SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                    if (reader.Read())
                        e.Load(reader);
                }
            }
            return e;
        }


        /// <summary>
        /// Return an employee using Inline SQL
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public Employee GetEmployeeDoNOTCALL(int employeeId)
        {
            Employee e = new Employee();

            using (SqlConnection conn = DB.GetSqlConnection())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT * FROM HumanResources.Employee AS E
		 JOIN Person.Person AS P ON E.BusinessEntityID = P.BusinessEntityID AND P.PersonType = 'EM'
		 JOIN HumanResources.EmployeeDepartmentHistory AS EH ON E.BusinessEntityID = EH.BusinessEntityID
		 JOIN HumanResources.Department AS D ON D.DepartmentID = EH.DepartmentID
WHERE
	 E.BusinessEntityID = {0}";

                    cmd.CommandText = string.Format(cmd.CommandText, employeeId.ToString());
                    SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                    if (reader.Read())
                        e.Load(reader);
                }
            }

            return e;
        }

        /// <summary>
        /// Update department name of a department given its ID
        /// </summary>
        /// <param name="departmentId"></param>
        /// <param name="newName"></param>
        public void UpdateDepartmentName(int departmentId, string newName, string oldName)
        {
            using (SqlConnection conn = DB.GetSqlConnection())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"UpdateDepartmentName";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter p1 = new SqlParameter("id", System.Data.SqlDbType.NVarChar, 100);
                    p1.Value = departmentId;

                    cmd.Parameters.Add(p1);

                    SqlParameter p2 = new SqlParameter("name", System.Data.SqlDbType.NVarChar, 100);
                    p2.Value = newName;

                    cmd.Parameters.Add(p2);

                    // Used for concurency check (manual)
                    SqlParameter p3 = new SqlParameter("oldname", System.Data.SqlDbType.NVarChar, 100);
                    p3.Value = oldName;

                    cmd.Parameters.Add(p3);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }


    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public void Load(SqlDataReader reader)
        {
            EmployeeId = Int32.Parse(reader["BusinessEntityId"].ToString());
            FirstName = reader["FirstName"].ToString();
            LastName = reader["LastName"].ToString();
            DepartmentId = Int32.Parse(reader["DepartmentId"].ToString());
            DepartmentName = reader["Name"].ToString();
        }
    }
}
