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
    public partial class Class : Form
    {
        SMSEntities context;
        public Class()
        {
            InitializeComponent();
            context = new SMSEntities();
            var result = (from c in context.ClassDetails select c).ToList();
            dataGridView_classinfo.DataSource = result;
            var result1 = (from c in context.ClassSectionMaps select c).ToList();
            dataGridView_mapsectiontoclass.DataSource = result1;
        }

        private void button1_new_Click(object sender, EventArgs e)
        {
            context = new SMSEntities();
            var result = (from c in context.ClassDetails select c).ToList();
            dataGridView_classinfo.DataSource = result;
        }

        private void button2_save_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox1.Text != string.Empty)
                {
                    using (var context = new SMSEntities());
                    var obj_classinfo = new ClassDetail();
                    obj_classinfo.ClassName= textBox1.Text;
                    context.ClassDetails.Add(obj_classinfo);
                    context.SaveChanges();
                    var result = (from c in context.ClassDetails select c).ToList();
                    dataGridView_classinfo.DataSource = result;
                    MessageBox.Show("Classes are Saved ..!");

                }
                else
                {

                    MessageBox.Show("Please Enter Full Data");
                
                }
            }
            catch (Exception ee)
            {

                MessageBox.Show("Please Enter Full Data");
            }

        }

        private void comboBox_classmap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_classmap_MouseClick(object sender, MouseEventArgs e)
        {
            var result = (from c in context.ClassDetails select c.ClassName).ToList();
            comboBox_classmap.DataSource = result;
        }

        private void comboBox_sectionmap_MouseClick(object sender, MouseEventArgs e)
        {
            var result = (from c in context.SectionDetails select c.SectionName).ToList();
            comboBox_sectionmap.DataSource = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new SMSEntities())
            {
                var obj_map = new ClassSectionMap();
                var clasmap = comboBox_classmap.Text;
                var sectmap = comboBox_sectionmap.Text;
                clasmap += sectmap;
                obj_map.ClassSection = clasmap;
                context.ClassSectionMaps.Add(obj_map);
                context.SaveChanges();
                var result1 = (from c in context.ClassSectionMaps select c).ToList();
                dataGridView_mapsectiontoclass.DataSource = result1;
            }
        }
    }
}
