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
    public partial class Attendence_Sheet : Form
    {
        SMSEntities context = new SMSEntities();
        public Attendence_Sheet()
        {
            InitializeComponent();
        }

        private void comboBox_classattendence_MouseClick(object sender, MouseEventArgs e)
        {
            var result = (from c in context.StudentDetails select c.StudentClass).ToList();
            comboBox_classattendence.DataSource = result;

        }

        private void comboBox_classattendence_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView_attendencesheet.Rows.Clear();
            
             var result = (from c in context.StudentDetails
                          where c.StudentClass == comboBox_classattendence.Text
                          select new { c.StudentID, c.StudentName }).ToList();
            foreach (var item in result)
            {
                dataGridView_attendencesheet.Rows.Add(item.StudentID, item.StudentName);
            }
        }
    }
}
