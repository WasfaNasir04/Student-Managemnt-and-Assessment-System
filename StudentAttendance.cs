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

namespace DB2020_CS_145
{
    public partial class StudentAttendance : Form
    {
        
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        DataSet ds;
        int count;
       
        public StudentAttendance()
        {
            InitializeComponent();
        }

        private void Insert_Click(object sender, EventArgs e)
        {

        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void text5_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DD.Text = DateTime.Now.ToString("dd-MM-yy");
            SqlConnection con = CRUD_Operations.Configuration.getInstance().getConnection();
            SqlCommand cmd = con.CreateCommand();
            //SELECT TOP 2 Name FROM Lookup ORDER BY LookupId DESC
            da = new SqlDataAdapter("SELECT * FROM Lookup WHERE Category = 'ATTENDANCE_STATUS'", con);
            dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow ROW in dt.Rows)
            {
                stdAtt.Items.Add(ROW["Name"].ToString());

            }

            da = new SqlDataAdapter("SELECT * FROM Student ", con);
            dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow ROW in dt.Rows)
            {
                stdID.Items.Add(ROW["Id"].ToString());

            }

            //Check();

            dr = null;
            cmd = new SqlCommand("SELECT * FROM ClassAttendance ", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                attdtxt.Text = dr["Id"].ToString();


            }

            dr.Close();

            ShowData();
        }

        public void ShowData()
        {

            SqlConnection con = CRUD_Operations.Configuration.getInstance().getConnection();
            SqlCommand cmd = con.CreateCommand();
            cmd = new SqlCommand("Select StudentAttendance.StudentId AS Id, Student.RegistrationNumber AS RegestrationNo, Lookup.Name AS Attendance from Student LEFT JOIN StudentAttendance ON Student.Id = StudentAttendance.StudentId INNER JOIN Lookup ON Lookup.LookupId = StudentAttendance.AttendanceStatus INNER JOIN ClassAttendance ON ClassAttendance.Id = StudentAttendance.AttendanceId", con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

       

        public void reset()
        {
            stdID.Text = null;
            stdAtt.Text = null;
            stdRegNo.Text = null;

        }

        private void Attendance_Activated(object sender, EventArgs e)
        {
            stdID.Focus();
        }

       

        public void display_data()
        {
            SqlConnection con = CRUD_Operations.Configuration.getInstance().getConnection();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from StudentAttendance";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (looktext.Text.Trim().Length == 0 || stdID.Text.Trim().Length == 0)
            {
                MessageBox.Show("No empty fields", "User Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                SqlConnection con = CRUD_Operations.Configuration.getInstance().getConnection();
                SqlCommand cmd = con.CreateCommand();
                string query = "UPDATE StudentAttendance SET StudentId = '" + stdID.Text + "' , AttendanceStatus = '" + looktext.Text + "'  WHERE StudentId = '" + stdID.Text + "'";
                cmd = new SqlCommand(query, con);
                //SqlDataReader dr;
                try
                {
                   
                    dr = cmd.ExecuteReader();
                    MessageBox.Show("Record Updated successfully", "User Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    dr.Close();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }


                ShowData();
                
                reset();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (looktext.Text.Trim().Length == 0 || stdID.Text.Trim().Length == 0)
            {
                MessageBox.Show("No Empty fiels!!", "User Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                    SqlConnection con = CRUD_Operations.Configuration.getInstance().getConnection();
                    SqlCommand cmd = con.CreateCommand();
                    cmd = new SqlCommand("DELETE  from StudentAttendance WHERE StudentId = '" + stdID.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted successfully", "User Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ShowData();

                   
                    reset();
                }
            
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                stdID.Text = row.Cells[0].Value.ToString();
                //dateTimePicker1.Text = row.Cells[1].Value.ToString();
                stdAtt.Text = row.Cells[2].Value.ToString();
                //stdRegNo.Text = row.Cells[1].Value.ToString();

            }
        }

        private void display_Click(object sender, EventArgs e)
        {
            display_data();
            
        }

        private void stdID_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = CRUD_Operations.Configuration.getInstance().getConnection();
            SqlCommand cmd = con.CreateCommand();
            dt = new DataTable();

            dr = null;
            cmd = new SqlCommand("SELECT RegistrationNumber FROM Student WHERE Id = '" + stdID.Text + "'", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
               
                stdRegNo.Text = dr["RegistrationNumber"].ToString();


            }
            dr.Close();
        }

        private void stdAtt_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = CRUD_Operations.Configuration.getInstance().getConnection();
            SqlCommand cmd = con.CreateCommand();
            dt = new DataTable();
          
            dr = null;
            cmd = new SqlCommand("SELECT * FROM Lookup WHERE Name = '" + stdAtt.Text + "'", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                looktext.Text = dr["LookupId"].ToString();
               
            }
            dr.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void InsertStd_Click(object sender, EventArgs e)
        {
            if (stdID.Text.Trim().Length == 0 || looktext.Text.Trim().Length == 0 || attdtxt.Text.Trim().Length == 0 || stdAtt.Text.Trim().Length == 0)
            {
                MessageBox.Show("No empty fields", "User INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {

                SqlConnection con = CRUD_Operations.Configuration.getInstance().getConnection();
                SqlCommand cmd = con.CreateCommand();
                cmd = new SqlCommand("INSERT INTO StudentAttendance (AttendanceId, StudentId,AttendanceStatus) VALUES (@AttendanceId, @StudentId,@AttendanceStatus)", con);
                cmd.Parameters.AddWithValue("@AttendanceId", attdtxt.Text);
                cmd.Parameters.AddWithValue("@StudentId", stdID.Text);
                cmd.Parameters.AddWithValue("@AttendanceStatus", looktext.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved!!", "User Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ShowData();
               
                reset();
                //Check();

                //dateTimePicker1.Value = System.DateTime.Now;

                SqlDataReader r = null;
                cmd = new SqlCommand("SELECT * FROM ClassAttendance ", con);
                r = cmd.ExecuteReader();

                while (r.Read())
                {
                    attdtxt.Text = r["Id"].ToString();


                }
                r.Close();


                stdID.Focus();


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
