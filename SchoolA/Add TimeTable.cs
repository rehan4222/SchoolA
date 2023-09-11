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
    public partial class Add_TimeTable : Form
    {
        SMSEntities context = new SMSEntities();
        public Add_TimeTable()
        {
            InitializeComponent();
            //var result = (from c in context.TimeTables select c).ToList();
            //dataGridView_addtimetable.DataSource = result;
        }

        private void comboBox_classtimetable_MouseClick(object sender, MouseEventArgs e)
        {
            var result = (from c in context.TeacherClassMaps select c.ClassSectionName).ToList();
            
            comboBox_classtimetable.DataSource = result;
        }

        private void comboBox_Subjecttimetable_MouseClick(object sender, MouseEventArgs e)
        {
            var result = (from c in context.TeacherSubjectMaps where c.TeacherName==comboBox_teachertimetable.Text select c.SubjectAssigned).ToList();
            comboBox_Subjecttimetable.DataSource = result;
        }

        private void comboBox_daytimetable_MouseClick(object sender, MouseEventArgs e)
        {
            var result = (from c in context.Add_Days_Details select c.Days).ToList();
            comboBox_daytimetable.DataSource = result;
        }

        private void comboBox_teachertimetable_MouseClick(object sender, MouseEventArgs e)
        {
            var result = (from c in context.TeacherClassMaps where c.ClassSectionName==comboBox_classtimetable.Text select c.TeacherName).ToList();
            comboBox_teachertimetable.DataSource = result;
        }

        private void comboBox_timingtimetable_MouseClick(object sender, MouseEventArgs e)
        {
            var result = (from c in context.Timings select c.Time).ToList();
            comboBox_timingtimetable.DataSource = result;
        }

        private void button_Saveaddtimetable_Click(object sender, EventArgs e)
        {
            try
            {

                if (comboBox_classtimetable.Text != string.Empty && comboBox_daytimetable.Text != string.Empty && comboBox_Subjecttimetable.Text != string.Empty && comboBox_teachertimetable.Text != string.Empty && comboBox_timingtimetable.Text != string.Empty)
                {
                    using (var context = new SMSEntities()) ;
                    var obj_addtimetable = new TimeTable();
                    obj_addtimetable.Timing = comboBox_timingtimetable.Text;
                    obj_addtimetable.TeacherName = comboBox_teachertimetable.Text;
                    obj_addtimetable.SubjectName = comboBox_Subjecttimetable.Text;
                    obj_addtimetable.Day = comboBox_daytimetable.Text;
                    obj_addtimetable.ClassName = comboBox_classtimetable.Text;
                    context.TimeTables.Add(obj_addtimetable);
                    context.SaveChanges();
                    var result = (from c in context.TimeTables select c).ToList();
                    dataGridView_addtimetable.DataSource = result;
                    

                }
                else
                {

                    MessageBox.Show("Plz Enter Full Data");
                }
            }
            catch (Exception ee)
            {

                MessageBox.Show("Plz Enter Full Data");
            }

        }

        private void comboBox_searchtimetable_MouseClick(object sender, MouseEventArgs e)
        {
            var result1 = (from c in context.Add_Days_Details select c.Days).ToList();
            comboBox_searchtimetable.DataSource = result1;
           

        }

        private void button_GetDaystimetable_Click(object sender, EventArgs e)
        {
            var result = (from c in context.TimeTables where c.Day == comboBox_searchtimetable.Text select c).ToList();
            dataGridView_addtimetable.DataSource = result;
        }
    }
}
