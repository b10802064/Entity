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
    public partial class selectForm : Form
    {
        public selectForm()
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
                    MessageBox.Show($"查詢結果 :\n商品名稱 : {o.name}\n商品數量 : {o.quantity}\n商品價格 : {o.price}\n商品類別 : {o.classes}");
                }

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
