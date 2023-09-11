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
    public partial class Fee_Receiving: Form
    {
        SMSEntities context = new SMSEntities();
        List<StudentFee> result;
        int totalfee = 0;
        public Fee_Receiving()
        {
            InitializeComponent();
        }

        private void textBox_class_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_studentname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
        private void textBox_searchchallannumber_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                {
                totalfee = 0;
                    if (textBox_searchchallannumber.Text != string.Empty)
                    {
                    dataGridView_feetypefeeamount.Rows.Clear();
                    var tempID = Convert.ToInt32(textBox_searchchallannumber.Text);
                        result = (from c in context.StudentFees
                                      where c.FeeChallanID == tempID
                                      select c).ToList();
                        textBox_studentname.Text = result[0].StudentName;
                        textBox_fname.Text = result[0].StudentFname;
                        textBox_class.Text = result[0].StudentClass;
                        textBox_term.Text = result[0].FeeTerm;
                        textBox_issuedate.Text = result[0].FeeIssueDate.ToShortDateString();
                        textBox_duedate.Text = result[0].FeeDueDate.ToShortDateString();
                    foreach (var item in result)
                    {
                        dataGridView_feetypefeeamount.Rows.Add(item.FeeType, item.FeeAmount);
                        totalfee += item.FeeAmount;
                    }
                    label_totalfee.Text = totalfee.ToString();
                }
                else
                {
                    MessageBox.Show("Please Enter Full Data");
                }
            }
            
        }

        private void button_savereceiving_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_amountpaid.Text!=string.Empty)
                {
                    using (var context=new SMSEntities())
                    {
                        foreach (var item in result)
                        {
                            var obj_receiving = new FeeReceiving();
                            obj_receiving.FeeChallanID = item.FeeChallanID;
                            obj_receiving.StudentName = item.StudentName;
                            obj_receiving.StudentFname = item.StudentFname;
                            obj_receiving.StudentClass = item.StudentClass;
                            obj_receiving.FeeTerm = item.FeeTerm;
                            obj_receiving.FeeIssueDate =item.FeeIssueDate;
                            obj_receiving.FeeDueDate = item.FeeDueDate;
                            obj_receiving.FeeType = item.FeeType;
                            obj_receiving.FeeAmount = item.FeeAmount;
                            obj_receiving.FeePaid = Convert.ToInt32(textBox_amountpaid.Text);
                            obj_receiving.FeeFine = Convert.ToInt32(textBox_fine.Text);
                            obj_receiving.FeeBalance = Convert.ToInt32(textBox_balance.Text);
                            obj_receiving.FeeReceivingDate = dateTimePicker_receivingdate.Value;
                            context.FeeReceivings.Add(obj_receiving);
                            context.SaveChanges();
                        }
                        

                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        
        private void textBox_amountpaid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox_balance.Text = (Convert.ToInt32(label_totalfee.Text) - Convert.ToInt32(textBox_amountpaid.Text)).ToString();
            }
            catch (Exception ee)
            {
                textBox_balance.Text = string.Empty;
            }
           
                 
        }

        private void textBox_fine_TextChanged_1(object sender, EventArgs e)
        {
            int tempTotal = 0;
            try
            {
                tempTotal = totalfee + Convert.ToInt32(textBox_fine.Text);
                label_totalfee.Text = tempTotal.ToString();
            }
            catch (Exception ee)
            {
                tempTotal = 0;
                label_totalfee.Text = totalfee.ToString();
                // MessageBox.Show(ee.Message);
            }
        }
    }
}
