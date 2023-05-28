
namespace DB2020_CS_145
{
    partial class Student
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
            this.text1 = new System.Windows.Forms.TextBox();
            this.Insert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.TextBox();
            this.text3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text5 = new System.Windows.Forms.TextBox();
            this.text4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DD = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.text6 = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FName
            // 
            this.FName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FName.AutoSize = true;
            this.FName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FName.Location = new System.Drawing.Point(5, 7);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(74, 17);
            this.FName.TabIndex = 1;
            this.FName.Text = "First Name";
            // 
            // text1
            // 
            this.text1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text1.BackColor = System.Drawing.Color.White;
            this.text1.Location = new System.Drawing.Point(85, 4);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(244, 23);
            this.text1.TabIndex = 8;
            // 
            // Insert
            // 
            this.Insert.BackColor = System.Drawing.Color.Ivory;
            this.Insert.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Insert.Location = new System.Drawing.Point(292, 255);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(115, 29);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 290);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(879, 208);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(24, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Contact";
            // 
            // LName
            // 
            this.LName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LName.Location = new System.Drawing.Point(7, 43);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(72, 17);
            this.LName.TabIndex = 13;
            this.LName.Text = "Last Name";
            // 
            // text2
            // 
            this.text2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text2.BackColor = System.Drawing.Color.White;
            this.text2.Location = new System.Drawing.Point(85, 40);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(244, 23);
            this.text2.TabIndex = 14;
            // 
            // text3
            // 
            this.text3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text3.BackColor = System.Drawing.Color.White;
            this.text3.Location = new System.Drawing.Point(85, 78);
            this.text3.Name = "text3";
            this.text3.PlaceholderText = "(11 characters)";
            this.text3.Size = new System.Drawing.Size(244, 23);
            this.text3.TabIndex = 15;
            this.text3.TextChanged += new System.EventHandler(this.text3_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(439, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(394, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 34);
            this.label3.TabIndex = 17;
            this.label3.Text = "Registration Number";
            // 
            // text5
            // 
            this.text5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text5.BackColor = System.Drawing.Color.White;
            this.text5.Location = new System.Drawing.Point(485, 40);
            this.text5.Name = "text5";
            this.text5.PlaceholderText = "****-**-****";
            this.text5.Size = new System.Drawing.Size(287, 23);
            this.text5.TabIndex = 18;
            this.text5.TextChanged += new System.EventHandler(this.text5_TextChanged);
            // 
            // text4
            // 
            this.text4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text4.BackColor = System.Drawing.Color.White;
            this.text4.Location = new System.Drawing.Point(485, 4);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(287, 23);
            this.text4.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(433, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Status";
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.Controls.Add(this.DD, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Date, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(879, 52);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // DD
            // 
            this.DD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DD.AutoSize = true;
            this.DD.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DD.Location = new System.Drawing.Point(788, 17);
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
            this.Date.Location = new System.Drawing.Point(743, 17);
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
            this.label5.Location = new System.Drawing.Point(323, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 31);
            this.label5.TabIndex = 23;
            this.label5.Text = "STUDENT";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::DB2020_CS_145.Properties.Resources.student_male_64px1;
            this.pictureBox3.Location = new System.Drawing.Point(23, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.66998F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.62283F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.72846F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel2.Controls.Add(this.FName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.LName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.text5, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.text4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.text3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.text2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.text1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.text6, 3, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 87);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.54546F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.45454F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(879, 162);
            this.tableLayoutPanel2.TabIndex = 23;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // text6
            // 
            this.text6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text6.BackColor = System.Drawing.Color.White;
            this.text6.Location = new System.Drawing.Point(485, 78);
            this.text6.Name = "text6";
            this.text6.PlaceholderText = "5 for Active, 6 for InActive";
            this.text6.Size = new System.Drawing.Size(287, 23);
            this.text6.TabIndex = 21;
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.Ivory;
            this.Update.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Update.Location = new System.Drawing.Point(413, 255);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(115, 29);
            this.Update.TabIndex = 24;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Ivory;
            this.search.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.search.Location = new System.Drawing.Point(655, 255);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(115, 29);
            this.search.TabIndex = 25;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.button2_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Ivory;
            this.delete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete.Location = new System.Drawing.Point(534, 255);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(115, 29);
            this.delete.TabIndex = 26;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.Ivory;
            this.display.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.display.Location = new System.Drawing.Point(776, 255);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(115, 29);
            this.display.TabIndex = 27;
            this.display.Text = "Display";
            this.display.UseVisualStyleBackColor = false;
            this.display.Click += new System.EventHandler(this.button1_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(903, 510);
            this.Controls.Add(this.display);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.search);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Insert);
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FName;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.TextBox text3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text5;
        private System.Windows.Forms.TextBox text4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label DD;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox text6;
    }
}

