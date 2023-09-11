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
    public partial class Student_Entry : Form
    {
        SMSEntities context;
        public Student_Entry()
        {
            InitializeComponent();
        }

        private void comboBox_class_MouseClick(object sender, MouseEventArgs e)
        {
            context = new SMSEntities();
            var result = (from c in context.ClassSectionMaps select c.ClassSection).ToList();
            comboBox_class.DataSource = result;
            
        }

        

        private void comboBox_preclass_MouseClick(object sender, MouseEventArgs e)
        {
            context = new SMSEntities();
            var result = (from c in context.ClassDetails select c.ClassName).ToList();
            comboBox_class.DataSource = result;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_studentname.Text!=string.Empty && textBox_fname.Text!=string.Empty && textBox_mname.Text!=string.Empty && textBox_nationality.Text!=string.Empty && textBox_contact.Text!=string.Empty && textBox_remarks.Text!=string.Empty && textBox_session.Text!=string.Empty && comboBox_class.Text!=string.Empty && comboBox_gender.Text!=string.Empty && comboBox_Religion.Text!=string.Empty)
                {
                    using (var context=new SMSEntities())
                    {
                        var obj_studententry = new StudentDetail();
                        obj_studententry.StudentName = textBox_studentname.Text;
                        obj_studententry.StudentFname = textBox_fname.Text;
                        obj_studententry.StudentMname = textBox_mname.Text;
                        obj_studententry.StudentGender = comboBox_gender.Text;
                        obj_studententry.StudentDOB = dateTimePicker1.Value;
                        obj_studententry.StudentNationality = textBox_nationality.Text;
                        obj_studententry.StudentAdmdate = dateTimePicker2.Value;
                        obj_studententry.StudentFatherContact = textBox_contact.Text;
                        obj_studententry.StudentPreviousSchool = textBox_precschool.Text;
                        obj_studententry.StudentPreviousClass = comboBox_preclass.Text;
                        obj_studententry.StudentSession = Convert.ToInt32(textBox_session.Text);
                        obj_studententry.StudentClass = comboBox_class.Text;
                        obj_studententry.StudentReligion = comboBox_Religion.Text;
                        obj_studententry.StudentRemarks = textBox_remarks.Text;
                        obj_studententry.StudentTemporaryAdd = textBox_tempadd.Text;
                        obj_studententry.StudentPermanentAdd = textBox_permadd.Text;
                        context.StudentDetails.Add(obj_studententry);
                        context.SaveChanges();
                        var result = (from c in context.StudentDetails select c).ToList();
                        dataGridView_studententry.DataSource = result;
                        MessageBox.Show("Student Records is Entered ..!");
                        textBox_contact.Clear();
                        textBox_fname.Clear();
                        textBox_mname.Clear();
                        textBox_nationality.Clear();
                        textBox_precschool.Clear();
                        textBox_remarks.Clear();
                        textBox_session.Clear();
                        textBox_studentname.Clear();
                        textBox_permadd.Clear();
                        textBox_tempadd.Clear();

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
