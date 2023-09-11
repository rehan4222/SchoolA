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
   
    public partial class TeacherClassMapping : Form
    {
        SMSEntities context = new SMSEntities();
        public TeacherClassMapping()
        {
            InitializeComponent();
            var result = (from c in context.TeacherClassMaps select c).ToList();
            dataGridView_teacherclassmapping.DataSource = result;
        }

        private void comboBox_teachermap_MouseClick(object sender, MouseEventArgs e)
        {
            var result = (from c in context.TeacherRecords select c.TeacherName).ToList();
            comboBox_teachermap.DataSource = result;
        }

        private void comboBox_subjectmap_MouseClick(object sender, MouseEventArgs e)
        {
            var result = (from c in context.ClassSectionMaps select c.ClassSection).ToList();
            comboBox_subjectmap.DataSource = result;
        }

        private void button_SaveTeacherClassMapping_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_teachermap.Text != string.Empty && comboBox_subjectmap.Text != string.Empty)
                {
                    using (var context = new SMSEntities())
                    {
                        var obj_teacherclassmapping = new TeacherClassMap();
                        obj_teacherclassmapping.TeacherName = comboBox_teachermap.Text;
                        obj_teacherclassmapping.ClassSectionName = comboBox_subjectmap.Text;
                        context.TeacherClassMaps.Add(obj_teacherclassmapping);
                        context.SaveChanges();
                        MessageBox.Show("Data is Saved ..!");
                        var result = (from c in context.TeacherClassMaps select c).ToList();
                        dataGridView_teacherclassmapping.DataSource = result;

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
