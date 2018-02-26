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
    public partial class FrmStuInfo : XtraForm
    {
        public FrmStuInfo()
        {
            InitializeComponent();
        }

        private void FrmStuInfo_Load(object sender, EventArgs e)
        {
            BindStuInfoes();
        }
        public void BindStuInfoes()
        {
            using (var dataContext = new XLYJEntities())
            {
                List<X_Student> dataSource = dataContext.X_Student.ToList<X_Student>();
                this.gridControl.DataSource = dataSource;
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (FrmSingleStuInfo frm = new FrmSingleStuInfo())
            {
                DialogResult dialogResult = frm.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    this.BindStuInfoes();
                }
            }
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.gridView.RowCount > 0)
            {
                DialogResult dialogResult = XtraMessageBox.Show("确定删除吗？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int _id = ((X_Student)this.gridView.GetRow(this.gridView.FocusedRowHandle)).ID;
                    using (var dataContext = new XLYJEntities())
                    {
                        X_Student stu = dataContext.X_Student.SingleOrDefault((X_Student p) => p.ID == _id);
                        if (null != stu)
                        {
                            dataContext.X_Student.Remove(stu);
                        }
                        dataContext.SaveChanges();
                        this.BindStuInfoes();
                    }
                }
            }
        }

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.gridView.RowCount > 0)
            {
                X_Student stu = this.gridView.GetFocusedRow() as X_Student;
                using (FrmSingleStuInfo frmSingleProduct = new FrmSingleStuInfo(stu))
                {
                    DialogResult dialogResult = frmSingleProduct.ShowDialog();
                    if (dialogResult == DialogResult.Yes)
                    {
                        this.BindStuInfoes();
                    }
                }
            }
        }

        private void btnInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.gridView.RowCount > 0)
            {
                X_Student stu = this.gridView.GetFocusedRow() as X_Student;
                using (FrmSingleStuInformation frm = new FrmSingleStuInformation(stu.ID))
                {
                    frm.ShowDialog();
                }
            }
        }
    }
}