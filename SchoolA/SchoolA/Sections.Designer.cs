namespace SchoolA
{
    partial class Sections
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
            this.textBox_sectionadd = new System.Windows.Forms.TextBox();
            this.groupBox_subbutton = new System.Windows.Forms.GroupBox();
            this.button_SectionUpdate = new System.Windows.Forms.Button();
            this.button_deleteSection = new System.Windows.Forms.Button();
            this.button_SaveSection = new System.Windows.Forms.Button();
            this.button_newsections = new System.Windows.Forms.Button();
            this.dataGridView_sectionshow = new System.Windows.Forms.DataGridView();
            this.groupBox_sectionname.SuspendLayout();
            this.groupBox_subbutton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sectionshow)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_sectionname
            // 
            this.groupBox_sectionname.Controls.Add(this.textBox_sectionadd);
            this.groupBox_sectionname.Location = new System.Drawing.Point(12, 12);
            this.groupBox_sectionname.Name = "groupBox_sectionname";
            this.groupBox_sectionname.Size = new System.Drawing.Size(444, 101);
            this.groupBox_sectionname.TabIndex = 0;
            this.groupBox_sectionname.TabStop = false;
            this.groupBox_sectionname.Text = "Section Name";
            // 
            // textBox_sectionadd
            // 
            this.textBox_sectionadd.Location = new System.Drawing.Point(106, 58);
            this.textBox_sectionadd.Name = "textBox_sectionadd";
            this.textBox_sectionadd.Size = new System.Drawing.Size(227, 20);
            this.textBox_sectionadd.TabIndex = 0;
            // 
            // groupBox_subbutton
            // 
            this.groupBox_subbutton.Controls.Add(this.button_SectionUpdate);
            this.groupBox_subbutton.Controls.Add(this.button_deleteSection);
            this.groupBox_subbutton.Controls.Add(this.button_SaveSection);
            this.groupBox_subbutton.Controls.Add(this.button_newsections);
            this.groupBox_subbutton.Location = new System.Drawing.Point(12, 119);
            this.groupBox_subbutton.Name = "groupBox_subbutton";
            this.groupBox_subbutton.Size = new System.Drawing.Size(444, 100);
            this.groupBox_subbutton.TabIndex = 6;
            this.groupBox_subbutton.TabStop = false;
            // 
            // button_SectionUpdate
            // 
            this.button_SectionUpdate.Enabled = false;
            this.button_SectionUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SectionUpdate.Location = new System.Drawing.Point(333, 29);
            this.button_SectionUpdate.Name = "button_SectionUpdate";
            this.button_SectionUpdate.Size = new System.Drawing.Size(89, 48);
            this.button_SectionUpdate.TabIndex = 3;
            this.button_SectionUpdate.Text = "Update";
            this.button_SectionUpdate.UseVisualStyleBackColor = true;
            // 
            // button_deleteSection
            // 
            this.button_deleteSection.Enabled = false;
            this.button_deleteSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_deleteSection.Location = new System.Drawing.Point(225, 30);
            this.button_deleteSection.Name = "button_deleteSection";
            this.button_deleteSection.Size = new System.Drawing.Size(88, 48);
            this.button_deleteSection.TabIndex = 2;
            this.button_deleteSection.Text = "Delete";
            this.button_deleteSection.UseVisualStyleBackColor = true;
            this.button_deleteSection.Click += new System.EventHandler(this.button_deleteSection_Click);
            // 
            // button_SaveSection
            // 
            this.button_SaveSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SaveSection.Location = new System.Drawing.Point(121, 29);
            this.button_SaveSection.Name = "button_SaveSection";
            this.button_SaveSection.Size = new System.Drawing.Size(88, 48);
            this.button_SaveSection.TabIndex = 1;
            this.button_SaveSection.Text = "Save";
            this.button_SaveSection.UseVisualStyleBackColor = true;
            this.button_SaveSection.Click += new System.EventHandler(this.button_SaveSection_Click);
            // 
            // button_newsections
            // 
            this.button_newsections.BackColor = System.Drawing.Color.White;
            this.button_newsections.Enabled = false;
            this.button_newsections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newsections.Location = new System.Drawing.Point(6, 30);
            this.button_newsections.Name = "button_newsections";
            this.button_newsections.Size = new System.Drawing.Size(88, 47);
            this.button_newsections.TabIndex = 0;
            this.button_newsections.Text = "New";
            this.button_newsections.UseVisualStyleBackColor = false;
            this.button_newsections.Click += new System.EventHandler(this.button_newsections_Click);
            // 
            // dataGridView_sectionshow
            // 
            this.dataGridView_sectionshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_sectionshow.Location = new System.Drawing.Point(12, 240);
            this.dataGridView_sectionshow.Name = "dataGridView_sectionshow";
            this.dataGridView_sectionshow.Size = new System.Drawing.Size(444, 150);
            this.dataGridView_sectionshow.TabIndex = 7;
            // 
            // Sections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(468, 402);
            this.Controls.Add(this.dataGridView_sectionshow);
            this.Controls.Add(this.groupBox_subbutton);
            this.Controls.Add(this.groupBox_sectionname);
            this.Name = "Sections";
            this.Text = "Sections";
            this.groupBox_sectionname.ResumeLayout(false);
            this.groupBox_sectionname.PerformLayout();
            this.groupBox_subbutton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sectionshow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_sectionname;
        private System.Windows.Forms.TextBox textBox_sectionadd;
        private System.Windows.Forms.GroupBox groupBox_subbutton;
        private System.Windows.Forms.Button button_SectionUpdate;
        private System.Windows.Forms.Button button_deleteSection;
        private System.Windows.Forms.Button button_SaveSection;
        private System.Windows.Forms.Button button_newsections;
        private System.Windows.Forms.DataGridView dataGridView_sectionshow;
    }
}