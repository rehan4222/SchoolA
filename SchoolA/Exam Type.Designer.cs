namespace SchoolA
{
    partial class Exam_Type
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
            this.groupBox_sectionname = new System.Windows.Forms.GroupBox();
            this.textBox_addexamtype = new System.Windows.Forms.TextBox();
            this.groupBox_subbutton = new System.Windows.Forms.GroupBox();
            this.button_examtypeUpdate = new System.Windows.Forms.Button();
            this.button_deleteexamtype = new System.Windows.Forms.Button();
            this.button_Savexamtype = new System.Windows.Forms.Button();
            this.button_newexamtype = new System.Windows.Forms.Button();
            this.dataGridView_examtype = new System.Windows.Forms.DataGridView();
            this.groupBox_sectionname.SuspendLayout();
            this.groupBox_subbutton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_examtype)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_sectionname
            // 
            this.groupBox_sectionname.Controls.Add(this.textBox_addexamtype);
            this.groupBox_sectionname.Location = new System.Drawing.Point(4, 12);
            this.groupBox_sectionname.Name = "groupBox_sectionname";
            this.groupBox_sectionname.Size = new System.Drawing.Size(444, 101);
            this.groupBox_sectionname.TabIndex = 1;
            this.groupBox_sectionname.TabStop = false;
            this.groupBox_sectionname.Text = "Section Name";
            // 
            // textBox_addexamtype
            // 
            this.textBox_addexamtype.Location = new System.Drawing.Point(106, 58);
            this.textBox_addexamtype.Name = "textBox_addexamtype";
            this.textBox_addexamtype.Size = new System.Drawing.Size(227, 20);
            this.textBox_addexamtype.TabIndex = 0;
            // 
            // groupBox_subbutton
            // 
            this.groupBox_subbutton.Controls.Add(this.button_examtypeUpdate);
            this.groupBox_subbutton.Controls.Add(this.button_deleteexamtype);
            this.groupBox_subbutton.Controls.Add(this.button_Savexamtype);
            this.groupBox_subbutton.Controls.Add(this.button_newexamtype);
            this.groupBox_subbutton.Location = new System.Drawing.Point(4, 119);
            this.groupBox_subbutton.Name = "groupBox_subbutton";
            this.groupBox_subbutton.Size = new System.Drawing.Size(444, 100);
            this.groupBox_subbutton.TabIndex = 7;
            this.groupBox_subbutton.TabStop = false;
            // 
            // button_examtypeUpdate
            // 
            this.button_examtypeUpdate.Enabled = false;
            this.button_examtypeUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_examtypeUpdate.Location = new System.Drawing.Point(333, 29);
            this.button_examtypeUpdate.Name = "button_examtypeUpdate";
            this.button_examtypeUpdate.Size = new System.Drawing.Size(89, 48);
            this.button_examtypeUpdate.TabIndex = 3;
            this.button_examtypeUpdate.Text = "Update";
            this.button_examtypeUpdate.UseVisualStyleBackColor = true;
            // 
            // button_deleteexamtype
            // 
            this.button_deleteexamtype.Enabled = false;
            this.button_deleteexamtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_deleteexamtype.Location = new System.Drawing.Point(225, 30);
            this.button_deleteexamtype.Name = "button_deleteexamtype";
            this.button_deleteexamtype.Size = new System.Drawing.Size(88, 48);
            this.button_deleteexamtype.TabIndex = 2;
            this.button_deleteexamtype.Text = "Delete";
            this.button_deleteexamtype.UseVisualStyleBackColor = true;
            // 
            // button_Savexamtype
            // 
            this.button_Savexamtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Savexamtype.Location = new System.Drawing.Point(121, 29);
            this.button_Savexamtype.Name = "button_Savexamtype";
            this.button_Savexamtype.Size = new System.Drawing.Size(88, 48);
            this.button_Savexamtype.TabIndex = 1;
            this.button_Savexamtype.Text = "Save";
            this.button_Savexamtype.UseVisualStyleBackColor = true;
            this.button_Savexamtype.Click += new System.EventHandler(this.button_Savexamtype_Click);
            // 
            // button_newexamtype
            // 
            this.button_newexamtype.BackColor = System.Drawing.Color.White;
            this.button_newexamtype.Enabled = false;
            this.button_newexamtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newexamtype.Location = new System.Drawing.Point(6, 30);
            this.button_newexamtype.Name = "button_newexamtype";
            this.button_newexamtype.Size = new System.Drawing.Size(88, 47);
            this.button_newexamtype.TabIndex = 0;
            this.button_newexamtype.Text = "New";
            this.button_newexamtype.UseVisualStyleBackColor = false;
            // 
            // dataGridView_examtype
            // 
            this.dataGridView_examtype.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_examtype.Location = new System.Drawing.Point(4, 225);
            this.dataGridView_examtype.Name = "dataGridView_examtype";
            this.dataGridView_examtype.Size = new System.Drawing.Size(445, 118);
            this.dataGridView_examtype.TabIndex = 8;
            // 
            // Exam_Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(453, 347);
            this.Controls.Add(this.dataGridView_examtype);
            this.Controls.Add(this.groupBox_subbutton);
            this.Controls.Add(this.groupBox_sectionname);
            this.Name = "Exam_Type";
            this.Text = "Exam_Type";
            this.groupBox_sectionname.ResumeLayout(false);
            this.groupBox_sectionname.PerformLayout();
            this.groupBox_subbutton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_examtype)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_sectionname;
        private System.Windows.Forms.TextBox textBox_addexamtype;
        private System.Windows.Forms.GroupBox groupBox_subbutton;
        private System.Windows.Forms.Button button_examtypeUpdate;
        private System.Windows.Forms.Button button_deleteexamtype;
        private System.Windows.Forms.Button button_Savexamtype;
        private System.Windows.Forms.Button button_newexamtype;
        private System.Windows.Forms.DataGridView dataGridView_examtype;
    }
}