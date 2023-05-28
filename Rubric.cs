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
    public partial class Rubric : Form
    {
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        int count;
        int indexRow;
        public Rubric()
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
                da = new SqlDataAdapter("SELECT * FROM Clo ", con);
                dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow ROW in dt.Rows)
                {
                    cloIdbox.Items.Add(ROW["Id"].ToString());

                }
            }

           catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        
        }

        private void Insert_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = CRUD_Operations.Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into Rubric (Id, Details, CloId) values (@Id, @Details, @CloId)", con);
                
                cmd.Parameters.AddWithValue("@Details", text1.Text);
                cmd.Parameters.AddWithValue("@CloId", cloIdbox.Text);
                cmd.Parameters.AddWithValue("@Id", Ridtxt.Text);
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
            Ridtxt.Text = null;

        }

        public void display_data()
        {
            SqlConnection con = CRUD_Operations.Configuration.getInstance().getConnection();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Rubric";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            SqlConnection con = CRUD_Operations.Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE Rubric SET Id=@Id,Details=@Details, CloId=@CloId WHERE CloId=@CloId", con);
            cmd.Parameters.AddWithValue("Details", text1.Text);
            cmd.Parameters.AddWithValue("Id", Ridtxt.Text);
            cmd.Parameters.AddWithValue("CloId", cloIdbox.Text);
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
            cmd.CommandText = "delete from Rubric where CloId = '" + Ridtxt.Text + "'";
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
            cmd.CommandText = "select * from Rubric where CloId= '" + Ridtxt.Text + "'";
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
            Ridtxt.Text = row.Cells[0].Value.ToString();
            cloIdbox.Text = row.Cells[2].Value.ToString();

        }

        private void rubricIdbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = CRUD_Operations.Configuration.getInstance().getConnection();
            SqlCommand cmd = con.CreateCommand();
            dt = new DataTable();

            dr = null;
            cmd = new SqlCommand("SELECT Id FROM Clo WHERE Id = '" + cloIdbox.Text + "'", con);
            dr = cmd.ExecuteReader();

            
            dr.Close();
        }
    }
}
