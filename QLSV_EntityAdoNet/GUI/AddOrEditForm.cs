using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV_EntityAdoNet.DTO;
using QLSV_EntityAdoNet.BAL;
namespace QLSV_EntityAdoNet.GUI
{
    public partial class AddOrEditForm : Form
    {
        public string ID { get; set; }
        public AddOrEditForm()
        {
            InitializeComponent();
        }
        public AddOrEditForm(string ID)
        {
            InitializeComponent();
            this.ID = ID;
            GUI();
        }
        public void GUI()
        {
            if(ID != "")
            {
                SV sv = BAL.BAL.Instance.GetSVByID(Convert.ToInt32(ID));
                txb_Name.Text = sv.SVName;
                txb_Dtb.Text = sv.SVDtb.ToString();
                txb_Id.Text = sv.SVID.ToString();
                int pos = -1;
                for(int i = 0; i < cb_class.Items.Count; i++)
                {
                    if (cb_class.Items[i].ToString() == sv.LopSH.CLName)
                    {
                        pos = i;
                        break;
                    }  
                }
                cb_class.DropDownStyle = ComboBoxStyle.DropDown;
                cb_class.Text = sv.LopSH.CLName;
                bool gen = (bool)sv.SVGender;
                bool pic = (bool)sv.SVPicture;
                bool hb = (bool)sv.SVHb;
                bool cccd = (bool)sv.SVCccd;
                if(gen)
                    rb_Male.Checked = true;
                else 
                    rb_female.Checked = true;
                cb_Anh.Checked = pic;
                cb_cccd.Checked = cccd;
                cb_hb.Checked = hb;
                List<string> list = BAL.BAL.Instance.GetAllCl();
                cb_class.Items.AddRange(list.ToArray());
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (ID == "")
            {
                if(txb_Dtb.Text == "" || txb_Name.Text == "" || cb_class.Text == "")
                {
                    MessageBox.Show("Mời nhập vào thông tin còn trống");
                    return;
                }
                string name = txb_Name.Text; 
                int clid = BAL.BAL.Instance.GetIDClass(cb_class.Text);
                DateTime date = dtpker_Date.Value;
                double dtb = Convert.ToDouble(txb_Dtb.Text);
                bool gen = false;
                foreach (RadioButton rb in gb_Gender.Controls)
                {
                    if(rb.Checked)
                    {
                        if (rb.Text == "Male")
                            gen = true;
                    }
                }
                bool pic = cb_Anh.Checked;
                bool hb = cb_hb.Checked;
                bool cccd = cb_cccd.Checked;
                SV sv = new SV(clid, name, dtb, date, gen, pic, hb, cccd);
                int kq = BAL.BAL.Instance.AddSV(sv);
                if(kq > 0)
                {
                    MessageBox.Show("Thêm thành công");
                }
            }
            else
            {
                if (txb_Dtb.Text == "" || txb_Name.Text == "" || cb_class.Text == "")
                {
                    MessageBox.Show("Mời nhập vào thông tin còn trống");
                    return;
                }
                string name = txb_Name.Text;
                int clid = BAL.BAL.Instance.GetIDClass(cb_class.Text);
                DateTime date = dtpker_Date.Value;
                double dtb = Convert.ToDouble(txb_Dtb.Text);
                bool gen = false;
                foreach (RadioButton rb in gb_Gender.Controls)
                {
                    if (rb.Checked)
                    {
                        if (rb.Text == "Male")
                            gen = true;
                    }
                }
                bool pic = cb_Anh.Checked;
                bool hb = cb_hb.Checked;
                bool cccd = cb_cccd.Checked;
                SV sv = new SV(Convert.ToInt32(ID), clid, name, dtb, date, gen, pic, hb, cccd);
                int kq = BAL.BAL.Instance.UpdateSV(sv);
                if (kq > 0)
                {
                    MessageBox.Show("Cật nhật thành công");
                }
            }
        }
        private void cb_class_DropDown(object sender, EventArgs e)
        {
            cb_class.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
