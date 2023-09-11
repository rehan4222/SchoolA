namespace SchoolA
{
    partial class Time
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
            this.dataGridView_timingshow = new System.Windows.Forms.DataGridView();
            this.groupBox_subbutton = new System.Windows.Forms.GroupBox();
            this.button_Updatetiming = new System.Windows.Forms.Button();
            this.button_deletetiming = new System.Windows.Forms.Button();
            this.button_Savetiming = new System.Windows.Forms.Button();
            this.button_newtiming = new System.Windows.Forms.Button();
            this.groupBox_sectionname = new System.Windows.Forms.GroupBox();
            this.textBox_timingadd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_timingshow)).BeginInit();
            this.groupBox_subbutton.SuspendLayout();
            this.groupBox_sectionname.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_timingshow
            // 
            this.dataGridView_timingshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_timingshow.Location = new System.Drawing.Point(1, 232);
            this.dataGridView_timingshow.Name = "dataGridView_timingshow";
            this.dataGridView_timingshow.Size = new System.Drawing.Size(444, 150);
            this.dataGridView_timingshow.TabIndex = 10;
            // 
            // groupBox_subbutton
            // 
            this.groupBox_subbutton.Controls.Add(this.button_Updatetiming);
            this.groupBox_subbutton.Controls.Add(this.button_deletetiming);
            this.groupBox_subbutton.Controls.Add(this.button_Savetiming);
            this.groupBox_subbutton.Controls.Add(this.button_newtiming);
            this.groupBox_subbutton.Location = new System.Drawing.Point(1, 111);
            this.groupBox_subbutton.Name = "groupBox_subbutton";
            this.groupBox_subbutton.Size = new System.Drawing.Size(444, 100);
            this.groupBox_subbutton.TabIndex = 9;
            this.groupBox_subbutton.TabStop = false;
            // 
            // button_Updatetiming
            // 
            this.button_Updatetiming.Enabled = false;
            this.button_Updatetiming.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Updatetiming.Location = new System.Drawing.Point(333, 29);
            this.button_Updatetiming.Name = "button_Updatetiming";
            this.button_Updatetiming.Size = new System.Drawing.Size(89, 48);
            this.button_Updatetiming.TabIndex = 3;
            this.button_Updatetiming.Text = "Update";
            this.button_Updatetiming.UseVisualStyleBackColor = true;
            // 
            // button_deletetiming
            // 
            this.button_deletetiming.Enabled = false;
            this.button_deletetiming.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_deletetiming.Location = new System.Drawing.Point(225, 30);
            this.button_deletetiming.Name = "button_deletetiming";
            this.button_deletetiming.Size = new System.Drawing.Size(88, 48);
            this.button_deletetiming.TabIndex = 2;
            this.button_deletetiming.Text = "Delete";
            this.button_deletetiming.UseVisualStyleBackColor = true;
            // 
            // button_Savetiming
            // 
            this.button_Savetiming.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Savetiming.Location = new System.Drawing.Point(121, 29);
            this.button_Savetiming.Name = "button_Savetiming";
            this.button_Savetiming.Size = new System.Drawing.Size(88, 48);
            this.button_Savetiming.TabIndex = 1;
            this.button_Savetiming.Text = "Save";
            this.button_Savetiming.UseVisualStyleBackColor = true;
            this.button_Savetiming.Click += new System.EventHandler(this.button_Savetiming_Click);
            // 
            // button_newtiming
            // 
            this.button_newtiming.BackColor = System.Drawing.Color.White;
            this.button_newtiming.Enabled = false;
            this.button_newtiming.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newtiming.Location = new System.Drawing.Point(6, 30);
            this.button_newtiming.Name = "button_newtiming";
            this.button_newtiming.Size = new System.Drawing.Size(88, 47);
            this.button_newtiming.TabIndex = 0;
            this.button_newtiming.Text = "New";
            this.button_newtiming.UseVisualStyleBackColor = false;
            // 
            // groupBox_sectionname
            // 
            this.groupBox_sectionname.Controls.Add(this.textBox_timingadd);
            this.groupBox_sectionname.Location = new System.Drawing.Point(1, 4);
            this.groupBox_sectionname.Name = "groupBox_sectionname";
            this.groupBox_sectionname.Size = new System.Drawing.Size(444, 101);
            this.groupBox_sectionname.TabIndex = 8;
            this.groupBox_sectionname.TabStop = false;
            this.groupBox_sectionname.Text = "Add TimeTable Timings";
            // 
            // textBox_timingadd
            // 
            this.textBox_timingadd.Location = new System.Drawing.Point(106, 58);
            this.textBox_timingadd.Name = "textBox_timingadd";
            this.textBox_timingadd.Size = new System.Drawing.Size(227, 20);
            this.textBox_timingadd.TabIndex = 0;
            // 
            // Time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(449, 385);
            this.Controls.Add(this.dataGridView_timingshow);
            this.Controls.Add(this.groupBox_subbutton);
            this.Controls.Add(this.groupBox_sectionname);
            this.Name = "Time";
            this.Text = "Time";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_timingshow)).EndInit();
            this.groupBox_subbutton.ResumeLayout(false);
            this.groupBox_sectionname.ResumeLayout(false);
            this.groupBox_sectionname.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_timingshow;
        private System.Windows.Forms.GroupBox groupBox_subbutton;
        private System.Windows.Forms.Button button_Updatetiming;
        private System.Windows.Forms.Button button_deletetiming;
        private System.Windows.Forms.Button button_Savetiming;
        private System.Windows.Forms.Button button_newtiming;
        private System.Windows.Forms.GroupBox groupBox_sectionname;
        private System.Windows.Forms.TextBox textBox_timingadd;
    }
}