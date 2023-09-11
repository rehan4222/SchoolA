namespace SchoolA
{
    partial class Subjects
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_classsubjects = new System.Windows.Forms.ComboBox();
            this.textBox_subjects = new System.Windows.Forms.TextBox();
            this.groupBox_subjects = new System.Windows.Forms.GroupBox();
            this.groupBox_subbutton = new System.Windows.Forms.GroupBox();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_deletesubject = new System.Windows.Forms.Button();
            this.button_Savesubjects = new System.Windows.Forms.Button();
            this.button_newsubjects = new System.Windows.Forms.Button();
            this.dataGridView_subjects = new System.Windows.Forms.DataGridView();
            this.groupBox_subjects.SuspendLayout();
            this.groupBox_subbutton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_subjects)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class";
            // 
            // comboBox_classsubjects
            // 
            this.comboBox_classsubjects.FormattingEnabled = true;
            this.comboBox_classsubjects.Location = new System.Drawing.Point(88, 42);
            this.comboBox_classsubjects.Name = "comboBox_classsubjects";
            this.comboBox_classsubjects.Size = new System.Drawing.Size(121, 21);
            this.comboBox_classsubjects.TabIndex = 2;
            this.comboBox_classsubjects.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_classsubjects_MouseClick);
            // 
            // textBox_subjects
            // 
            this.textBox_subjects.Location = new System.Drawing.Point(88, 85);
            this.textBox_subjects.Name = "textBox_subjects";
            this.textBox_subjects.Size = new System.Drawing.Size(121, 20);
            this.textBox_subjects.TabIndex = 3;
            // 
            // groupBox_subjects
            // 
            this.groupBox_subjects.Controls.Add(this.label2);
            this.groupBox_subjects.Controls.Add(this.textBox_subjects);
            this.groupBox_subjects.Controls.Add(this.label1);
            this.groupBox_subjects.Controls.Add(this.comboBox_classsubjects);
            this.groupBox_subjects.Location = new System.Drawing.Point(12, 12);
            this.groupBox_subjects.Name = "groupBox_subjects";
            this.groupBox_subjects.Size = new System.Drawing.Size(468, 127);
            this.groupBox_subjects.TabIndex = 4;
            this.groupBox_subjects.TabStop = false;
            this.groupBox_subjects.Text = "Subject Name";
            // 
            // groupBox_subbutton
            // 
            this.groupBox_subbutton.Controls.Add(this.button_Update);
            this.groupBox_subbutton.Controls.Add(this.button_deletesubject);
            this.groupBox_subbutton.Controls.Add(this.button_Savesubjects);
            this.groupBox_subbutton.Controls.Add(this.button_newsubjects);
            this.groupBox_subbutton.Location = new System.Drawing.Point(12, 146);
            this.groupBox_subbutton.Name = "groupBox_subbutton";
            this.groupBox_subbutton.Size = new System.Drawing.Size(468, 100);
            this.groupBox_subbutton.TabIndex = 5;
            this.groupBox_subbutton.TabStop = false;
            // 
            // button_Update
            // 
            this.button_Update.Enabled = false;
            this.button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Update.Location = new System.Drawing.Point(344, 30);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(88, 48);
            this.button_Update.TabIndex = 3;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_deletesubject
            // 
            this.button_deletesubject.Enabled = false;
            this.button_deletesubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_deletesubject.Location = new System.Drawing.Point(225, 30);
            this.button_deletesubject.Name = "button_deletesubject";
            this.button_deletesubject.Size = new System.Drawing.Size(88, 48);
            this.button_deletesubject.TabIndex = 2;
            this.button_deletesubject.Text = "Delete";
            this.button_deletesubject.UseVisualStyleBackColor = true;
            // 
            // button_Savesubjects
            // 
            this.button_Savesubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Savesubjects.Location = new System.Drawing.Point(121, 29);
            this.button_Savesubjects.Name = "button_Savesubjects";
            this.button_Savesubjects.Size = new System.Drawing.Size(88, 48);
            this.button_Savesubjects.TabIndex = 1;
            this.button_Savesubjects.Text = "Save";
            this.button_Savesubjects.UseVisualStyleBackColor = true;
            this.button_Savesubjects.Click += new System.EventHandler(this.button_Savesubjects_Click);
            // 
            // button_newsubjects
            // 
            this.button_newsubjects.BackColor = System.Drawing.Color.White;
            this.button_newsubjects.Enabled = false;
            this.button_newsubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newsubjects.Location = new System.Drawing.Point(6, 30);
            this.button_newsubjects.Name = "button_newsubjects";
            this.button_newsubjects.Size = new System.Drawing.Size(88, 47);
            this.button_newsubjects.TabIndex = 0;
            this.button_newsubjects.Text = "New";
            this.button_newsubjects.UseVisualStyleBackColor = false;
            this.button_newsubjects.Click += new System.EventHandler(this.button_newsubjects_Click);
            // 
            // dataGridView_subjects
            // 
            this.dataGridView_subjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_subjects.Location = new System.Drawing.Point(13, 253);
            this.dataGridView_subjects.Name = "dataGridView_subjects";
            this.dataGridView_subjects.Size = new System.Drawing.Size(467, 144);
            this.dataGridView_subjects.TabIndex = 6;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(492, 402);
            this.Controls.Add(this.dataGridView_subjects);
            this.Controls.Add(this.groupBox_subbutton);
            this.Controls.Add(this.groupBox_subjects);
            this.Name = "Subjects";
            this.Text = "Subjects";
            this.groupBox_subjects.ResumeLayout(false);
            this.groupBox_subjects.PerformLayout();
            this.groupBox_subbutton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_subjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_classsubjects;
        private System.Windows.Forms.TextBox textBox_subjects;
        private System.Windows.Forms.GroupBox groupBox_subjects;
        private System.Windows.Forms.GroupBox groupBox_subbutton;
        private System.Windows.Forms.Button button_deletesubject;
        private System.Windows.Forms.Button button_Savesubjects;
        private System.Windows.Forms.Button button_newsubjects;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.DataGridView dataGridView_subjects;
    }
}