using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolA
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage_students_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox_sectioninfo_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

       

        private void resultToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Entry obj_std = new Student_Entry();
            obj_std.WindowState = FormWindowState.Minimized;
            obj_std.WindowState = FormWindowState.Maximized;
            obj_std.Show();
        }

        private void classWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherClassMapping obj_tcmap = new TeacherClassMapping();
            obj_tcmap.Show();
        }

        private void subjectsWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherSubjectMapping obj_tsmap = new TeacherSubjectMapping();
            obj_tsmap.Show();
        }

        private void addTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeachersRecord obj_tr = new TeachersRecord();
            obj_tr.Show();
        }

        private void addFeeTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fee obj_fee = new Fee();
            obj_fee.Show();
        }

        private void addClasswiseFeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class_Fee_Entry obj_cfentry=new Class_Fee_Entry();
            obj_cfentry.Show();

        }

        private void generateChallanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeeChallan obj_challan = new FeeChallan();
            obj_challan.Show();
        }

        private void feeReceivingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fee_Receiving obj_receiving = new Fee_Receiving();
            obj_receiving.Show();
        }

        private void markAttendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attendence_Sheet obj_attnd = new Attendence_Sheet();
            obj_attnd.Show();
        }

        private void attendenceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addStudentWiseResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Result_Sheet obj_res = new Result_Sheet();
            obj_res.Show();
        }

        private void viewStudentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Academic_Record obj_acad = new Academic_Record();
            obj_acad.Show();
        }

        private void addExamTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exam_Type obj_examtype = new Exam_Type();
            obj_examtype.Show();
        }

        private void addTimingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Time obj_timings = new Time();
            obj_timings.Show();
        }

        private void addTimeTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_TimeTable obj_timetable = new Add_TimeTable();
            obj_timetable.Show();
            
        }

        private void addDaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Days obj_days = new Add_Days();
            obj_days.Show();
        }

        private void addClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class obj_class = new Class();
            obj_class.Show();
        }

        private void addSectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sections obj_sect = new Sections();
            obj_sect.Show();
        }

        private void addSubjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Subjects obj_sub = new Subjects();
            obj_sub.Show();
        }
    }
}
