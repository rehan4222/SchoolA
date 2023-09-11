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
    public partial class Class_Fee_Entry : Form
    {
        SMSEntities context = new SMSEntities();
        public Class_Fee_Entry()
        {
            InitializeComponent();
        }

        private void comboBox_classfeesinfo_MouseClick(object sender, MouseEventArgs e)
        {
            
            var result = (from c in context.ClassDetails select c.ClassName).ToList();
            comboBox_classfeesinfo.DataSource = result;
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            var result = (from c in context.FeeTypes select c.FeeType1).ToList();
            comboBox1.DataSource = result;
        }

        private void button_Saveclassfeeentry_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text!=string.Empty && comboBox_classfeesinfo.Text != string.Empty && textBox_feeamount.Text != string.Empty  && textBox_term.Text != string.Empty) 
                {
                    using (var context=new SMSEntities())
                    {
                        var obj_classfeeentry = new ClassFeeEntry();
                        obj_classfeeentry.Class_Name = comboBox_classfeesinfo.Text;
                        obj_classfeeentry.Fees_Name = comboBox1.Text;
                        obj_classfeeentry.FeeTerm = textBox_term.Text;
                        obj_classfeeentry.Fee_Amount = Convert.ToInt32(textBox_feeamount.Text);
                        context.ClassFeeEntries.Add(obj_classfeeentry);
                        context.SaveChanges();
                        var result = (from c in context.ClassFeeEntries select c).ToList();
                        dataGridView_classfeeentry.DataSource = result;
                        MessageBox.Show("Data is Saved...!");
                        textBox_feeamount.Clear();
                        textBox_term.Clear();
                        comboBox1.SelectedItem = null;
                        comboBox_classfeesinfo.SelectedItem = null;
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
