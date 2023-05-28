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
    public partial class Clo : Form
    {
        int indexRow;
        int count;
        public Clo()
        {
            InitializeComponent();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = CRUD_Operations.Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into Clo values (@Name, @DateCreated, @DateUpdated)", con);
                cmd.Parameters.AddWithValue("@Name", text1.Text);
                cmd.Parameters.AddWithValue("@DateCreated", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@DateUpdated", dateTimePicker2.Value.Date);
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
          
            

        }

        public void display_data()
        {
            SqlConnection con = CRUD_Operations.Configuration.getInstance().getConnection();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Clo";
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
            display_data();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            SqlConnection con = CRUD_Operations.Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE Clo SET Name=@Name, DateCreated=@DateCreated, DateUpdated=@DateUpdated WHERE Name=@Name", con);
            cmd.Parameters.AddWithValue("Name", text1.Text);
            cmd.Parameters.AddWithValue("DateCreated", dateTimePicker1.Value.Date);
            cmd.Parameters.AddWithValue("DateUpdated", dateTimePicker2.Value.Date);
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
            cmd.CommandText = "delete from Clo where Name = '" + text1.Text + "'";
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
            cmd.CommandText = "select * from Clo where Name= '" + text1.Text + "'";
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
            dateTimePicker1.Text = row.Cells[2].Value.ToString();
            dateTimePicker2.Text = row.Cells[3].Value.ToString();
        }

        private void display_Click(object sender, EventArgs e)
        {
            display_data();
        }
    }
}
