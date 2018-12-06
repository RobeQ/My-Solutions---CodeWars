using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace WinDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string connString = DataLayer.DB.ConnectionString;
            try
            {
                DataLayer.DB.ApplicationName = "WinDemo Application";
                DataLayer.DB.ConnectionTimeout = 30;
                SqlConnection conn = DataLayer.DB.GetSqlConnection();

                DataTable tableLog = DataLayer.ApplicationLog.GetLog("WinDemo Application");
                dataGridViewWinApplication.DataSource = tableLog;
            }
            catch (SqlException sqlex)
            {
                // Connection error...
                System.Windows.Forms.MessageBox.Show(this, sqlex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGetEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                DataLayer.Employees es = new DataLayer.Employees();

                DataLayer.DB.EnableStatistics = true;

                DataLayer.Employee employee = es.GetEmployee(int.Parse(textBoxEID.Text));
                RefreshStatistics(DataLayer.DB.LastStatistics);

                DataLayer.DB.EnableStatistics = false;

                textBoxFName.Text = employee.FirstName;
                textBoxLName.Text = employee.LastName;
                textBoxDName.Text = employee.DepartmentName;
                labelDeptId.Text = employee.DepartmentId.ToString();
                labelOldName.Text = employee.DepartmentName; // for concurrency

                DataLayer.ApplicationLog.Add5("Searched for user id: " + textBoxEID.Text);

                DataTable tableLog = DataLayer.ApplicationLog.GetLog("WinDemo Application");
                dataGridViewWinApplication.DataSource = tableLog;
            }
            catch (SqlException sqlex)
            {
                // Connection error...
                System.Windows.Forms.MessageBox.Show(this, sqlex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch { }
        }

        private void buttonDeleteLog_Click(object sender, EventArgs e)
        {
            try
            {
                DataLayer.ApplicationLog.DeleteAppLog("WinDemo Application");

                // Refresh log
                DataTable tableLog = DataLayer.ApplicationLog.GetLog("WinDemo Application");
                dataGridViewWinApplication.DataSource = tableLog;
            }
            catch (SqlException sqlex)
            {
                // Connection error...
                System.Windows.Forms.MessageBox.Show(this, sqlex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch { }
        }

        private void linkLabelDeptName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // A serach must first be performed
                if (textBoxEID.Text.Length > 0 && textBoxDName.Text.Length > 0)
                {
                    DataLayer.Employees employees = new DataLayer.Employees();
                    int deptId = int.Parse(labelDeptId.Text);
                    employees.UpdateDepartmentName(deptId, textBoxDName.Text, labelOldName.Text);

                    // Reload the data to refresh the hidden fields
                    buttonGetEmployee_Click(this, null);
                }
            }
            catch(SqlException sqlex)
            {
                // Connection error...
                System.Windows.Forms.MessageBox.Show(this, sqlex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch { }
        }

        private void buttonUpdateLog_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable table = (DataTable)dataGridViewWinApplication.DataSource;
                DataLayer.DB.EnableStatistics = true;
                DataTable resTable = DataLayer.ApplicationLog.UpdateLogChanges(table);
                RefreshStatistics(DataLayer.DB.LastStatistics);
                DataLayer.DB.EnableStatistics = false;
                dataGridViewWinApplication.DataSource = resTable;
            }
            catch (SqlException sqlex)
            {
                // Connection error...
                System.Windows.Forms.MessageBox.Show(this, sqlex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (DBConcurrencyException cex)
            {
                // Connection error...
                System.Windows.Forms.MessageBox.Show(this, cex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch { }
        }

        private void RefreshStatistics(ConnectionStatistics connectionStatistics)
        {
            listViewStatistics.Items.Clear();
            foreach (string key in connectionStatistics.OriginalStats.Keys)
            {
                ListViewItem lvi = new ListViewItem(key);
                lvi.SubItems.Add(connectionStatistics.OriginalStats[key].ToString());
                listViewStatistics.Items.Add(lvi);
            }
        }

        private void dataGridViewWinApplication_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
