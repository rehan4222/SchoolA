namespace SchoolA
{
    partial class FeeChallan
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
            this.comboBox_byclassfeechallan = new System.Windows.Forms.ComboBox();
            this.textBox_rollnumber = new System.Windows.Forms.TextBox();
            this.radioButton_bystudent = new System.Windows.Forms.RadioButton();
            this.radioButton_byclass = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Datesfeechallan = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_duedate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_IssueDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_feechallandetails = new System.Windows.Forms.DataGridView();
            this.dataGridView_studentdetails = new System.Windows.Forms.DataGridView();
            this.button_getchallan = new System.Windows.Forms.Button();
            this.button_printchallan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox_Datesfeechallan.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_feechallandetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_studentdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_byclassfeechallan);
            this.groupBox1.Controls.Add(this.textBox_rollnumber);
            this.groupBox1.Controls.Add(this.radioButton_bystudent);
            this.groupBox1.Controls.Add(this.radioButton_byclass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Type";
            // 
            // comboBox_byclassfeechallan
            // 
            this.comboBox_byclassfeechallan.FormattingEnabled = true;
            this.comboBox_byclassfeechallan.Location = new System.Drawing.Point(104, 20);
            this.comboBox_byclassfeechallan.Name = "comboBox_byclassfeechallan";
            this.comboBox_byclassfeechallan.Size = new System.Drawing.Size(318, 21);
            this.comboBox_byclassfeechallan.TabIndex = 5;
            this.comboBox_byclassfeechallan.SelectedIndexChanged += new System.EventHandler(this.comboBox_byclassfeechallan_SelectedIndexChanged);
            this.comboBox_byclassfeechallan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_byclassfeechallan_MouseClick);
            // 
            // textBox_rollnumber
            // 
            this.textBox_rollnumber.Location = new System.Drawing.Point(104, 52);
            this.textBox_rollnumber.Name = "textBox_rollnumber";
            this.textBox_rollnumber.Size = new System.Drawing.Size(318, 20);
            this.textBox_rollnumber.TabIndex = 4;
            // 
            // radioButton_bystudent
            // 
            this.radioButton_bystudent.AutoSize = true;
            this.radioButton_bystudent.Location = new System.Drawing.Point(7, 56);
            this.radioButton_bystudent.Name = "radioButton_bystudent";
            this.radioButton_bystudent.Size = new System.Drawing.Size(98, 17);
            this.radioButton_bystudent.TabIndex = 2;
            this.radioButton_bystudent.TabStop = true;
            this.radioButton_bystudent.Text = "By Roll Number";
            this.radioButton_bystudent.UseVisualStyleBackColor = true;
            // 
            // radioButton_byclass
            // 
            this.radioButton_byclass.AutoSize = true;
            this.radioButton_byclass.Location = new System.Drawing.Point(7, 20);
            this.radioButton_byclass.Name = "radioButton_byclass";
            this.radioButton_byclass.Size = new System.Drawing.Size(65, 17);
            this.radioButton_byclass.TabIndex = 1;
            this.radioButton_byclass.TabStop = true;
            this.radioButton_byclass.Text = "By Class";
            this.radioButton_byclass.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // groupBox_Datesfeechallan
            // 
            this.groupBox_Datesfeechallan.Controls.Add(this.button_printchallan);
            this.groupBox_Datesfeechallan.Controls.Add(this.button_getchallan);
            this.groupBox_Datesfeechallan.Controls.Add(this.dateTimePicker_duedate);
            this.groupBox_Datesfeechallan.Controls.Add(this.label3);
            this.groupBox_Datesfeechallan.Controls.Add(this.label2);
            this.groupBox_Datesfeechallan.Controls.Add(this.dateTimePicker_IssueDate);
            this.groupBox_Datesfeechallan.Location = new System.Drawing.Point(590, 28);
            this.groupBox_Datesfeechallan.Name = "groupBox_Datesfeechallan";
            this.groupBox_Datesfeechallan.Size = new System.Drawing.Size(635, 94);
            this.groupBox_Datesfeechallan.TabIndex = 1;
            this.groupBox_Datesfeechallan.TabStop = false;
            this.groupBox_Datesfeechallan.Text = "Dates";
            // 
            // dateTimePicker_duedate
            // 
            this.dateTimePicker_duedate.Location = new System.Drawing.Point(91, 52);
            this.dateTimePicker_duedate.Name = "dateTimePicker_duedate";
            this.dateTimePicker_duedate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_duedate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Due Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Issue Date";
            // 
            // dateTimePicker_IssueDate
            // 
            this.dateTimePicker_IssueDate.Location = new System.Drawing.Point(91, 20);
            this.dateTimePicker_IssueDate.Name = "dateTimePicker_IssueDate";
            this.dateTimePicker_IssueDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_IssueDate.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_feechallandetails);
            this.groupBox2.Controls.Add(this.dataGridView_studentdetails);
            this.groupBox2.Controls.Add(this.groupBox_Datesfeechallan);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1232, 465);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fee Challan";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dataGridView_feechallandetails
            // 
            this.dataGridView_feechallandetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_feechallandetails.Location = new System.Drawing.Point(590, 128);
            this.dataGridView_feechallandetails.Name = "dataGridView_feechallandetails";
            this.dataGridView_feechallandetails.Size = new System.Drawing.Size(635, 330);
            this.dataGridView_feechallandetails.TabIndex = 3;
            // 
            // dataGridView_studentdetails
            // 
            this.dataGridView_studentdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_studentdetails.Location = new System.Drawing.Point(6, 129);
            this.dataGridView_studentdetails.Name = "dataGridView_studentdetails";
            this.dataGridView_studentdetails.Size = new System.Drawing.Size(557, 330);
            this.dataGridView_studentdetails.TabIndex = 2;
            // 
            // button_getchallan
            // 
            this.button_getchallan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_getchallan.Location = new System.Drawing.Point(344, 34);
            this.button_getchallan.Name = "button_getchallan";
            this.button_getchallan.Size = new System.Drawing.Size(70, 48);
            this.button_getchallan.TabIndex = 4;
            this.button_getchallan.Text = "Get Challan";
            this.button_getchallan.UseVisualStyleBackColor = true;
            this.button_getchallan.Click += new System.EventHandler(this.button_getchallan_Click);
            // 
            // button_printchallan
            // 
            this.button_printchallan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_printchallan.Location = new System.Drawing.Point(420, 34);
            this.button_printchallan.Name = "button_printchallan";
            this.button_printchallan.Size = new System.Drawing.Size(75, 48);
            this.button_printchallan.TabIndex = 5;
            this.button_printchallan.Text = "Print Challan";
            this.button_printchallan.UseVisualStyleBackColor = true;
            // 
            // FeeChallan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1249, 489);
            this.Controls.Add(this.groupBox2);
            this.Name = "FeeChallan";
            this.Text = "FeeChallan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Datesfeechallan.ResumeLayout(false);
            this.groupBox_Datesfeechallan.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_feechallandetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_studentdetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_byclassfeechallan;
        private System.Windows.Forms.TextBox textBox_rollnumber;
        private System.Windows.Forms.RadioButton radioButton_bystudent;
        private System.Windows.Forms.RadioButton radioButton_byclass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_Datesfeechallan;
        private System.Windows.Forms.DateTimePicker dateTimePicker_duedate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_IssueDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_feechallandetails;
        private System.Windows.Forms.DataGridView dataGridView_studentdetails;
        private System.Windows.Forms.Button button_printchallan;
        private System.Windows.Forms.Button button_getchallan;
    }
}