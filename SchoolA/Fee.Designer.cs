namespace SchoolA
{
    partial class Fee
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
            this.textBox_feetype = new System.Windows.Forms.TextBox();
            this.groupBox_subbutton = new System.Windows.Forms.GroupBox();
            this.button_FeeUpdate = new System.Windows.Forms.Button();
            this.button_deleteFeetype = new System.Windows.Forms.Button();
            this.button_SaveFeetype = new System.Windows.Forms.Button();
            this.button_newfeetype = new System.Windows.Forms.Button();
            this.dataGridView_feetype = new System.Windows.Forms.DataGridView();
            this.textBox_addterm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox_subbutton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_feetype)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_addterm);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_feetype);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Fee";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Fee Type";
            // 
            // textBox_feetype
            // 
            this.textBox_feetype.Location = new System.Drawing.Point(142, 38);
            this.textBox_feetype.Name = "textBox_feetype";
            this.textBox_feetype.Size = new System.Drawing.Size(296, 20);
            this.textBox_feetype.TabIndex = 0;
            // 
            // groupBox_subbutton
            // 
            this.groupBox_subbutton.Controls.Add(this.button_FeeUpdate);
            this.groupBox_subbutton.Controls.Add(this.button_deleteFeetype);
            this.groupBox_subbutton.Controls.Add(this.button_SaveFeetype);
            this.groupBox_subbutton.Controls.Add(this.button_newfeetype);
            this.groupBox_subbutton.Location = new System.Drawing.Point(12, 143);
            this.groupBox_subbutton.Name = "groupBox_subbutton";
            this.groupBox_subbutton.Size = new System.Drawing.Size(444, 89);
            this.groupBox_subbutton.TabIndex = 7;
            this.groupBox_subbutton.TabStop = false;
            // 
            // button_FeeUpdate
            // 
            this.button_FeeUpdate.Enabled = false;
            this.button_FeeUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_FeeUpdate.Location = new System.Drawing.Point(333, 29);
            this.button_FeeUpdate.Name = "button_FeeUpdate";
            this.button_FeeUpdate.Size = new System.Drawing.Size(89, 48);
            this.button_FeeUpdate.TabIndex = 3;
            this.button_FeeUpdate.Text = "Update";
            this.button_FeeUpdate.UseVisualStyleBackColor = true;
            // 
            // button_deleteFeetype
            // 
            this.button_deleteFeetype.Enabled = false;
            this.button_deleteFeetype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_deleteFeetype.Location = new System.Drawing.Point(225, 30);
            this.button_deleteFeetype.Name = "button_deleteFeetype";
            this.button_deleteFeetype.Size = new System.Drawing.Size(88, 48);
            this.button_deleteFeetype.TabIndex = 2;
            this.button_deleteFeetype.Text = "Delete";
            this.button_deleteFeetype.UseVisualStyleBackColor = true;
            // 
            // button_SaveFeetype
            // 
            this.button_SaveFeetype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SaveFeetype.Location = new System.Drawing.Point(121, 30);
            this.button_SaveFeetype.Name = "button_SaveFeetype";
            this.button_SaveFeetype.Size = new System.Drawing.Size(88, 48);
            this.button_SaveFeetype.TabIndex = 1;
            this.button_SaveFeetype.Text = "Save";
            this.button_SaveFeetype.UseVisualStyleBackColor = true;
            this.button_SaveFeetype.Click += new System.EventHandler(this.button_SaveFeetype_Click);
            // 
            // button_newfeetype
            // 
            this.button_newfeetype.BackColor = System.Drawing.Color.White;
            this.button_newfeetype.Enabled = false;
            this.button_newfeetype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newfeetype.Location = new System.Drawing.Point(6, 30);
            this.button_newfeetype.Name = "button_newfeetype";
            this.button_newfeetype.Size = new System.Drawing.Size(88, 47);
            this.button_newfeetype.TabIndex = 0;
            this.button_newfeetype.Text = "New";
            this.button_newfeetype.UseVisualStyleBackColor = false;
            // 
            // dataGridView_feetype
            // 
            this.dataGridView_feetype.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_feetype.Location = new System.Drawing.Point(12, 238);
            this.dataGridView_feetype.Name = "dataGridView_feetype";
            this.dataGridView_feetype.Size = new System.Drawing.Size(444, 133);
            this.dataGridView_feetype.TabIndex = 8;
            // 
            // textBox_addterm
            // 
            this.textBox_addterm.Location = new System.Drawing.Point(142, 65);
            this.textBox_addterm.Name = "textBox_addterm";
            this.textBox_addterm.Size = new System.Drawing.Size(296, 20);
            this.textBox_addterm.TabIndex = 4;
            this.textBox_addterm.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Add Term";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Term should be add in format";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "April2017-March2018";
            // 
            // Fee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(472, 376);
            this.Controls.Add(this.dataGridView_feetype);
            this.Controls.Add(this.groupBox_subbutton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Fee";
            this.Text = "Fee";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_subbutton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_feetype)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_feetype;
        private System.Windows.Forms.GroupBox groupBox_subbutton;
        private System.Windows.Forms.Button button_FeeUpdate;
        private System.Windows.Forms.Button button_deleteFeetype;
        private System.Windows.Forms.Button button_SaveFeetype;
        private System.Windows.Forms.Button button_newfeetype;
        private System.Windows.Forms.DataGridView dataGridView_feetype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_addterm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}