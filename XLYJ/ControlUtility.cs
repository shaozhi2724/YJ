using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace XLYJ
{
    public class ControlUtility
    {
        public static bool ValidateControl(LayoutControl lay)
        {
            bool result;
            foreach (Control control in lay.Controls)
            {
                if (control is TextEdit)
                {
                    TextEdit textEdit = (TextEdit)control;
                    if (textEdit.Properties.NullValuePromptShowForEmptyValue)
                    {
                        if (control.Text.Trim() == "")
                        {
                            XtraMessageBox.Show(textEdit.Properties.NullValuePrompt, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            result = false;
                            return result;
                        }
                    }
                }
                if (control is ComboBoxEdit)
                {
                    ComboBoxEdit comboBoxEdit = (ComboBoxEdit)control;
                    if (comboBoxEdit.Properties.NullValuePromptShowForEmptyValue)
                    {
                        if (control.Text.Trim() == "")
                        {
                            XtraMessageBox.Show(comboBoxEdit.Properties.NullValuePrompt, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            result = false;
                            return result;
                        }
                    }
                }
            }
            result = true;
            return result;
        }

        public string GetEncryptPassword(string input)
        {
            string result;
            using (MD5 mD = new MD5CryptoServiceProvider())
            {
                byte[] bytes = Encoding.Default.GetBytes(input);
                byte[] value = mD.ComputeHash(bytes);
                result = BitConverter.ToString(value).Replace("-", "");
            }
            return result;
        }
    }
}
