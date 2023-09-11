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
    public partial class Exam_Type : Form
    {
    
        public Exam_Type()
        {
            InitializeComponent();
            dataGridView_examtype.DataSource = null;
        }

        private void button_Savexamtype_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_addexamtype.Text!=string.Empty)
                {
                    using (var context=new SMSEntities())
                    {
                        var obj_examtype = new ExamType();
                        obj_examtype.ExamType1 = textBox_addexamtype.Text;
                        context.ExamTypes.Add(obj_examtype);
                        context.SaveChanges();
                        var result = (from c in context.ExamTypes select c.ExamType1).ToList();
                        dataGridView_examtype.DataSource = result;
                    }
                }
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }

        }
    }
}
