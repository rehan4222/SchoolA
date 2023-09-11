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
    public partial class Fee : Form
    {
        SMSEntities context=new SMSEntities();
        public Fee()
        {
            InitializeComponent();
            
            var result = (from c in context.FeeTypes select c).ToList();
            dataGridView_feetype.DataSource = result;

        }

        private void button_SaveFeetype_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_feetype.Text!=string.Empty)
                {
                    using (var context = new SMSEntities())
                    {
                        var obj_feetype = new FeeType();
                        obj_feetype.FeeType1 = textBox_feetype.Text;
                        obj_feetype.FeeTerm = textBox_addterm.Text;
                        context.FeeTypes.Add(obj_feetype);
                        context.SaveChanges();
                        textBox_feetype.Clear();
                        var result = (from c in context.FeeTypes select c).ToList();
                        dataGridView_feetype.DataSource = result;
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Full Data");
                }
               
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
