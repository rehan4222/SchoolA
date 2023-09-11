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
    public partial class Time : Form
    {
        SMSEntities context = new SMSEntities();
        public Time()
        {
            InitializeComponent();
            var result = (from c in context.Timings select c).ToList();
            dataGridView_timingshow.DataSource = result;
        }

        private void button_Savetiming_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox_timingadd.Text != string.Empty)
                {
                    using (var context = new SMSEntities()) ;
                    var obj_timingadd = new Timing();
                    obj_timingadd.Time = textBox_timingadd.Text;
                    context.Timings.Add(obj_timingadd);
                    context.SaveChanges();
                    var result = (from c in context.Timings select c).ToList();
                    dataGridView_timingshow.DataSource = result;
                    textBox_timingadd.Clear();

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
    }
}
