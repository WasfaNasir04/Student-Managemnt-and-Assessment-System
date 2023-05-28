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
    public partial class Student : Form
    {

       
        int count;
        int indexRow;
        public Student()
        {
            InitializeComponent();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = CRUD_Operations.Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into Student (FirstName,LastName,Contact,Email,RegistrationNumber,Status)values(@FirstName,@LastName,@Contact,@Email,@RegistrationNumber, @Status)", con);
                cmd.Parameters.AddWithValue("@FirstName", text1.Text);
                cmd.Parameters.AddWithValue("@LastName", text2.Text);
                cmd.Parameters.AddWithValue("@Contact", text3.Text);
                cmd.Parameters.AddWithValue("@Email", text4.Text);
                cmd.Parameters.AddWithValue("@RegistrationNumber", text5.Text);
                cmd.Parameters.AddWithValue("@Status", text6.Text);
                cmd.ExecuteNonQuery();
                display_data();
                reset();
                MessageBox.Show("Successfully saved");

            }

            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        public void reset()
        {
            text1.Text = null;
            text2.Text = null;
            text3.Text = null;
            text4.Text = null;
            text5.Text = null;
            text6.Text = null;

        }

        public void display_data()
        {
            SqlConnection con = CRUD_Operations.Configuration.getInstance().getConnection();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Student";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
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
            
        }

        private void Update_Click(object sender, EventArgs e)
        {
            SqlConnection con = CRUD_Operations.Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE Student SET FirstName=@FirstName,LastName=@LastName,Contact=@Contact,Email=@Email,RegistrationNumber=@RegistrationNumber, Status=@Status WHERE FirstName=@FirstName", con);
            cmd.Parameters.AddWithValue("FirstName", text1.Text);
            cmd.Parameters.AddWithValue("LastName", text2.Text);
            cmd.Parameters.AddWithValue("Contact", text3.Text);
            cmd.Parameters.AddWithValue("Email", text4.Text);
            cmd.Parameters.AddWithValue("RegistrationNumber", text5.Text);
            cmd.Parameters.AddWithValue("Status", text6.Text);
            cmd.ExecuteNonQuery();
            display_data();
            reset();
            MessageBox.Show("Successfully Updated");


        }

       




        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = CRUD_Operations.Configuration.getInstance().getConnection();
            SqlCommand cmd = con.CreateCommand();
            cmd = new SqlCommand("DELETE FROM Student INNER JOIN StudentAttendance ON Student.Id=StudentAttendance.StudentId WHERE RegistrationNumber = '" + text5.Text + "'", con);
            cmd.ExecuteNonQuery();
            display_data();
            reset();
            MessageBox.Show("Deleted Successfully");
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display_data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = CRUD_Operations.Configuration.getInstance().getConnection();
            count = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Student where RegistrationNumber= '" + text5.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            dataGridView1.DataSource = dt;

            if (count == 0)
            {
                MessageBox.Show("Record not found");
            }
            reset();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            text1.Text = row.Cells[1].Value.ToString();
            text2.Text = row.Cells[2].Value.ToString();
            text3.Text = row.Cells[3].Value.ToString();
            text4.Text = row.Cells[4].Value.ToString();
            text5.Text = row.Cells[5].Value.ToString();
            text6.Text = row.Cells[6].Value.ToString();
        }

        private void text3_TextChanged(object sender, EventArgs e)
        {

        }

        private void status_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
