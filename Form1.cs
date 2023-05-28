using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DB2020_CS_145
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new Student());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CLO_Click(object sender, EventArgs e)
        {
            loadform(new Clo());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new Rubric());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new RubricLevel());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new Assessment());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadform(new ClassAttendance());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            loadform(new StudentAttendance());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            loadform(new StudentResult());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            loadform(new AssessmentComponent());
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
