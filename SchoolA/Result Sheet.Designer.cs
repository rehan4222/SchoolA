namespace SchoolA
{
    partial class Result_Sheet
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
            this.textBox_rollresultsheet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_resultsheetclass = new System.Windows.Forms.TextBox();
            this.textBox_nameresultsheet = new System.Windows.Forms.TextBox();
            this.textBox_fnameresultsheet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_saveresultsheet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_totmarksrsultsheet = new System.Windows.Forms.TextBox();
            this.textBox_marksobtresultsheet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_subjectresultsheet = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView_resultsheet = new System.Windows.Forms.DataGridView();
            this.dateTimePicker_resultsheet = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_examtyperesultsheet = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_resultsheet)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker_resultsheet);
            this.groupBox1.Controls.Add(this.textBox_rollresultsheet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Student";
            // 
            // textBox_rollresultsheet
            // 
            this.textBox_rollresultsheet.Location = new System.Drawing.Point(82, 29);
            this.textBox_rollresultsheet.Name = "textBox_rollresultsheet";
            this.textBox_rollresultsheet.Size = new System.Drawing.Size(207, 20);
            this.textBox_rollresultsheet.TabIndex = 1;
            this.textBox_rollresultsheet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_rollresultsheet_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roll Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_resultsheetclass);
            this.groupBox2.Controls.Add(this.textBox_nameresultsheet);
            this.groupBox2.Controls.Add(this.textBox_fnameresultsheet);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(313, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 86);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Details";
            // 
            // textBox_resultsheetclass
            // 
            this.textBox_resultsheetclass.Enabled = false;
            this.textBox_resultsheetclass.Location = new System.Drawing.Point(374, 29);
            this.textBox_resultsheetclass.Name = "textBox_resultsheetclass";
            this.textBox_resultsheetclass.Size = new System.Drawing.Size(104, 20);
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
            this.groupBox3.Controls.Add(this.button_saveresultsheet);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox_totmarksrsultsheet);
            this.groupBox3.Controls.Add(this.textBox_marksobtresultsheet);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.comboBox_subjectresultsheet);
            this.groupBox3.Location = new System.Drawing.Point(12, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(785, 66);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result Entry";
            // 
            // button_saveresultsheet
            // 
            this.button_saveresultsheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_saveresultsheet.Location = new System.Drawing.Point(591, 37);
            this.button_saveresultsheet.Name = "button_saveresultsheet";
            this.button_saveresultsheet.Size = new System.Drawing.Size(165, 23);
            this.button_saveresultsheet.TabIndex = 6;
            this.button_saveresultsheet.Text = "Save";
            this.button_saveresultsheet.UseVisualStyleBackColor = true;
            this.button_saveresultsheet.Click += new System.EventHandler(this.button_saveresultsheet_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(507, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Total Marks";
            // 
            // textBox_totmarksrsultsheet
            // 
            this.textBox_totmarksrsultsheet.Location = new System.Drawing.Point(591, 13);
            this.textBox_totmarksrsultsheet.Name = "textBox_totmarksrsultsheet";
            this.textBox_totmarksrsultsheet.Size = new System.Drawing.Size(165, 20);
            this.textBox_totmarksrsultsheet.TabIndex = 4;
            // 
            // textBox_marksobtresultsheet
            // 
            this.textBox_marksobtresultsheet.Location = new System.Drawing.Point(336, 14);
            this.textBox_marksobtresultsheet.Name = "textBox_marksobtresultsheet";
            this.textBox_marksobtresultsheet.Size = new System.Drawing.Size(165, 20);
            this.textBox_marksobtresultsheet.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Marks Obtained";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Subject";
            // 
            // comboBox_subjectresultsheet
            // 
            this.comboBox_subjectresultsheet.FormattingEnabled = true;
            this.comboBox_subjectresultsheet.Location = new System.Drawing.Point(56, 13);
            this.comboBox_subjectresultsheet.Name = "comboBox_subjectresultsheet";
            this.comboBox_subjectresultsheet.Size = new System.Drawing.Size(165, 21);
            this.comboBox_subjectresultsheet.TabIndex = 0;
            this.comboBox_subjectresultsheet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_subjectresultsheet_MouseClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView_resultsheet);
            this.groupBox4.Location = new System.Drawing.Point(12, 242);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(785, 173);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Result Details";
            // 
            // dataGridView_resultsheet
            // 
            this.dataGridView_resultsheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_resultsheet.Location = new System.Drawing.Point(7, 20);
            this.dataGridView_resultsheet.Name = "dataGridView_resultsheet";
            this.dataGridView_resultsheet.Size = new System.Drawing.Size(770, 147);
            this.dataGridView_resultsheet.TabIndex = 0;
            // 
            // dateTimePicker_resultsheet
            // 
            this.dateTimePicker_resultsheet.Location = new System.Drawing.Point(82, 56);
            this.dateTimePicker_resultsheet.Name = "dateTimePicker_resultsheet";
            this.dateTimePicker_resultsheet.Size = new System.Drawing.Size(207, 20);
            this.dateTimePicker_resultsheet.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBox_examtyperesultsheet);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(12, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(785, 69);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Exam Type";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // comboBox_examtyperesultsheet
            // 
            this.comboBox_examtyperesultsheet.FormattingEnabled = true;
            this.comboBox_examtyperesultsheet.Location = new System.Drawing.Point(85, 26);
            this.comboBox_examtyperesultsheet.Name = "comboBox_examtyperesultsheet";
            this.comboBox_examtyperesultsheet.Size = new System.Drawing.Size(204, 21);
            this.comboBox_examtyperesultsheet.TabIndex = 1;
            this.comboBox_examtyperesultsheet.SelectedIndexChanged += new System.EventHandler(this.comboBox_examtyperesultsheet_SelectedIndexChanged);
            // 
            // Result_Sheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 427);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Result_Sheet";
            this.Text = "Result_Sheet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_resultsheet)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_rollresultsheet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_resultsheetclass;
        private System.Windows.Forms.TextBox textBox_nameresultsheet;
        private System.Windows.Forms.TextBox textBox_fnameresultsheet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_totmarksrsultsheet;
        private System.Windows.Forms.TextBox textBox_marksobtresultsheet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_subjectresultsheet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView_resultsheet;
        private System.Windows.Forms.Button button_saveresultsheet;
        private System.Windows.Forms.DateTimePicker dateTimePicker_resultsheet;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_examtyperesultsheet;
    }
}