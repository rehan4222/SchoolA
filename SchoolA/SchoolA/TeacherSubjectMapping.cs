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
    public partial class TeacherSubjectMapping : Form
    {
        SMSEntities context = new SMSEntities();
        public TeacherSubjectMapping()
        {
            InitializeComponent();
             var result = (from c in context.TeacherSubjectMaps select c).ToList();
            dataGridView1.DataSource = result;
        }

        private void comboBox_teachernamemap_MouseClick(object sender, MouseEventArgs e)
        {
            var result = (from c in context.TeacherRecords select c.TeacherName).ToList();
            comboBox_teachernamemap.DataSource = result;
        }

        private void comboBox_subjectnamemap_MouseClick(object sender, MouseEventArgs e)
        {
            var result = (from c in context.SubjectDetails select c.SubjectName).ToList();
            comboBox_subjectnamemap.DataSource = result;
        }

        private void button_SaveSection_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_subjectnamemap.Text!=string.Empty && comboBox_teachernamemap.Text!=string.Empty)
                {
                    using (var context=new SMSEntities())
                    {
                        var obj_teachersubjectmapping = new TeacherSubjectMap();
                        obj_teachersubjectmapping.TeacherName = comboBox_teachernamemap.Text;
                        obj_teachersubjectmapping.SubjectAssigned = comboBox_subjectnamemap.Text;
                        context.TeacherSubjectMaps.Add(obj_teachersubjectmapping);
                        context.SaveChanges();
                        MessageBox.Show("Data is Saved ..!");
                        var result = (from c in context.TeacherSubjectMaps select c).ToList();
                        dataGridView1.DataSource = result;

                    }

                }
                else
                {
                    MessageBox.Show("Please Enter Full Data");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
