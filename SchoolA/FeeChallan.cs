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
    
    public partial class FeeChallan : Form
    {
        SMSEntities context = new SMSEntities();
        public FeeChallan()
        {
            InitializeComponent();
        }

        private void comboBox_byclassfeechallan_MouseClick(object sender, MouseEventArgs e)
        {
            var result = (from c in context.StudentDetails select c.StudentClass).ToList();
            comboBox_byclassfeechallan.DataSource = result;
        }
        private void comboBox_byclassfeechallan_SelectedIndexChanged(object sender, EventArgs e)
        {
             var result = (from std in context.StudentDetails join
                          fee in context.ClassFeeEntries on std.StudentClass equals
                         fee.Class_Name where std.StudentClass == comboBox_byclassfeechallan.Text
                          select new
                          {
                              std.StudentID, std.StudentName, std.StudentFname, std.StudentClass,
                              fee.Fees_Name, fee.FeeTerm, fee.Fee_Amount
                          }).ToList();
            dataGridView_studentdetails.DataSource = result;
                        
                         
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button_getchallan_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context=new SMSEntities())
                {
                    int index = 1;
                    foreach (DataGridViewRow item in dataGridView_studentdetails.Rows)
                    {
                        var obj_feechallan = new StudentFee();
                        if (item.Cells["StudentName"].Value == dataGridView_studentdetails.Rows[index-1].Cells["StudentName"].Value 
                            && item.Cells["StudentFname"].Value == dataGridView_studentdetails.Rows[index-1].Cells["StudentFname"].Value
                            && index!=1)
                        {
                            obj_feechallan.FeeChallanID = GetLastChallanID();
                        }
                        else
                        {
                            obj_feechallan.FeeChallanID = GetLastChallanID() + 1;
                        }
                        obj_feechallan.FeeAmount = Convert.ToInt32(item.Cells["Fee_Amount"].Value);
                        obj_feechallan.FeeDueDate = dateTimePicker_duedate.Value.Date;
                        obj_feechallan.FeeIssueDate = dateTimePicker_IssueDate.Value.Date;
                        obj_feechallan.FeeTerm = item.Cells["FeeTerm"].Value.ToString();
                        obj_feechallan.FeeType= item.Cells["Fees_Name"].Value.ToString();
                        obj_feechallan.StudentClass= item.Cells["StudentClass"].Value.ToString();
                        obj_feechallan.StudentFname= item.Cells["StudentFname"].Value.ToString();
                        obj_feechallan.StudentID= Convert.ToInt32(item.Cells["StudentID"].Value);
                        obj_feechallan.StudentName= item.Cells["StudentName"].Value.ToString();
                        context.StudentFees.Add(obj_feechallan);
                        context.SaveChanges();
                        index++;
                    }
                }
                var result = (from c in context.StudentFees select c).ToList();
                dataGridView_feechallandetails.DataSource = result;

            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }

        int GetLastChallanID()
        {
            using (var context= new SMSEntities())
            {
                var result = (from c in context.StudentFees select c.FeeChallanID).DefaultIfEmpty(0).Max();
                //var result = context.StudentFees.DefaultIfEmpty(0).Max(fee => fee.FeeChallanID)
                return result;
            }
        }

        private void radioButton_byclass_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
