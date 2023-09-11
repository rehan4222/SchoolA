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
    public partial class Subjects : Form
    {
        SMSEntities context;
        public Subjects()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button_newsubjects_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_classsubjects_MouseClick(object sender, MouseEventArgs e)
        {
            context = new SMSEntities();
            var result = (from c in context.ClassDetails select c.ClassName).ToList();
            comboBox_classsubjects.DataSource = result;
        }

        private void button_Savesubjects_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_subjects.Text!=string.Empty)
                {
                    using (var context =new SMSEntities())
                    {
                       var  obj_subjects = new SubjectDetail();
                        obj_subjects.SubjectClass = comboBox_classsubjects.Text;
                        obj_subjects.SubjectName = textBox_subjects.Text;
                        context.SubjectDetails.Add(obj_subjects);
                        context.SaveChanges();
                        var result = (from c in context.SubjectDetails select c).ToList();
                        dataGridView_subjects.DataSource = result;
                    }

                }
                else
                {
                    MessageBox.Show("Please Enter Full Data");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
