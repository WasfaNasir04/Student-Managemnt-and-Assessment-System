
namespace DB2020_CS_145
{
    partial class Rubric
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Ridtxt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.DD = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.display = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.cloIdbox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // FName
            // 
            this.FName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FName.AutoSize = true;
            this.FName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FName.Location = new System.Drawing.Point(33, 19);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(48, 17);
            this.FName.TabIndex = 1;
            this.FName.Text = "Details";
            // 
            // text1
            // 
            this.text1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text1.BackColor = System.Drawing.Color.White;
            this.text1.Location = new System.Drawing.Point(87, 16);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(277, 23);
            this.text1.TabIndex = 8;
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
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(383, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "CloId";
            // 
            // Ridtxt
            // 
            this.Ridtxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Ridtxt.BackColor = System.Drawing.Color.White;
            this.Ridtxt.Location = new System.Drawing.Point(87, 66);
            this.Ridtxt.Name = "Ridtxt";
            this.Ridtxt.Size = new System.Drawing.Size(277, 23);
            this.Ridtxt.TabIndex = 19;
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox5, 0, 0);
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
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.Image = global::DB2020_CS_145.Properties.Resources.rubik_s_cube_64px;
            this.pictureBox5.Location = new System.Drawing.Point(23, 7);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(39, 38);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // DD
            // 
            this.DD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DD.AutoSize = true;
            this.DD.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DD.Location = new System.Drawing.Point(793, 17);
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
            this.Date.Location = new System.Drawing.Point(748, 17);
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
            this.label5.Location = new System.Drawing.Point(329, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 31);
            this.label5.TabIndex = 23;
            this.label5.Text = "RUBRICS";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.66998F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.375F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.FName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.text1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cloIdbox, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.Ridtxt, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 87);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.54546F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(879, 101);
            this.tableLayoutPanel2.TabIndex = 23;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(16, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rubric Id:";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.Ivory;
            this.display.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.display.Location = new System.Drawing.Point(776, 238);
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
            this.delete.Location = new System.Drawing.Point(531, 238);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(115, 29);
            this.delete.TabIndex = 40;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Ivory;
            this.search.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.search.Location = new System.Drawing.Point(652, 238);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(115, 29);
            this.search.TabIndex = 39;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.Ivory;
            this.Update.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Update.Location = new System.Drawing.Point(410, 238);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(115, 29);
            this.Update.TabIndex = 38;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Insert
            // 
            this.Insert.BackColor = System.Drawing.Color.Ivory;
            this.Insert.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Insert.Location = new System.Drawing.Point(289, 238);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(115, 29);
            this.Insert.TabIndex = 37;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = false;
            this.Insert.Click += new System.EventHandler(this.Insert_Click_1);
            // 
            // cloIdbox
            // 
            this.cloIdbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cloIdbox.FormattingEnabled = true;
            this.cloIdbox.Location = new System.Drawing.Point(429, 16);
            this.cloIdbox.Name = "cloIdbox";
            this.cloIdbox.Size = new System.Drawing.Size(354, 23);
            this.cloIdbox.TabIndex = 20;
            this.cloIdbox.SelectedIndexChanged += new System.EventHandler(this.rubricIdbox_SelectedIndexChanged);
            // 
            // Rubric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(903, 510);
            this.Controls.Add(this.display);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.search);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Rubric";
            this.Text = "Rubrics";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FName;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Ridtxt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label DD;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.TextBox cloidtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cloIdbox;
    }
}

