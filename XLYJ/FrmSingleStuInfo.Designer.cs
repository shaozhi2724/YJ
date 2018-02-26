namespace XLYJ
{
    partial class FrmSingleStuInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.rdoSex = new DevExpress.XtraEditors.RadioGroup();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.txtRemark = new DevExpress.XtraEditors.TextEdit();
            this.txtAge = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtQQ = new DevExpress.XtraEditors.TextEdit();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.dtBirthday = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layBirthday = new DevExpress.XtraLayout.LayoutControlItem();
            this.layPhone = new DevExpress.XtraLayout.LayoutControlItem();
            this.layAge = new DevExpress.XtraLayout.LayoutControlItem();
            this.layQQ = new DevExpress.XtraLayout.LayoutControlItem();
            this.layAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.layRemark = new DevExpress.XtraLayout.LayoutControlItem();
            this.laySex = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtCareer = new DevExpress.XtraEditors.TextEdit();
            this.txtWeChat = new DevExpress.XtraEditors.TextEdit();
            this.layWeChat = new DevExpress.XtraLayout.LayoutControlItem();
            this.layCareer = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdoSex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQQ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBirthday.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBirthday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBirthday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layQQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laySex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCareer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeChat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layWeChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCareer)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 196);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(484, 48);
            this.panelControl1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(395, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(285, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(484, 196);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "详细信息";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtCareer);
            this.layoutControl1.Controls.Add(this.txtWeChat);
            this.layoutControl1.Controls.Add(this.rdoSex);
            this.layoutControl1.Controls.Add(this.txtCode);
            this.layoutControl1.Controls.Add(this.txtRemark);
            this.layoutControl1.Controls.Add(this.txtAge);
            this.layoutControl1.Controls.Add(this.txtAddress);
            this.layoutControl1.Controls.Add(this.txtQQ);
            this.layoutControl1.Controls.Add(this.txtPhone);
            this.layoutControl1.Controls.Add(this.txtName);
            this.layoutControl1.Controls.Add(this.dtBirthday);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(480, 173);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // rdoSex
            // 
            this.rdoSex.EditValue = "女";
            this.rdoSex.Location = new System.Drawing.Point(39, 36);
            this.rdoSex.Name = "rdoSex";
            this.rdoSex.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("男", "男"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("女", "女")});
            this.rdoSex.Size = new System.Drawing.Size(199, 25);
            this.rdoSex.StyleController = this.layoutControl1;
            this.rdoSex.TabIndex = 2;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(39, 12);
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtCode.Properties.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(199, 20);
            this.txtCode.StyleController = this.layoutControl1;
            this.txtCode.TabIndex = 0;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(39, 137);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(429, 20);
            this.txtRemark.StyleController = this.layoutControl1;
            this.txtRemark.TabIndex = 0;
            // 
            // txtAge
            // 
            this.txtAge.EditValue = "0";
            this.txtAge.Location = new System.Drawing.Point(269, 65);
            this.txtAge.Name = "txtAge";
            this.txtAge.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtAge.Properties.Appearance.Options.UseBackColor = true;
            this.txtAge.Properties.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(199, 20);
            this.txtAge.StyleController = this.layoutControl1;
            this.txtAge.TabIndex = 0;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(39, 113);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(199, 20);
            this.txtAddress.StyleController = this.layoutControl1;
            this.txtAddress.TabIndex = 0;
            // 
            // txtQQ
            // 
            this.txtQQ.Location = new System.Drawing.Point(39, 89);
            this.txtQQ.Name = "txtQQ";
            this.txtQQ.Size = new System.Drawing.Size(199, 20);
            this.txtQQ.StyleController = this.layoutControl1;
            this.txtQQ.TabIndex = 0;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(39, 65);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(199, 20);
            this.txtPhone.StyleController = this.layoutControl1;
            this.txtPhone.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(269, 12);
            this.txtName.Name = "txtName";
            this.txtName.Properties.NullValuePrompt = "姓名不能为空。";
            this.txtName.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtName.Size = new System.Drawing.Size(199, 20);
            this.txtName.StyleController = this.layoutControl1;
            this.txtName.TabIndex = 0;
            // 
            // dtBirthday
            // 
            this.dtBirthday.EditValue = null;
            this.dtBirthday.Location = new System.Drawing.Point(269, 36);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBirthday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBirthday.Properties.DisplayFormat.FormatString = "";
            this.dtBirthday.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtBirthday.Properties.EditFormat.FormatString = "";
            this.dtBirthday.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtBirthday.Properties.Mask.EditMask = "";
            this.dtBirthday.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dtBirthday.Properties.NullValuePrompt = "生日不能为空。";
            this.dtBirthday.Properties.NullValuePromptShowForEmptyValue = true;
            this.dtBirthday.Size = new System.Drawing.Size(199, 20);
            this.dtBirthday.StyleController = this.layoutControl1;
            this.dtBirthday.TabIndex = 0;
            this.dtBirthday.TextChanged += new System.EventHandler(this.dtBirthday_TextChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layCode,
            this.layName,
            this.layBirthday,
            this.layPhone,
            this.layAge,
            this.layQQ,
            this.layRemark,
            this.laySex,
            this.layAddress,
            this.layWeChat,
            this.layCareer});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(480, 173);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layCode
            // 
            this.layCode.Control = this.txtCode;
            this.layCode.Location = new System.Drawing.Point(0, 0);
            this.layCode.Name = "layCode";
            this.layCode.Size = new System.Drawing.Size(230, 24);
            this.layCode.Text = "编码";
            this.layCode.TextSize = new System.Drawing.Size(24, 14);
            // 
            // layName
            // 
            this.layName.Control = this.txtName;
            this.layName.Location = new System.Drawing.Point(230, 0);
            this.layName.Name = "layName";
            this.layName.Size = new System.Drawing.Size(230, 24);
            this.layName.Text = "姓名";
            this.layName.TextSize = new System.Drawing.Size(24, 14);
            // 
            // layBirthday
            // 
            this.layBirthday.Control = this.dtBirthday;
            this.layBirthday.Location = new System.Drawing.Point(230, 24);
            this.layBirthday.Name = "layBirthday";
            this.layBirthday.Size = new System.Drawing.Size(230, 29);
            this.layBirthday.Text = "生日";
            this.layBirthday.TextSize = new System.Drawing.Size(24, 14);
            // 
            // layPhone
            // 
            this.layPhone.Control = this.txtPhone;
            this.layPhone.Location = new System.Drawing.Point(0, 53);
            this.layPhone.Name = "layPhone";
            this.layPhone.Size = new System.Drawing.Size(230, 24);
            this.layPhone.Text = "电话";
            this.layPhone.TextSize = new System.Drawing.Size(24, 14);
            // 
            // layAge
            // 
            this.layAge.Control = this.txtAge;
            this.layAge.Location = new System.Drawing.Point(230, 53);
            this.layAge.Name = "layAge";
            this.layAge.Size = new System.Drawing.Size(230, 24);
            this.layAge.Text = "年龄";
            this.layAge.TextSize = new System.Drawing.Size(24, 14);
            // 
            // layQQ
            // 
            this.layQQ.Control = this.txtQQ;
            this.layQQ.Location = new System.Drawing.Point(0, 77);
            this.layQQ.Name = "layQQ";
            this.layQQ.Size = new System.Drawing.Size(230, 24);
            this.layQQ.Text = "QQ";
            this.layQQ.TextSize = new System.Drawing.Size(24, 14);
            // 
            // layAddress
            // 
            this.layAddress.Control = this.txtAddress;
            this.layAddress.Location = new System.Drawing.Point(0, 101);
            this.layAddress.Name = "layAddress";
            this.layAddress.Size = new System.Drawing.Size(230, 24);
            this.layAddress.Text = "地址";
            this.layAddress.TextSize = new System.Drawing.Size(24, 14);
            // 
            // layRemark
            // 
            this.layRemark.Control = this.txtRemark;
            this.layRemark.Location = new System.Drawing.Point(0, 125);
            this.layRemark.Name = "layRemark";
            this.layRemark.Size = new System.Drawing.Size(460, 28);
            this.layRemark.Text = "备注";
            this.layRemark.TextSize = new System.Drawing.Size(24, 14);
            // 
            // laySex
            // 
            this.laySex.Control = this.rdoSex;
            this.laySex.Location = new System.Drawing.Point(0, 24);
            this.laySex.Name = "laySex";
            this.laySex.Size = new System.Drawing.Size(230, 29);
            this.laySex.Text = "性别";
            this.laySex.TextSize = new System.Drawing.Size(24, 14);
            // 
            // txtCareer
            // 
            this.txtCareer.Location = new System.Drawing.Point(269, 113);
            this.txtCareer.Name = "txtCareer";
            this.txtCareer.Size = new System.Drawing.Size(199, 20);
            this.txtCareer.StyleController = this.layoutControl1;
            this.txtCareer.TabIndex = 2;
            // 
            // txtWeChat
            // 
            this.txtWeChat.Location = new System.Drawing.Point(269, 89);
            this.txtWeChat.Name = "txtWeChat";
            this.txtWeChat.Size = new System.Drawing.Size(199, 20);
            this.txtWeChat.StyleController = this.layoutControl1;
            this.txtWeChat.TabIndex = 3;
            // 
            // layWeChat
            // 
            this.layWeChat.Control = this.txtWeChat;
            this.layWeChat.Location = new System.Drawing.Point(230, 77);
            this.layWeChat.Name = "layWeChat";
            this.layWeChat.Size = new System.Drawing.Size(230, 24);
            this.layWeChat.Text = "微信";
            this.layWeChat.TextSize = new System.Drawing.Size(24, 14);
            // 
            // layCareer
            // 
            this.layCareer.Control = this.txtCareer;
            this.layCareer.Location = new System.Drawing.Point(230, 101);
            this.layCareer.Name = "layCareer";
            this.layCareer.Size = new System.Drawing.Size(230, 24);
            this.layCareer.Text = "职业";
            this.layCareer.TextSize = new System.Drawing.Size(24, 14);
            // 
            // FrmSingleStuInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 244);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmSingleStuInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学员信息";
            this.Load += new System.EventHandler(this.FrmSingleStuInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdoSex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQQ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBirthday.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBirthday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBirthday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layQQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laySex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCareer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeChat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layWeChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCareer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.TextEdit txtRemark;
        private DevExpress.XtraEditors.TextEdit txtAge;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.TextEdit txtQQ;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layCode;
        private DevExpress.XtraLayout.LayoutControlItem layName;
        private DevExpress.XtraLayout.LayoutControlItem layBirthday;
        private DevExpress.XtraLayout.LayoutControlItem layPhone;
        private DevExpress.XtraLayout.LayoutControlItem layAge;
        private DevExpress.XtraLayout.LayoutControlItem layQQ;
        private DevExpress.XtraLayout.LayoutControlItem layAddress;
        private DevExpress.XtraLayout.LayoutControlItem layRemark;
        private DevExpress.XtraEditors.RadioGroup rdoSex;
        private DevExpress.XtraEditors.DateEdit dtBirthday;
        private DevExpress.XtraLayout.LayoutControlItem laySex;
        private DevExpress.XtraEditors.TextEdit txtCareer;
        private DevExpress.XtraEditors.TextEdit txtWeChat;
        private DevExpress.XtraLayout.LayoutControlItem layWeChat;
        private DevExpress.XtraLayout.LayoutControlItem layCareer;
    }
}