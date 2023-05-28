
namespace DB2020_CS_145
{
    partial class ClassAttendance
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FName = new System.Windows.Forms.Label();
            this.Insert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.DD = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.display = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FName
            // 
            this.FName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FName.AutoSize = true;
            this.FName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FName.Location = new System.Drawing.Point(7, 22);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(110, 17);
            this.FName.TabIndex = 1;
            this.FName.Text = "Attendance Date";
            // 
            // Insert
            // 
            this.Insert.BackColor = System.Drawing.Color.Ivory;
            this.Insert.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Insert.Location = new System.Drawing.Point(573, 207);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(129, 29);
            this.Insert.TabIndex = 10;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = false;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Khaki;
            this.dataGridView1.Location = new System.Drawing.Point(12, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(879, 247);
            this.dataGridView1.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FloralWhite;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.17656F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.82344F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DD, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Date, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(879, 52);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox8.Image = global::DB2020_CS_145.Properties.Resources.attendance_30px;
            this.pictureBox8.Location = new System.Drawing.Point(23, 7);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(39, 38);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 24;
            this.pictureBox8.TabStop = false;
            // 
            // DD
            // 
            this.DD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DD.AutoSize = true;
            this.DD.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DD.Location = new System.Drawing.Point(795, 17);
            this.DD.Name = "DD";
            this.DD.Size = new System.Drawing.Size(36, 17);
            this.DD.TabIndex = 23;
            this.DD.Text = "Date";
            this.DD.Click += new System.EventHandler(this.label7_Click);
            // 
            // Date
            // 
            this.Date.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Date.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Date.Location = new System.Drawing.Point(750, 17);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(39, 17);
            this.Date.TabIndex = 23;
            this.Date.Text = "Date:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(251, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 31);
            this.label5.TabIndex = 23;
            this.label5.Text = "CLASS ATTENDANCE";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.76564F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.23436F));
            this.tableLayoutPanel2.Controls.Add(this.FName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker1, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 117);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.54546F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(879, 61);
            this.tableLayoutPanel2.TabIndex = 23;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(753, 23);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.Ivory;
            this.display.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.display.Location = new System.Drawing.Point(708, 207);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(129, 29);
            this.display.TabIndex = 24;
            this.display.Text = "Display";
            this.display.UseVisualStyleBackColor = false;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // ClassAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(903, 510);
            this.Controls.Add(this.display);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Insert);
            this.Name = "ClassAttendance";
            this.Text = "Class Attendance";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FName;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label DD;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button display;
    }
}

