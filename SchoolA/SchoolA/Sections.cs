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
    public partial class Sections : Form
    {
        SMSEntities context;
        public Sections()
        {
            InitializeComponent();
            context = new SMSEntities();
            var result = (from c in context.SectionDetails select c).ToList();
            dataGridView_sectionshow.DataSource = result;
        }

        private void button_newsections_Click(object sender, EventArgs e)
        {

            dataGridView_sectionshow.DataSource = null;
        }

        private void button_SaveSection_Click(object sender, EventArgs e)
        {
            try
            {
                
                    if (textBox_sectionadd.Text!=string.Empty)
                {
                        using (var context = new SMSEntities());
                        var obj_sectionadd = new SectionDetail();
                        obj_sectionadd.SectionName = textBox_sectionadd.Text;
                        context.SectionDetails.Add(obj_sectionadd);
                        context.SaveChanges();
                        var result = (from c in context.SectionDetails select c).ToList();
                        dataGridView_sectionshow.DataSource = result;

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

        private void button_deleteSection_Click(object sender, EventArgs e)
        {
            context = new SMSEntities();
            var sectionrow = dataGridView_sectionshow.SelectedRows[0].Index;
            var id = (int)dataGridView_sectionshow[0, sectionrow].Value;
            var obj_delete = (from c in context.SectionDetails where c.SectionID == id select c).SingleOrDefault();
            context.SectionDetails.Remove(obj_delete);
            context.SaveChanges();
        }
    }
}
