namespace SchoolA
{
    partial class Add_TimeTable
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
            this.comboBox_searchtimetable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_classtimetable = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Subjecttimetable = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_teachertimetable = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_timingtimetable = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_daytimetable = new System.Windows.Forms.ComboBox();
            this.button_Saveaddtimetable = new System.Windows.Forms.Button();
            this.button_GetDaystimetable = new System.Windows.Forms.Button();
            this.button_printaddtimetable = new System.Windows.Forms.Button();
            this.dataGridView_addtimetable = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_addtimetable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_printaddtimetable);
            this.groupBox1.Controls.Add(this.button_GetDaystimetable);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_searchtimetable);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // comboBox_searchtimetable
            // 
            this.comboBox_searchtimetable.FormattingEnabled = true;
            this.comboBox_searchtimetable.Location = new System.Drawing.Point(43, 49);
            this.comboBox_searchtimetable.Name = "comboBox_searchtimetable";
            this.comboBox_searchtimetable.Size = new System.Drawing.Size(168, 21);
            this.comboBox_searchtimetable.TabIndex = 0;
            this.comboBox_searchtimetable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_searchtimetable_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Days";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_Saveaddtimetable);
            this.groupBox2.Controls.Add(this.comboBox_daytimetable);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBox_timingtimetable);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox_teachertimetable);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBox_Subjecttimetable);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBox_classtimetable);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(239, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 113);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Class";
            // 
            // comboBox_classtimetable
            // 
            this.comboBox_classtimetable.FormattingEnabled = true;
            this.comboBox_classtimetable.Location = new System.Drawing.Point(56, 17);
            this.comboBox_classtimetable.Name = "comboBox_classtimetable";
            this.comboBox_classtimetable.Size = new System.Drawing.Size(121, 21);
            this.comboBox_classtimetable.TabIndex = 1;
            this.comboBox_classtimetable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_classtimetable_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject";
            // 
            // comboBox_Subjecttimetable
            // 
            this.comboBox_Subjecttimetable.FormattingEnabled = true;
            this.comboBox_Subjecttimetable.Location = new System.Drawing.Point(56, 47);
            this.comboBox_Subjecttimetable.Name = "comboBox_Subjecttimetable";
            this.comboBox_Subjecttimetable.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Subjecttimetable.TabIndex = 3;
            this.comboBox_Subjecttimetable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_Subjecttimetable_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Teacher";
            // 
            // comboBox_teachertimetable
            // 
            this.comboBox_teachertimetable.FormattingEnabled = true;
            this.comboBox_teachertimetable.Location = new System.Drawing.Point(237, 17);
            this.comboBox_teachertimetable.Name = "comboBox_teachertimetable";
            this.comboBox_teachertimetable.Size = new System.Drawing.Size(121, 21);
            this.comboBox_teachertimetable.TabIndex = 5;
            this.comboBox_teachertimetable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_teachertimetable_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Timing";
            // 
            // comboBox_timingtimetable
            // 
            this.comboBox_timingtimetable.FormattingEnabled = true;
            this.comboBox_timingtimetable.Location = new System.Drawing.Point(237, 44);
            this.comboBox_timingtimetable.Name = "comboBox_timingtimetable";
            this.comboBox_timingtimetable.Size = new System.Drawing.Size(121, 21);
            this.comboBox_timingtimetable.TabIndex = 7;
            this.comboBox_timingtimetable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_timingtimetable_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Day";
            // 
            // comboBox_daytimetable
            // 
            this.comboBox_daytimetable.FormattingEnabled = true;
            this.comboBox_daytimetable.Location = new System.Drawing.Point(56, 73);
            this.comboBox_daytimetable.Name = "comboBox_daytimetable";
            this.comboBox_daytimetable.Size = new System.Drawing.Size(121, 21);
            this.comboBox_daytimetable.TabIndex = 2;
            this.comboBox_daytimetable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_daytimetable_MouseClick);
            // 
            // button_Saveaddtimetable
            // 
            this.button_Saveaddtimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Saveaddtimetable.Location = new System.Drawing.Point(270, 70);
            this.button_Saveaddtimetable.Name = "button_Saveaddtimetable";
            this.button_Saveaddtimetable.Size = new System.Drawing.Size(88, 35);
            this.button_Saveaddtimetable.TabIndex = 9;
            this.button_Saveaddtimetable.Text = "Save";
            this.button_Saveaddtimetable.UseVisualStyleBackColor = true;
            this.button_Saveaddtimetable.Click += new System.EventHandler(this.button_Saveaddtimetable_Click);
            // 
            // button_GetDaystimetable
            // 
            this.button_GetDaystimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GetDaystimetable.Location = new System.Drawing.Point(43, 73);
            this.button_GetDaystimetable.Name = "button_GetDaystimetable";
            this.button_GetDaystimetable.Size = new System.Drawing.Size(74, 37);
            this.button_GetDaystimetable.TabIndex = 2;
            this.button_GetDaystimetable.Text = "Get";
            this.button_GetDaystimetable.UseVisualStyleBackColor = true;
            this.button_GetDaystimetable.Click += new System.EventHandler(this.button_GetDaystimetable_Click);
            // 
            // button_printaddtimetable
            // 
            this.button_printaddtimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_printaddtimetable.Location = new System.Drawing.Point(123, 73);
            this.button_printaddtimetable.Name = "button_printaddtimetable";
            this.button_printaddtimetable.Size = new System.Drawing.Size(88, 37);
            this.button_printaddtimetable.TabIndex = 3;
            this.button_printaddtimetable.Text = "Print";
            this.button_printaddtimetable.UseVisualStyleBackColor = true;
            // 
            // dataGridView_addtimetable
            // 
            this.dataGridView_addtimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_addtimetable.Location = new System.Drawing.Point(4, 123);
            this.dataGridView_addtimetable.Name = "dataGridView_addtimetable";
            this.dataGridView_addtimetable.Size = new System.Drawing.Size(620, 150);
            this.dataGridView_addtimetable.TabIndex = 2;
            // 
            // Add_TimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(636, 279);
            this.Controls.Add(this.dataGridView_addtimetable);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Add_TimeTable";
            this.Text = "Add_TimeTable";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_addtimetable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_searchtimetable;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_daytimetable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_timingtimetable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_teachertimetable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Subjecttimetable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_classtimetable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_printaddtimetable;
        private System.Windows.Forms.Button button_GetDaystimetable;
        private System.Windows.Forms.Button button_Saveaddtimetable;
        private System.Windows.Forms.DataGridView dataGridView_addtimetable;
    }
}