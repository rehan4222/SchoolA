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
    public partial class Academic_Record: Form
    {
        SMSEntities context = new SMSEntities();
        public Academic_Record()
        {
            InitializeComponent();
        }

        private void textBox_academicrollnumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox_academicrollnumber.Text != string.Empty)
                {
                    var temp = Convert.ToInt32(textBox_academicrollnumber.Text);
                    var result = (from c in context.StudentDetails join
                                  rollnu in context.Results on c.StudentID equals
                                   rollnu.StudentRollNu
                                   where c.StudentID == temp 
                                  select new { c.StudentName, c.StudentFname, c.StudentClass ,rollnu.Subjects,
                                  rollnu.MarksObtained,rollnu.TotalMarks,rollnu.Percentage}).ToList();
                    foreach (var item in result)
                    {
                        textBox_nameresultsheet.Text = item.StudentName;
                        textBox_fnameresultsheet.Text = item.StudentFname;
                        textBox_resultsheetclass.Text = item.StudentClass;
                        dataGridView_academicrecord.Rows.Add(item.Subjects,item.MarksObtained,item.TotalMarks,item.Percentage);
                    }
                }

            }
        }
    }
}
