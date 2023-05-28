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
    public partial class RubricLevel : Form
    {
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        int count;
        int indexRow;
        public RubricLevel()
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
                    rubricbox.Items.Add(ROW["Id"].ToString());

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
                SqlCommand cmd = new SqlCommand("Insert into RubricLevel (RubricId, Details, MeasurementLevel)values (@RubricId, @Details, @MeasurementLevel)", con);               
                cmd.Parameters.AddWithValue("@RubricId", rubricbox.Text);
                cmd.Parameters.AddWithValue("@Details", text2.Text);
                cmd.Parameters.AddWithValue("@MeasurementLevel", text3.Text);
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
            rubricbox.Text = null;
            text2.Text = null;
            text3.Text = null;

        }

        public void display_data()
        {
            SqlConnection con = CRUD_Operations.Configuration.getInstance().getConnection();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from RubricLevel";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            SqlConnection con = CRUD_Operations.Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE RubricLevel SET RubricId=@RubricId, Details=@Details,MeasurementLevel=@MeasurementLevel WHERE RubricId=@RubricId", con);
            cmd.Parameters.AddWithValue("@RubricId", rubricbox.Text);
            cmd.Parameters.AddWithValue("@Details", text2.Text);
            cmd.Parameters.AddWithValue("@MeasurementLevel", text3.Text);
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
            cmd.CommandText = "delete from RubricLevel where RubricId = '" + rubricbox.Text + "'";
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
            cmd.CommandText = "select * from RubricLevel where RubricId = '" + rubricbox.Text + "'";
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

            rubricbox.Text = row.Cells[1].Value.ToString();
            text2.Text = row.Cells[2].Value.ToString();
            text3.Text = row.Cells[3].Value.ToString();
        }

        private void display_Click(object sender, EventArgs e)
        {
            display_data();
        }

        private void rubricbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = CRUD_Operations.Configuration.getInstance().getConnection();
            SqlCommand cmd = con.CreateCommand();
            dt = new DataTable();

            dr = null;
            cmd = new SqlCommand("SELECT Id FROM Rubric WHERE Id = '" + rubricbox.Text + "'", con);
            dr = cmd.ExecuteReader();


            dr.Close();
        }
    }
}
