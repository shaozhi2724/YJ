using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XLYJ.Data;

namespace XLYJ
{
    public partial class FrmSingleStuInformation : XtraForm
    {
        public int _studentID;
        public FrmSingleStuInformation()
        {
            InitializeComponent();
        }

        public FrmSingleStuInformation(int studentID)
            : this()
        {
            _studentID = studentID;
        }
    }
}
