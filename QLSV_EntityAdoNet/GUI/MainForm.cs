using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV_EntityAdoNet.BAL;
using QLSV_EntityAdoNet.DTO;
namespace QLSV_EntityAdoNet.GUI
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            LoadDGV();
            LoadCBBCL();
        }
        public void LoadDGV()
        {
            dgv_sv.DataSource = BAL.BAL.Instance.GetRecord("All", "");
        }
        public void LoadCBBCL()
        {
            cb_ClassName.DataSource = BAL.BAL.Instance.GetCBCL();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddOrEditForm f = new AddOrEditForm("");
            f.ShowDialog();
            LoadDGV();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string clname = cb_ClassName.Text;
            string txt = txb_search.Text;
            dgv_sv.DataSource = BAL.BAL.Instance.GetSVBySearch(clname, txt);

        }

        private void btn_delelte_Click(object sender, EventArgs e)
        {
            if(dgv_sv.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow r in dgv_sv.SelectedRows)
                {
                    BAL.BAL.Instance.DeleteSV(Convert.ToInt32(r.Cells["ID"].Value.ToString()));
                    
                }
                LoadDGV();
            }
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            DataTable dt = dgv_sv.DataSource as DataTable;
            dgv_sv.DataSource = BAL.BAL.Instance.SortSV(cb_sort.Text, dt);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if(dgv_sv.SelectedRows.Count > 0)
            {
                AddOrEditForm f = new AddOrEditForm(dgv_sv.SelectedRows[0].Cells["ID"].Value.ToString());
                f.ShowDialog();
                LoadDGV();
            }
            
        }
    }
}
