using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using XLYJ.Data;

namespace XLYJ
{
    public partial class FrmSingleStuInfo : XtraForm
    {

        public X_Student _StuInfo;

        public FrmSingleStuInfo()
        {
            InitializeComponent();
        }
        public FrmSingleStuInfo(X_Student StuInfo):this()
        {
            _StuInfo = StuInfo;
        }

        private void FrmSingleStuInfo_Load(object sender, EventArgs e)
        {
            if (null != _StuInfo)
            {
                GetStuInfoEntity(_StuInfo);
            }
            else
            {
                using (var db = new XLYJEntities())
                {
                    var stuid = db.X_Student.Count() > 0 ? db.X_Student.Max(p => p.ID) : 0;
                    if (0 != stuid)
                    {
                        var stu = db.X_Student.FirstOrDefault(p => p.ID == stuid);
                        string code = stu.Code;
                        int num = int.Parse(code.Substring(3, 3));
                        num += 1;
                        string cnum = num > 99 ? num.ToString() : num > 9 ? "0" + num.ToString() : "00" + num.ToString();
                        txtCode.Text = "XY_" + cnum;
                    }
                    else
                    {
                        txtCode.Text = "XY_001";
                    }
                }
            }
        }

        public void SetStuInfoEntity(X_Student StuInfo)
        {
            StuInfo.Code = txtCode.Text.Trim();
            StuInfo.Name = txtName.Text.Trim();
            StuInfo.Sex = rdoSex.SelectedIndex == 0 ? "男" : "女";
            StuInfo.Birthday = dtBirthday.DateTime.Date;
            StuInfo.Age = txtAge.Text.Trim() == "" ? 0 : int.Parse(txtAge.Text.Trim());
            StuInfo.Phone = txtPhone.Text.Trim();
            StuInfo.QQ = txtQQ.Text.Trim();
            StuInfo.Address = txtAddress.Text;
            StuInfo.WeChat = txtWeChat.Text;
            StuInfo.Career = txtCareer.Text;
            StuInfo.Remark = txtRemark.Text;
        }

        public void GetStuInfoEntity(X_Student StuInfo)
        {
            txtCode.Tag = StuInfo.ID;
            txtCode.Text = StuInfo.Code;
            txtName.Text = StuInfo.Name;
            rdoSex.SelectedIndex = StuInfo.Sex == "男" ? 0 : 1;
            dtBirthday.DateTime = (DateTime)StuInfo.Birthday;
            txtPhone.Text = StuInfo.Phone;
            txtAge.Text = StuInfo.Age.ToString();
            txtQQ.Text = StuInfo.QQ;
            txtAddress.Text = StuInfo.Address;
            txtWeChat.Text = StuInfo.WeChat;
            txtCareer.Text = StuInfo.Career;
            txtRemark.Text = StuInfo.Remark;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new XLYJEntities())
            {
                if (txtCode.Tag != null)
                {
                    int id = int.Parse(txtCode.Tag.ToString());
                    var stu = db.X_Student.FirstOrDefault(p => p.ID == id);
                    SetStuInfoEntity(stu);
                    stu.ModifyPerson = "admin";
                    stu.ModifyTime = DateTime.Now;
                    db.SaveChanges();
                }
                else
                {
                    X_Student stu = new X_Student();
                    SetStuInfoEntity(stu);
                    stu.CreatePerson = "admin";
                    stu.CreateTime = DateTime.Now;
                    db.X_Student.Add(stu);
                    db.SaveChanges();
                }
                this.DialogResult = DialogResult.Yes;
            }
        }

        private void dtBirthday_TextChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dtBirthday.DateTime.Year;
            if (dtBirthday.DateTime.Month > today.Month) age--;
            txtAge.Text = age.ToString();
        }
    }
}