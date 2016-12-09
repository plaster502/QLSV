using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLHS
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1(bool rule)
        {
            InitializeComponent();
            ribPg_AppManager.Visible = rule;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_DsKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            uc_QLKhoa khoa = new uc_QLKhoa();
            khoa.Visible = true;
            khoa.Dock = DockStyle.Fill;
            pn_ChinhSua.Controls.Clear();
            pn_ChinhSua.Controls.Add(khoa);
        }
    }
}
