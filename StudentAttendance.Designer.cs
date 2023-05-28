
namespace DB2020_CS_145
{
    partial class StudentAttendance
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DD = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.stdAtt = new System.Windows.Forms.ComboBox();
            this.stdID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stdRegNo = new System.Windows.Forms.TextBox();
            this.display = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.attdtxt = new System.Windows.Forms.TextBox();
            this.looktext = new System.Windows.Forms.TextBox();
            this.InsertStd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FName
            // 
            this.FName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FName.AutoSize = true;
            this.FName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FName.Location = new System.Drawing.Point(82, 16);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(73, 17);
            this.FName.TabIndex = 1;
            this.FName.Text = "Student ID";
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
            this.dataGridView1.Location = new System.Drawing.Point(11, 297);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(959, 208);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LName
            // 
            this.LName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LName.Location = new System.Drawing.Point(77, 66);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(78, 17);
            this.LName.TabIndex = 13;
            this.LName.Text = "Attendance";
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel1.Controls.Add(this.DD, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Date, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox9, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(959, 52);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // DD
            // 
            this.DD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DD.AutoSize = true;
            this.DD.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DD.Location = new System.Drawing.Point(864, 17);
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
            this.Date.Location = new System.Drawing.Point(819, 17);
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
            this.label5.Location = new System.Drawing.Point(269, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(337, 31);
            this.label5.TabIndex = 23;
            this.label5.Text = "STUDENT ATTENDANCE";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox9.Image = global::DB2020_CS_145.Properties.Resources.attendance_50px;
            this.pictureBox9.Location = new System.Drawing.Point(28, 7);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(39, 38);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 24;
            this.pictureBox9.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.49602F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.50398F));
            this.tableLayoutPanel2.Controls.Add(this.stdAtt, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.FName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.LName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.stdID, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.stdRegNo, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 87);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.54945F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.45055F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(959, 162);
            this.tableLayoutPanel2.TabIndex = 23;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // stdAtt
            // 
            this.stdAtt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stdAtt.FormattingEnabled = true;
            this.stdAtt.Location = new System.Drawing.Point(163, 63);
            this.stdAtt.Name = "stdAtt";
            this.stdAtt.Size = new System.Drawing.Size(791, 23);
            this.stdAtt.TabIndex = 18;
            this.stdAtt.SelectedIndexChanged += new System.EventHandler(this.stdAtt_SelectedIndexChanged);
            // 
            // stdID
            // 
            this.stdID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stdID.FormattingEnabled = true;
            this.stdID.Location = new System.Drawing.Point(161, 13);
            this.stdID.Name = "stdID";
            this.stdID.Size = new System.Drawing.Size(794, 23);
            this.stdID.TabIndex = 17;
            this.stdID.SelectedIndexChanged += new System.EventHandler(this.stdID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(102, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Reg No";
            // 
            // stdRegNo
            // 
            this.stdRegNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stdRegNo.Location = new System.Drawing.Point(161, 108);
            this.stdRegNo.Name = "stdRegNo";
            this.stdRegNo.Size = new System.Drawing.Size(795, 23);
            this.stdRegNo.TabIndex = 21;
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.Ivory;
            this.display.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.display.Location = new System.Drawing.Point(856, 256);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(115, 29);
            this.display.TabIndex = 41;
            this.display.Text = "Display";
            this.display.UseVisualStyleBackColor = false;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Ivory;
            this.delete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete.Location = new System.Drawing.Point(735, 256);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(115, 29);
            this.delete.TabIndex = 40;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.Ivory;
            this.Update.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Update.Location = new System.Drawing.Point(614, 256);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(115, 29);
            this.Update.TabIndex = 38;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // attdtxt
            // 
            this.attdtxt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.attdtxt.Location = new System.Drawing.Point(574, 259);
            this.attdtxt.Name = "attdtxt";
            this.attdtxt.Size = new System.Drawing.Size(34, 23);
            this.attdtxt.TabIndex = 42;
            // 
            // looktext
            // 
            this.looktext.BackColor = System.Drawing.Color.LightSteelBlue;
            this.looktext.Location = new System.Drawing.Point(545, 259);
            this.looktext.Name = "looktext";
            this.looktext.Size = new System.Drawing.Size(23, 23);
            this.looktext.TabIndex = 43;
            // 
            // InsertStd
            // 
            this.InsertStd.BackColor = System.Drawing.Color.Ivory;
            this.InsertStd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InsertStd.Location = new System.Drawing.Point(493, 256);
            this.InsertStd.Name = "InsertStd";
            this.InsertStd.Size = new System.Drawing.Size(115, 29);
            this.InsertStd.TabIndex = 44;
            this.InsertStd.Text = "Insert";
            this.InsertStd.UseVisualStyleBackColor = false;
            this.InsertStd.Click += new System.EventHandler(this.InsertStd_Click);
            // 
            // StudentAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(983, 510);
            this.Controls.Add(this.InsertStd);
            this.Controls.Add(this.looktext);
            this.Controls.Add(this.attdtxt);
            this.Controls.Add(this.display);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StudentAttendance";
            this.Text = "Rubric Level";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label DD;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.ComboBox stdAtt;
        private System.Windows.Forms.ComboBox stdID;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stdRegNo;
        private System.Windows.Forms.TextBox attdtxt;
        private System.Windows.Forms.TextBox looktext;
        private System.Windows.Forms.Button InsertStd;
    }
}

