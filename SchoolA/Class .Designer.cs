namespace SchoolA
{
    partial class Class
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
            this.groupBox_seesections = new System.Windows.Forms.GroupBox();
            this.dataGridView_mapsectiontoclass = new System.Windows.Forms.DataGridView();
            this.groupBox_Section = new System.Windows.Forms.GroupBox();
            this.groupBox_sectioninfo = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox_sectionmap = new System.Windows.Forms.ComboBox();
            this.comboBox_classmap = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox_newclass = new System.Windows.Forms.GroupBox();
            this.groupBox_classinfo = new System.Windows.Forms.GroupBox();
            this.button2_save = new System.Windows.Forms.Button();
            this.button1_new = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox_seeclass = new System.Windows.Forms.GroupBox();
            this.dataGridView_classinfo = new System.Windows.Forms.DataGridView();
            this.groupBox_seesections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mapsectiontoclass)).BeginInit();
            this.groupBox_Section.SuspendLayout();
            this.groupBox_sectioninfo.SuspendLayout();
            this.groupBox_newclass.SuspendLayout();
            this.groupBox_classinfo.SuspendLayout();
            this.groupBox_seeclass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_classinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_seesections
            // 
            this.groupBox_seesections.Controls.Add(this.dataGridView_mapsectiontoclass);
            this.groupBox_seesections.Location = new System.Drawing.Point(270, 208);
            this.groupBox_seesections.Name = "groupBox_seesections";
            this.groupBox_seesections.Size = new System.Drawing.Size(245, 172);
            this.groupBox_seesections.TabIndex = 7;
            this.groupBox_seesections.TabStop = false;
            // 
            // dataGridView_mapsectiontoclass
            // 
            this.dataGridView_mapsectiontoclass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_mapsectiontoclass.Location = new System.Drawing.Point(6, 16);
            this.dataGridView_mapsectiontoclass.Name = "dataGridView_mapsectiontoclass";
            this.dataGridView_mapsectiontoclass.Size = new System.Drawing.Size(233, 150);
            this.dataGridView_mapsectiontoclass.TabIndex = 0;
            // 
            // groupBox_Section
            // 
            this.groupBox_Section.Controls.Add(this.groupBox_sectioninfo);
            this.groupBox_Section.Location = new System.Drawing.Point(263, 12);
            this.groupBox_Section.Name = "groupBox_Section";
            this.groupBox_Section.Size = new System.Drawing.Size(261, 189);
            this.groupBox_Section.TabIndex = 5;
            this.groupBox_Section.TabStop = false;
            this.groupBox_Section.Text = "Map Section to Class";
            // 
            // groupBox_sectioninfo
            // 
            this.groupBox_sectioninfo.Controls.Add(this.button1);
            this.groupBox_sectioninfo.Controls.Add(this.button2);
            this.groupBox_sectioninfo.Controls.Add(this.comboBox_sectionmap);
            this.groupBox_sectioninfo.Controls.Add(this.comboBox_classmap);
            this.groupBox_sectioninfo.Controls.Add(this.label23);
            this.groupBox_sectioninfo.Controls.Add(this.label22);
            this.groupBox_sectioninfo.Location = new System.Drawing.Point(7, 19);
            this.groupBox_sectioninfo.Name = "groupBox_sectioninfo";
            this.groupBox_sectioninfo.Size = new System.Drawing.Size(239, 154);
            this.groupBox_sectioninfo.TabIndex = 0;
            this.groupBox_sectioninfo.TabStop = false;
            this.groupBox_sectioninfo.Text = "Section Info";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(144, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(58, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "New";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // comboBox_sectionmap
            // 
            this.comboBox_sectionmap.FormattingEnabled = true;
            this.comboBox_sectionmap.Location = new System.Drawing.Point(58, 61);
            this.comboBox_sectionmap.Name = "comboBox_sectionmap";
            this.comboBox_sectionmap.Size = new System.Drawing.Size(161, 21);
            this.comboBox_sectionmap.TabIndex = 3;
            this.comboBox_sectionmap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_sectionmap_MouseClick);
            // 
            // comboBox_classmap
            // 
            this.comboBox_classmap.FormattingEnabled = true;
            this.comboBox_classmap.Location = new System.Drawing.Point(58, 27);
            this.comboBox_classmap.Name = "comboBox_classmap";
            this.comboBox_classmap.Size = new System.Drawing.Size(161, 21);
            this.comboBox_classmap.TabIndex = 2;
            this.comboBox_classmap.SelectedIndexChanged += new System.EventHandler(this.comboBox_classmap_SelectedIndexChanged);
            this.comboBox_classmap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_classmap_MouseClick);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 69);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(43, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "Section";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 35);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(32, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "Class";
            // 
            // groupBox_newclass
            // 
            this.groupBox_newclass.Controls.Add(this.groupBox_classinfo);
            this.groupBox_newclass.Location = new System.Drawing.Point(12, 12);
            this.groupBox_newclass.Name = "groupBox_newclass";
            this.groupBox_newclass.Size = new System.Drawing.Size(261, 189);
            this.groupBox_newclass.TabIndex = 4;
            this.groupBox_newclass.TabStop = false;
            this.groupBox_newclass.Text = "New Class";
            // 
            // groupBox_classinfo
            // 
            this.groupBox_classinfo.Controls.Add(this.button2_save);
            this.groupBox_classinfo.Controls.Add(this.button1_new);
            this.groupBox_classinfo.Controls.Add(this.textBox1);
            this.groupBox_classinfo.Controls.Add(this.label21);
            this.groupBox_classinfo.Location = new System.Drawing.Point(6, 19);
            this.groupBox_classinfo.Name = "groupBox_classinfo";
            this.groupBox_classinfo.Size = new System.Drawing.Size(239, 154);
            this.groupBox_classinfo.TabIndex = 0;
            this.groupBox_classinfo.TabStop = false;
            this.groupBox_classinfo.Text = "Class Info";
            // 
            // button2_save
            // 
            this.button2_save.BackColor = System.Drawing.Color.White;
            this.button2_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_save.Location = new System.Drawing.Point(136, 88);
            this.button2_save.Name = "button2_save";
            this.button2_save.Size = new System.Drawing.Size(75, 46);
            this.button2_save.TabIndex = 3;
            this.button2_save.Text = "Save";
            this.button2_save.UseVisualStyleBackColor = false;
            this.button2_save.Click += new System.EventHandler(this.button2_save_Click);
            // 
            // button1_new
            // 
            this.button1_new.BackColor = System.Drawing.Color.White;
            this.button1_new.Enabled = false;
            this.button1_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_new.Location = new System.Drawing.Point(55, 88);
            this.button1_new.Name = "button1_new";
            this.button1_new.Size = new System.Drawing.Size(75, 45);
            this.button1_new.TabIndex = 2;
            this.button1_new.Text = "New";
            this.button1_new.UseVisualStyleBackColor = false;
            this.button1_new.Click += new System.EventHandler(this.button1_new_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(32, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Class";
            // 
            // groupBox_seeclass
            // 
            this.groupBox_seeclass.Controls.Add(this.dataGridView_classinfo);
            this.groupBox_seeclass.Location = new System.Drawing.Point(12, 208);
            this.groupBox_seeclass.Name = "groupBox_seeclass";
            this.groupBox_seeclass.Size = new System.Drawing.Size(245, 172);
            this.groupBox_seeclass.TabIndex = 6;
            this.groupBox_seeclass.TabStop = false;
            // 
            // dataGridView_classinfo
            // 
            this.dataGridView_classinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_classinfo.Location = new System.Drawing.Point(6, 16);
            this.dataGridView_classinfo.Name = "dataGridView_classinfo";
            this.dataGridView_classinfo.Size = new System.Drawing.Size(233, 150);
            this.dataGridView_classinfo.TabIndex = 0;
            // 
            // Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(530, 392);
            this.Controls.Add(this.groupBox_seesections);
            this.Controls.Add(this.groupBox_seeclass);
            this.Controls.Add(this.groupBox_Section);
            this.Controls.Add(this.groupBox_newclass);
            this.Name = "Class";
            this.Text = "Class";
            this.groupBox_seesections.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mapsectiontoclass)).EndInit();
            this.groupBox_Section.ResumeLayout(false);
            this.groupBox_sectioninfo.ResumeLayout(false);
            this.groupBox_sectioninfo.PerformLayout();
            this.groupBox_newclass.ResumeLayout(false);
            this.groupBox_classinfo.ResumeLayout(false);
            this.groupBox_classinfo.PerformLayout();
            this.groupBox_seeclass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_classinfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_seesections;
        private System.Windows.Forms.GroupBox groupBox_Section;
        private System.Windows.Forms.GroupBox groupBox_sectioninfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox_sectionmap;
        private System.Windows.Forms.ComboBox comboBox_classmap;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox_newclass;
        private System.Windows.Forms.GroupBox groupBox_classinfo;
        private System.Windows.Forms.Button button2_save;
        private System.Windows.Forms.Button button1_new;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dataGridView_mapsectiontoclass;
        private System.Windows.Forms.GroupBox groupBox_seeclass;
        private System.Windows.Forms.DataGridView dataGridView_classinfo;
    }
}