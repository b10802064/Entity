using Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    public partial class delForm : Form
    {
        public delForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ContactsModel context = new ContactsModel();
                int a = Convert.ToInt32(textBox1.Text);
                var aa = context.Table.Where((x) => x.Id == a);
                foreach (var o in aa)
                {
                    context.Table.Remove(o);
                }
                context.SaveChanges();
                MessageBox.Show("存檔完成");
                ClearTextBoxes();
            }
            catch (Exception ex)
            { MessageBox.Show($"發生錯誤 {ex.ToString()}"); }
        }

        private void ClearTextBoxes()
        {
            textBox1.Clear();
        }
    }
}
