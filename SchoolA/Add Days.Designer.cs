namespace SchoolA
{
    partial class Add_Days
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
            this.dataGridView_daysshow = new System.Windows.Forms.DataGridView();
            this.groupBox_subbutton = new System.Windows.Forms.GroupBox();
            this.button_Updatedays = new System.Windows.Forms.Button();
            this.button_deletedays = new System.Windows.Forms.Button();
            this.button_Savedays = new System.Windows.Forms.Button();
            this.button_newdays = new System.Windows.Forms.Button();
            this.groupBox_sectionname = new System.Windows.Forms.GroupBox();
            this.textBox_daysadd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_daysshow)).BeginInit();
            this.groupBox_subbutton.SuspendLayout();
            this.groupBox_sectionname.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_daysshow
            // 
            this.dataGridView_daysshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_daysshow.Location = new System.Drawing.Point(2, 231);
            this.dataGridView_daysshow.Name = "dataGridView_daysshow";
            this.dataGridView_daysshow.Size = new System.Drawing.Size(444, 150);
            this.dataGridView_daysshow.TabIndex = 13;
            // 
            // groupBox_subbutton
            // 
            this.groupBox_subbutton.Controls.Add(this.button_Updatedays);
            this.groupBox_subbutton.Controls.Add(this.button_deletedays);
            this.groupBox_subbutton.Controls.Add(this.button_Savedays);
            this.groupBox_subbutton.Controls.Add(this.button_newdays);
            this.groupBox_subbutton.Location = new System.Drawing.Point(2, 110);
            this.groupBox_subbutton.Name = "groupBox_subbutton";
            this.groupBox_subbutton.Size = new System.Drawing.Size(444, 100);
            this.groupBox_subbutton.TabIndex = 12;
            this.groupBox_subbutton.TabStop = false;
            // 
            // button_Updatedays
            // 
            this.button_Updatedays.Enabled = false;
            this.button_Updatedays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Updatedays.Location = new System.Drawing.Point(333, 29);
            this.button_Updatedays.Name = "button_Updatedays";
            this.button_Updatedays.Size = new System.Drawing.Size(89, 48);
            this.button_Updatedays.TabIndex = 3;
            this.button_Updatedays.Text = "Update";
            this.button_Updatedays.UseVisualStyleBackColor = true;
            // 
            // button_deletedays
            // 
            this.button_deletedays.Enabled = false;
            this.button_deletedays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_deletedays.Location = new System.Drawing.Point(225, 30);
            this.button_deletedays.Name = "button_deletedays";
            this.button_deletedays.Size = new System.Drawing.Size(88, 48);
            this.button_deletedays.TabIndex = 2;
            this.button_deletedays.Text = "Delete";
            this.button_deletedays.UseVisualStyleBackColor = true;
            // 
            // button_Savedays
            // 
            this.button_Savedays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Savedays.Location = new System.Drawing.Point(121, 29);
            this.button_Savedays.Name = "button_Savedays";
            this.button_Savedays.Size = new System.Drawing.Size(88, 48);
            this.button_Savedays.TabIndex = 1;
            this.button_Savedays.Text = "Save";
            this.button_Savedays.UseVisualStyleBackColor = true;
            this.button_Savedays.Click += new System.EventHandler(this.button_Savedays_Click);
            // 
            // button_newdays
            // 
            this.button_newdays.BackColor = System.Drawing.Color.White;
            this.button_newdays.Enabled = false;
            this.button_newdays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newdays.Location = new System.Drawing.Point(6, 30);
            this.button_newdays.Name = "button_newdays";
            this.button_newdays.Size = new System.Drawing.Size(88, 47);
            this.button_newdays.TabIndex = 0;
            this.button_newdays.Text = "New";
            this.button_newdays.UseVisualStyleBackColor = false;
            // 
            // groupBox_sectionname
            // 
            this.groupBox_sectionname.Controls.Add(this.textBox_daysadd);
            this.groupBox_sectionname.Location = new System.Drawing.Point(2, 3);
            this.groupBox_sectionname.Name = "groupBox_sectionname";
            this.groupBox_sectionname.Size = new System.Drawing.Size(444, 101);
            this.groupBox_sectionname.TabIndex = 11;
            this.groupBox_sectionname.TabStop = false;
            this.groupBox_sectionname.Text = "Add Days";
            // 
            // textBox_daysadd
            // 
            this.textBox_daysadd.Location = new System.Drawing.Point(106, 58);
            this.textBox_daysadd.Name = "textBox_daysadd";
            this.textBox_daysadd.Size = new System.Drawing.Size(227, 20);
            this.textBox_daysadd.TabIndex = 0;
            // 
            // Add_Days
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(449, 385);
            this.Controls.Add(this.dataGridView_daysshow);
            this.Controls.Add(this.groupBox_subbutton);
            this.Controls.Add(this.groupBox_sectionname);
            this.Name = "Add_Days";
            this.Text = "Add_Days";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_daysshow)).EndInit();
            this.groupBox_subbutton.ResumeLayout(false);
            this.groupBox_sectionname.ResumeLayout(false);
            this.groupBox_sectionname.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_daysshow;
        private System.Windows.Forms.GroupBox groupBox_subbutton;
        private System.Windows.Forms.Button button_Updatedays;
        private System.Windows.Forms.Button button_deletedays;
        private System.Windows.Forms.Button button_Savedays;
        private System.Windows.Forms.Button button_newdays;
        private System.Windows.Forms.GroupBox groupBox_sectionname;
        private System.Windows.Forms.TextBox textBox_daysadd;
    }
}