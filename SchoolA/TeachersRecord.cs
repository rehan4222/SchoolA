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
    public partial class TeachersRecord : Form
    {
        SMSEntities context = new SMSEntities();
        public TeachersRecord()
        {
            InitializeComponent();
            var result = (from c in context.TeacherRecords select c).ToList();
            dataGridView_teachersrecord.DataSource = result;
        }

        private void TeachersRecord_Load(object sender, EventArgs e)
        {

        }

        private void button_SaveTeachersRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_Tname.Text!=string.Empty && textBox_Fname.Text!=string.Empty && textBox_teachercnic.Text!=string.Empty && textBox_teachercontact.Text!=string.Empty && textBox_teachereducation.Text!=string.Empty && textBox_tempadd.Text!=string.Empty && textBox_permadd.Text!=string.Empty)
                {
                    using (var context=new SMSEntities())
                    {
                        var obj_teachersrecord = new TeacherRecord();
                        obj_teachersrecord.TeacherName = textBox_Tname.Text;
                        obj_teachersrecord.TeacherFName = textBox_Fname.Text;
                        obj_teachersrecord.TeacherCNIC = textBox_teachercnic.Text;
                        obj_teachersrecord.TeacherContact = textBox_teachercontact.Text;
                        obj_teachersrecord.TeacherEducation = textBox_teachereducation.Text;
                        obj_teachersrecord.TeacherTemporaryAddress=textBox_tempadd.Text;
                        obj_teachersrecord.TeacherPermanentAddress = textBox_permadd.Text;
                        context.TeacherRecords.Add(obj_teachersrecord);
                        context.SaveChanges();
                        MessageBox.Show("Teachers Records are Added..!");
                        var result = (from c in context.TeacherRecords select c).ToList();
                        dataGridView_teachersrecord.DataSource = result;

                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Full Records");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
