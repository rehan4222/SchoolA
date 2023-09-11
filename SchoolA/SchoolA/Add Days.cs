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
    public partial class Add_Days : Form
    {
        SMSEntities context = new SMSEntities();
        public Add_Days()
        {
            InitializeComponent();
            var result = (from c in context.Add_Days_Details select c).ToList();
            dataGridView_daysshow.DataSource = result;
        }

        private void button_Savedays_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox_daysadd.Text != string.Empty)
                {
                    using (var context = new SMSEntities()) ;
                    var obj_daysadd = new Add_Days_Detail();
                    obj_daysadd.Days = textBox_daysadd.Text;
                    context.Add_Days_Details.Add(obj_daysadd);
                    context.SaveChanges();
                    var result = (from c in context.Add_Days_Details select c).ToList();
                    dataGridView_daysshow.DataSource = result;
                    textBox_daysadd.Clear();

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
