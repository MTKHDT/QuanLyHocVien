using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class FormShow : Form
    {
        private List<Server.Items> lst_item;
        private Server.Table table;
        private Server.Items newItem;
        public FormShow()
        {
            InitializeComponent();
        }

        private void FormShow_Load(object sender, EventArgs e)
        {
            //Dinh dang cai form
            ServerView.View.LoadTable(dataGridView1, table);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //hien form dien thong tin (tu dong tao ID)
            ServerAdd.Add.AddTable(dataGridView1, newItem);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowSelected = Convert.ToInt32(dataGridView1.CurrentRow.Index);
            ServerDelete.Delete.delele(dataGridView1,lst_item[rowSelected]);
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowSelected = Convert.ToInt32(dataGridView1.CurrentRow.Index);
            ServerUpdate.Update.update(dataGridView1, lst_item[rowSelected]);
        }
    }
}
