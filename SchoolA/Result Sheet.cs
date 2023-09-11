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
    
    public partial class Result_Sheet : Form
    {
        SMSEntities context = new SMSEntities();
        
        public Result_Sheet()
        {
            InitializeComponent();
            
        }

        private void comboBox_subjectresultsheet_MouseClick(object sender, MouseEventArgs e)
        {
            var result = (from c in context.SubjectDetails
                          where c.SubjectClass == textBox_resultsheetclass.Text
                          select c.SubjectName).ToList();
            comboBox_subjectresultsheet.DataSource = result; 


                
        }

        private void button_saveresultsheet_Click(object sender, EventArgs e)
        {
            dataGridView_resultsheet.DataSource = null;
            try
            {
                if (textBox_rollresultsheet.Text != string.Empty && comboBox_subjectresultsheet.Text != string.Empty
                    && textBox_marksobtresultsheet.Text != string.Empty && textBox_totmarksrsultsheet.Text != string.Empty)
                {
                    using (var context = new SMSEntities())
                    {
                        var obj_resultsheet = new Result();
                        obj_resultsheet.StudentRollNu = Convert.ToInt32(textBox_rollresultsheet.Text);
                        obj_resultsheet.MarksObtained = Convert.ToInt32(textBox_marksobtresultsheet.Text);
                        obj_resultsheet.TotalMarks = Convert.ToInt32(textBox_totmarksrsultsheet.Text);
                        obj_resultsheet.Subjects = comboBox_subjectresultsheet.Text;
                        double marksobt = Convert.ToDouble(textBox_marksobtresultsheet.Text);
                        double markstot =Convert.ToDouble(textBox_totmarksrsultsheet.Text);
                        var res = (marksobt / markstot);
                        var percent = (res * 100).ToString();
                        obj_resultsheet.Percentage = Convert.ToDouble(percent);
                        obj_resultsheet.Date = dateTimePicker_resultsheet.Value;
                        obj_resultsheet.ExamType = comboBox_examtyperesultsheet.Text;
                        context.Results.Add(obj_resultsheet);
                        context.SaveChanges();
                        var data = (from c in context.Results select c).ToList();
                        dataGridView_resultsheet.DataSource = data;
                    }

                }
                else
                {
                    MessageBox.Show("Please Enter Full Details");
                }

            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }

        private void textBox_rollresultsheet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                if (textBox_rollresultsheet.Text!=string.Empty)
                {
                    var temp = Convert.ToInt32(textBox_rollresultsheet.Text);
                    var result = (from c in context.StudentDetails
                                  where c.StudentID == temp
                                  select new { c.StudentName, c.StudentFname, c.StudentClass }).ToList();
                    foreach (var item in result)
                    {
                        textBox_nameresultsheet.Text = item.StudentName;
                        textBox_fnameresultsheet.Text = item.StudentFname;
                        textBox_resultsheetclass.Text = item.StudentClass;
                    }
                }
                
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_examtyperesultsheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            var result = (from c in context.ExamTypes select c.ExamType1).ToList();
            comboBox_examtyperesultsheet.DataSource = result;
        }
    }
}
