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
    public partial class AssessmentComponent : Form
    {
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        int count;
        int indexRow;
        public AssessmentComponent()
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
            try
            {
                DD.Text = DateTime.Now.ToString("dd-MM-yy");
                SqlConnection con = CRUD_Operations.Configuration.getInstance().getConnection();
                SqlCommand cmd = con.CreateCommand();
                //SELECT TOP 2 Name FROM Lookup ORDER BY LookupId DESC
                da = new SqlDataAdapter("SELECT * FROM Rubric ", con);
                dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow ROW in dt.Rows)
                {
                    RBox1.Items.Add(ROW["Id"].ToString());

                }

                da = new SqlDataAdapter("SELECT * FROM Assessment ", con);
                dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow ROW in dt.Rows)
                {
                    ABox2.Items.Add(ROW["Id"].ToString());

                }
            }

            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void Insert_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = CRUD_Operations.Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into AssessmentComponent (Name,RubricId,TotalMarks,DateCreated,DateUpdated,AssessmentId) values (@Name,@RubricId,@TotalMarks, @DateCreated,@DateUpdated, @AssessmentId)", con);
                cmd.Parameters.AddWithValue("@Name", text1.Text);
                cmd.Parameters.AddWithValue("@RubricId", RBox1.Text);
                cmd.Parameters.AddWithValue("@TotalMarks", text2.Text);
                cmd.Parameters.AddWithValue("@DateCreated", dateTimePicker.Value.Date);
                cmd.Parameters.AddWithValue("@DateUpdated", dateTimePicker1.Value.Date);  
                cmd.Parameters.AddWithValue("@AssessmentId", ABox2.Text);
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
            dateTimePicker1.Text = null;
            RBox1.Text = null;
            dateTimePicker.Text = null;
            ABox2.Text = null;

        }

        public void display_data()
        {
            SqlConnection con = CRUD_Operations.Configuration.getInstance().getConnection();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from AssessmentComponent";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            SqlConnection con = CRUD_Operations.Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE AssessmentComponent SET Name=@Name,RubricId=@RubricId,TotalMarks=@TotalMarks,DateCreated= @DateCreated,DateUpdated=@DateUpdated,AssessmentId=@AssessmentId WHERE RubricId=@RubricId", con);
            cmd.Parameters.AddWithValue("@Name", text1.Text);
            cmd.Parameters.AddWithValue("@RubricId", RBox1.Text);
            cmd.Parameters.AddWithValue("@TotalMarks", text2.Text);
            cmd.Parameters.AddWithValue("@DateCreated", dateTimePicker.Value.Date);
            cmd.Parameters.AddWithValue("@DateUpdated", dateTimePicker1.Value.Date);
            cmd.Parameters.AddWithValue("@AssessmentId", ABox2.Text);
            cmd.ExecuteNonQuery();
            display_data();
            reset();
            MessageBox.Show("Successfully Updated");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = CRUD_Operations.Configuration.getInstance().getConnection();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from AssessmentComponent where Name = '" + text1.Text + "'";
            cmd.ExecuteNonQuery();
            display_data();
            reset();
            MessageBox.Show("Deleted Successfully");
        }

        private void search_Click(object sender, EventArgs e)
        {
            SqlConnection con = CRUD_Operations.Configuration.getInstance().getConnection();
            count = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from AssessmentComponent where Name= '" + text1.Text + "'";
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

       
private void display_Click(object sender, EventArgs e)
        {
            display_data();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            text1.Text = row.Cells[1].Value.ToString();
            RBox1.Text = row.Cells[2].Value.ToString();
            text2.Text = row.Cells[3].Value.ToString();
            dateTimePicker1.Text = row.Cells[4].Value.ToString();
            dateTimePicker.Text = row.Cells[5].Value.ToString();
            ABox2.Text = row.Cells[6].Value.ToString();
        }

        private void RBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = CRUD_Operations.Configuration.getInstance().getConnection();
            SqlCommand cmd = con.CreateCommand();
            dt = new DataTable();

            dr = null;
            cmd = new SqlCommand("SELECT Id FROM Rubric WHERE Id = '" + RBox1.Text + "'", con);
            dr = cmd.ExecuteReader();


            dr.Close();
        }

        private void ABox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = CRUD_Operations.Configuration.getInstance().getConnection();
            SqlCommand cmd = con.CreateCommand();
            dt = new DataTable();

            dr = null;
            cmd = new SqlCommand("SELECT Id FROM Assessment WHERE Id = '" + ABox2.Text + "'", con);
            dr = cmd.ExecuteReader();


            dr.Close();
        }
    }
}
