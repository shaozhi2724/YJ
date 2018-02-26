using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XLYJ.Properties;

namespace XLYJ
{
    public partial class FrmLogin : XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Trim() == "")
            {
                XtraMessageBox.Show("帐号不能为空。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtPwd.Text.Trim() == "")
            {
                XtraMessageBox.Show("密码不能为空。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtCode.Text.Trim() != "xlyj" || txtPwd.Text.Trim() != "xlyj")
            {
                XtraMessageBox.Show("用户名密码不正确，请重新填写。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Program.IsLoginIn = true;
                this.Close();
            }
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.txtPwd.Focus();
            }
        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnLogin_Click(null,null);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
