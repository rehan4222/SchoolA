namespace SchoolA
{
    partial class Academic_Record
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_academicrollnumber = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_resultsheetclass = new System.Windows.Forms.TextBox();
            this.textBox_nameresultsheet = new System.Windows.Forms.TextBox();
            this.textBox_fnameresultsheet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView_academicrecord = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_academicrecord)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_academicrollnumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Student";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roll Number";
            // 
            // textBox_academicrollnumber
            // 
            this.textBox_academicrollnumber.Location = new System.Drawing.Point(87, 23);
            this.textBox_academicrollnumber.Name = "textBox_academicrollnumber";
            this.textBox_academicrollnumber.Size = new System.Drawing.Size(149, 20);
            this.textBox_academicrollnumber.TabIndex = 1;
            this.textBox_academicrollnumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_academicrollnumber_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_resultsheetclass);
            this.groupBox2.Controls.Add(this.textBox_nameresultsheet);
            this.groupBox2.Controls.Add(this.textBox_fnameresultsheet);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(252, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 86);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Details";
            // 
            // textBox_resultsheetclass
            // 
            this.textBox_resultsheetclass.Enabled = false;
            this.textBox_resultsheetclass.Location = new System.Drawing.Point(374, 29);
            this.textBox_resultsheetclass.Name = "textBox_resultsheetclass";
            this.textBox_resultsheetclass.Size = new System.Drawing.Size(148, 20);
            this.textBox_resultsheetclass.TabIndex = 5;
            // 
            // textBox_nameresultsheet
            // 
            this.textBox_nameresultsheet.Enabled = false;
            this.textBox_nameresultsheet.Location = new System.Drawing.Point(101, 29);
            this.textBox_nameresultsheet.Name = "textBox_nameresultsheet";
            this.textBox_nameresultsheet.Size = new System.Drawing.Size(207, 20);
            this.textBox_nameresultsheet.TabIndex = 4;
            // 
            // textBox_fnameresultsheet
            // 
            this.textBox_fnameresultsheet.Enabled = false;
            this.textBox_fnameresultsheet.Location = new System.Drawing.Point(101, 61);
            this.textBox_fnameresultsheet.Name = "textBox_fnameresultsheet";
            this.textBox_fnameresultsheet.Size = new System.Drawing.Size(207, 20);
            this.textBox_fnameresultsheet.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Father Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView_academicrecord);
            this.groupBox3.Location = new System.Drawing.Point(4, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(782, 261);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Record";
            // 
            // dataGridView_academicrecord
            // 
            this.dataGridView_academicrecord.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView_academicrecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_academicrecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView_academicrecord.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView_academicrecord.Location = new System.Drawing.Point(9, 20);
            this.dataGridView_academicrecord.Name = "dataGridView_academicrecord";
            this.dataGridView_academicrecord.Size = new System.Drawing.Size(761, 235);
            this.dataGridView_academicrecord.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Subjects";
            this.Column1.Name = "Column1";
            this.Column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Marks Obtained";
            this.Column2.Name = "Column2";
            this.Column2.Width = 180;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Total Marks";
            this.Column3.Name = "Column3";
            this.Column3.Width = 180;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Percentage";
            this.Column4.Name = "Column4";
            this.Column4.Width = 180;
            // 
            // Academic_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 379);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Academic_Record";
            this.Text = "Academic_Record";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_academicrecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_academicrollnumber;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_resultsheetclass;
        private System.Windows.Forms.TextBox textBox_nameresultsheet;
        private System.Windows.Forms.TextBox textBox_fnameresultsheet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView_academicrecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}