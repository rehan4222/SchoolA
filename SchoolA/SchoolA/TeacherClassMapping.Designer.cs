namespace SchoolA
{
    partial class TeacherClassMapping
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
            this.groupBox_subbutton = new System.Windows.Forms.GroupBox();
            this.button_updateteachersubjectmapping = new System.Windows.Forms.Button();
            this.button_deleteteachersubjectmapping = new System.Windows.Forms.Button();
            this.button_SaveTeacherClassMapping = new System.Windows.Forms.Button();
            this.button_newteachersubjectmapping = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_subjectmap = new System.Windows.Forms.ComboBox();
            this.comboBox_teachermap = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_teacherclassmapping = new System.Windows.Forms.DataGridView();
            this.groupBox_subbutton.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_teacherclassmapping)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_subbutton
            // 
            this.groupBox_subbutton.Controls.Add(this.button_updateteachersubjectmapping);
            this.groupBox_subbutton.Controls.Add(this.button_deleteteachersubjectmapping);
            this.groupBox_subbutton.Controls.Add(this.button_SaveTeacherClassMapping);
            this.groupBox_subbutton.Controls.Add(this.button_newteachersubjectmapping);
            this.groupBox_subbutton.Location = new System.Drawing.Point(400, 6);
            this.groupBox_subbutton.Name = "groupBox_subbutton";
            this.groupBox_subbutton.Size = new System.Drawing.Size(100, 262);
            this.groupBox_subbutton.TabIndex = 10;
            this.groupBox_subbutton.TabStop = false;
            // 
            // button_updateteachersubjectmapping
            // 
            this.button_updateteachersubjectmapping.Enabled = false;
            this.button_updateteachersubjectmapping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_updateteachersubjectmapping.Location = new System.Drawing.Point(6, 191);
            this.button_updateteachersubjectmapping.Name = "button_updateteachersubjectmapping";
            this.button_updateteachersubjectmapping.Size = new System.Drawing.Size(89, 48);
            this.button_updateteachersubjectmapping.TabIndex = 3;
            this.button_updateteachersubjectmapping.Text = "Update";
            this.button_updateteachersubjectmapping.UseVisualStyleBackColor = true;
            // 
            // button_deleteteachersubjectmapping
            // 
            this.button_deleteteachersubjectmapping.Enabled = false;
            this.button_deleteteachersubjectmapping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_deleteteachersubjectmapping.Location = new System.Drawing.Point(6, 137);
            this.button_deleteteachersubjectmapping.Name = "button_deleteteachersubjectmapping";
            this.button_deleteteachersubjectmapping.Size = new System.Drawing.Size(88, 48);
            this.button_deleteteachersubjectmapping.TabIndex = 2;
            this.button_deleteteachersubjectmapping.Text = "Delete";
            this.button_deleteteachersubjectmapping.UseVisualStyleBackColor = true;
            // 
            // button_SaveTeacherClassMapping
            // 
            this.button_SaveTeacherClassMapping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SaveTeacherClassMapping.Location = new System.Drawing.Point(6, 83);
            this.button_SaveTeacherClassMapping.Name = "button_SaveTeacherClassMapping";
            this.button_SaveTeacherClassMapping.Size = new System.Drawing.Size(88, 48);
            this.button_SaveTeacherClassMapping.TabIndex = 3;
            this.button_SaveTeacherClassMapping.Text = "Save";
            this.button_SaveTeacherClassMapping.UseVisualStyleBackColor = true;
            this.button_SaveTeacherClassMapping.Click += new System.EventHandler(this.button_SaveTeacherClassMapping_Click);
            // 
            // button_newteachersubjectmapping
            // 
            this.button_newteachersubjectmapping.BackColor = System.Drawing.Color.White;
            this.button_newteachersubjectmapping.Enabled = false;
            this.button_newteachersubjectmapping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newteachersubjectmapping.Location = new System.Drawing.Point(6, 30);
            this.button_newteachersubjectmapping.Name = "button_newteachersubjectmapping";
            this.button_newteachersubjectmapping.Size = new System.Drawing.Size(88, 47);
            this.button_newteachersubjectmapping.TabIndex = 0;
            this.button_newteachersubjectmapping.Text = "New";
            this.button_newteachersubjectmapping.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_subjectmap);
            this.groupBox1.Controls.Add(this.comboBox_teachermap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 98);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teacher Subject Mapping";
            // 
            // comboBox_subjectmap
            // 
            this.comboBox_subjectmap.FormattingEnabled = true;
            this.comboBox_subjectmap.Location = new System.Drawing.Point(81, 64);
            this.comboBox_subjectmap.Name = "comboBox_subjectmap";
            this.comboBox_subjectmap.Size = new System.Drawing.Size(288, 21);
            this.comboBox_subjectmap.TabIndex = 2;
            this.comboBox_subjectmap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_subjectmap_MouseClick);
            // 
            // comboBox_teachermap
            // 
            this.comboBox_teachermap.FormattingEnabled = true;
            this.comboBox_teachermap.Location = new System.Drawing.Point(81, 36);
            this.comboBox_teachermap.Name = "comboBox_teachermap";
            this.comboBox_teachermap.Size = new System.Drawing.Size(288, 21);
            this.comboBox_teachermap.TabIndex = 1;
            this.comboBox_teachermap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_teachermap_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_teacherclassmapping);
            this.groupBox2.Location = new System.Drawing.Point(19, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 145);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // dataGridView_teacherclassmapping
            // 
            this.dataGridView_teacherclassmapping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_teacherclassmapping.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_teacherclassmapping.Name = "dataGridView_teacherclassmapping";
            this.dataGridView_teacherclassmapping.Size = new System.Drawing.Size(363, 119);
            this.dataGridView_teacherclassmapping.TabIndex = 0;
            // 
            // TeacherClassMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(506, 275);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_subbutton);
            this.Controls.Add(this.groupBox1);
            this.Name = "TeacherClassMapping";
            this.Text = "TeacherClassMapping";
            this.groupBox_subbutton.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_teacherclassmapping)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_subbutton;
        private System.Windows.Forms.Button button_updateteachersubjectmapping;
        private System.Windows.Forms.Button button_deleteteachersubjectmapping;
        private System.Windows.Forms.Button button_SaveTeacherClassMapping;
        private System.Windows.Forms.Button button_newteachersubjectmapping;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_subjectmap;
        private System.Windows.Forms.ComboBox comboBox_teachermap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_teacherclassmapping;
    }
}