using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraTabbedMdi;

namespace XLYJ
{
    public partial class FrmMainOrder : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMainOrder()
        {
            InitializeComponent();
        }

        private void barbtnStuInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            string caption = e.Item.Caption;
            if (!this.IsOpened(caption))
            {
                FrmStuInfo frm = new FrmStuInfo();
                frm.MdiParent = this;
                frm.Text = caption;
                frm.WindowState = FormWindowState.Maximized;
                frm.Dock = DockStyle.Fill;
                frm.Show();
                frm.Update();
            }
        }

        public bool IsOpened(string name)
        {
            bool result = false;
            foreach (XtraMdiTabPage xtraMdiTabPage in this.xtraTabbedMdiManager.Pages)
            {
                if (name == xtraMdiTabPage.Text)
                {
                    result = true;
                    this.xtraTabbedMdiManager.SelectedPage = xtraMdiTabPage;
                    break;
                }
            }
            return result;
        }
    }
}