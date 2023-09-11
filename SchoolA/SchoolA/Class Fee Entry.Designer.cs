namespace SchoolA
{
    partial class Class_Fee_Entry
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
            this.textBox_term = new System.Windows.Forms.TextBox();
            this.textBox_feeamount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox_classfeesinfo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_subbutton = new System.Windows.Forms.GroupBox();
            this.button_Updateclassfeeentry = new System.Windows.Forms.Button();
            this.button_deleteclassfeeentry = new System.Windows.Forms.Button();
            this.button_Saveclassfeeentry = new System.Windows.Forms.Button();
            this.button_newclassfeeentry = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView_classfeeentry = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox_subbutton.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_classfeeentry)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_term);
            this.groupBox1.Controls.Add(this.textBox_feeamount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.comboBox_classfeesinfo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class Fees Info";
            // 
            // textBox_term
            // 
            this.textBox_term.Location = new System.Drawing.Point(67, 86);
            this.textBox_term.Name = "textBox_term";
            this.textBox_term.Size = new System.Drawing.Size(159, 20);
            this.textBox_term.TabIndex = 8;
            // 
            // textBox_feeamount
            // 
            this.textBox_feeamount.Location = new System.Drawing.Point(67, 117);
            this.textBox_feeamount.Name = "textBox_feeamount";
            this.textBox_feeamount.Size = new System.Drawing.Size(159, 20);
            this.textBox_feeamount.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Term";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fee Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(67, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick);
            // 
            // comboBox_classfeesinfo
            // 
            this.comboBox_classfeesinfo.FormattingEnabled = true;
            this.comboBox_classfeesinfo.Location = new System.Drawing.Point(67, 31);
            this.comboBox_classfeesinfo.Name = "comboBox_classfeesinfo";
            this.comboBox_classfeesinfo.Size = new System.Drawing.Size(159, 21);
            this.comboBox_classfeesinfo.TabIndex = 1;
            this.comboBox_classfeesinfo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_classfeesinfo_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class";
            // 
            // groupBox_subbutton
            // 
            this.groupBox_subbutton.Controls.Add(this.button_Updateclassfeeentry);
            this.groupBox_subbutton.Controls.Add(this.button_deleteclassfeeentry);
            this.groupBox_subbutton.Controls.Add(this.button_Saveclassfeeentry);
            this.groupBox_subbutton.Controls.Add(this.button_newclassfeeentry);
            this.groupBox_subbutton.Location = new System.Drawing.Point(3, 250);
            this.groupBox_subbutton.Name = "groupBox_subbutton";
            this.groupBox_subbutton.Size = new System.Drawing.Size(243, 100);
            this.groupBox_subbutton.TabIndex = 6;
            this.groupBox_subbutton.TabStop = false;
            // 
            // button_Updateclassfeeentry
            // 
            this.button_Updateclassfeeentry.Enabled = false;
            this.button_Updateclassfeeentry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Updateclassfeeentry.Location = new System.Drawing.Point(184, 30);
            this.button_Updateclassfeeentry.Name = "button_Updateclassfeeentry";
            this.button_Updateclassfeeentry.Size = new System.Drawing.Size(53, 46);
            this.button_Updateclassfeeentry.TabIndex = 3;
            this.button_Updateclassfeeentry.Text = "Update";
            this.button_Updateclassfeeentry.UseVisualStyleBackColor = true;
            // 
            // button_deleteclassfeeentry
            // 
            this.button_deleteclassfeeentry.Enabled = false;
            this.button_deleteclassfeeentry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_deleteclassfeeentry.Location = new System.Drawing.Point(121, 30);
            this.button_deleteclassfeeentry.Name = "button_deleteclassfeeentry";
            this.button_deleteclassfeeentry.Size = new System.Drawing.Size(59, 46);
            this.button_deleteclassfeeentry.TabIndex = 2;
            this.button_deleteclassfeeentry.Text = "Delete";
            this.button_deleteclassfeeentry.UseVisualStyleBackColor = true;
            // 
            // button_Saveclassfeeentry
            // 
            this.button_Saveclassfeeentry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Saveclassfeeentry.Location = new System.Drawing.Point(67, 30);
            this.button_Saveclassfeeentry.Name = "button_Saveclassfeeentry";
            this.button_Saveclassfeeentry.Size = new System.Drawing.Size(48, 46);
            this.button_Saveclassfeeentry.TabIndex = 1;
            this.button_Saveclassfeeentry.Text = "Save";
            this.button_Saveclassfeeentry.UseVisualStyleBackColor = true;
            this.button_Saveclassfeeentry.Click += new System.EventHandler(this.button_Saveclassfeeentry_Click);
            // 
            // button_newclassfeeentry
            // 
            this.button_newclassfeeentry.BackColor = System.Drawing.Color.White;
            this.button_newclassfeeentry.Enabled = false;
            this.button_newclassfeeentry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newclassfeeentry.Location = new System.Drawing.Point(6, 29);
            this.button_newclassfeeentry.Name = "button_newclassfeeentry";
            this.button_newclassfeeentry.Size = new System.Drawing.Size(55, 47);
            this.button_newclassfeeentry.TabIndex = 0;
            this.button_newclassfeeentry.Text = "New";
            this.button_newclassfeeentry.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(247, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 61);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search by Class";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(64, 28);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(159, 21);
            this.comboBox3.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Class";
            // 
            // dataGridView_classfeeentry
            // 
            this.dataGridView_classfeeentry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_classfeeentry.Location = new System.Drawing.Point(247, 81);
            this.dataGridView_classfeeentry.Name = "dataGridView_classfeeentry";
            this.dataGridView_classfeeentry.Size = new System.Drawing.Size(502, 269);
            this.dataGridView_classfeeentry.TabIndex = 9;
            // 
            // Class_Fee_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(756, 358);
            this.Controls.Add(this.dataGridView_classfeeentry);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_subbutton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Class_Fee_Entry";
            this.Text = "Class_Fee_Entry";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_subbutton.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_classfeeentry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_feeamount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox_classfeesinfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_subbutton;
        private System.Windows.Forms.Button button_Updateclassfeeentry;
        private System.Windows.Forms.Button button_deleteclassfeeentry;
        private System.Windows.Forms.Button button_Saveclassfeeentry;
        private System.Windows.Forms.Button button_newclassfeeentry;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_term;
        private System.Windows.Forms.DataGridView dataGridView_classfeeentry;
    }
}