namespace SchoolA
{
    partial class MainScreen
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
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_students = new System.Windows.Forms.TabPage();
            this.textBox_permadd = new System.Windows.Forms.TextBox();
            this.textBox_tempadd = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.menuStrip_students = new System.Windows.Forms.MenuStrip();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage_class = new System.Windows.Forms.TabPage();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_students.SuspendLayout();
            this.menuStrip_students.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_students);
            this.tabControl_Main.Controls.Add(this.tabPage_class);
            this.tabControl_Main.Location = new System.Drawing.Point(2, 1);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(872, 406);
            this.tabControl_Main.TabIndex = 0;
            // 
            // tabPage_students
            // 
            this.tabPage_students.Controls.Add(this.textBox_permadd);
            this.tabPage_students.Controls.Add(this.textBox_tempadd);
            this.tabPage_students.Controls.Add(this.label14);
            this.tabPage_students.Controls.Add(this.label13);
            this.tabPage_students.Controls.Add(this.menuStrip_students);
            this.tabPage_students.Location = new System.Drawing.Point(4, 22);
            this.tabPage_students.Name = "tabPage_students";
            this.tabPage_students.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_students.Size = new System.Drawing.Size(864, 380);
            this.tabPage_students.TabIndex = 0;
            this.tabPage_students.Text = "Students";
            this.tabPage_students.UseVisualStyleBackColor = true;
            this.tabPage_students.Click += new System.EventHandler(this.tabPage_students_Click);
            // 
            // textBox_permadd
            // 
            this.textBox_permadd.Location = new System.Drawing.Point(1062, 95);
            this.textBox_permadd.Name = "textBox_permadd";
            this.textBox_permadd.Size = new System.Drawing.Size(100, 20);
            this.textBox_permadd.TabIndex = 32;
            // 
            // textBox_tempadd
            // 
            this.textBox_tempadd.Location = new System.Drawing.Point(1064, 68);
            this.textBox_tempadd.Name = "textBox_tempadd";
            this.textBox_tempadd.Size = new System.Drawing.Size(100, 20);
            this.textBox_tempadd.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(956, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Permanent Address";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(956, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Temporary Address";
            // 
            // menuStrip_students
            // 
            this.menuStrip_students.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem});
            this.menuStrip_students.Location = new System.Drawing.Point(3, 3);
            this.menuStrip_students.Name = "menuStrip_students";
            this.menuStrip_students.Size = new System.Drawing.Size(858, 24);
            this.menuStrip_students.TabIndex = 0;
            this.menuStrip_students.Text = "Manage";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.manageToolStripMenuItem.Text = "Manage";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
            // 
            // tabPage_class
            // 
            this.tabPage_class.Location = new System.Drawing.Point(4, 22);
            this.tabPage_class.Name = "tabPage_class";
            this.tabPage_class.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_class.Size = new System.Drawing.Size(864, 380);
            this.tabPage_class.TabIndex = 1;
            this.tabPage_class.Text = "Class";
            this.tabPage_class.UseVisualStyleBackColor = true;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 413);
            this.Controls.Add(this.tabControl_Main);
            this.MainMenuStrip = this.menuStrip_students;
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_students.ResumeLayout(false);
            this.tabPage_students.PerformLayout();
            this.menuStrip_students.ResumeLayout(false);
            this.menuStrip_students.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_students;
        private System.Windows.Forms.MenuStrip menuStrip_students;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage_class;
        private System.Windows.Forms.TextBox textBox_permadd;
        private System.Windows.Forms.TextBox textBox_tempadd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}