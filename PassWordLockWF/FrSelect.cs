using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassWordLockWF
{
    public partial class FrSelect : Form
    {
        FileHelper filehelper = null;
        public FrSelect()
        {
            if (filehelper == null)
            {
                filehelper = new FileHelper();
            }
            InitializeComponent();
            DataSoure();
        }


        private void DataSoure()
        {
          List<objAccount> list=filehelper.GetFileText();
            GVSelect.DataSource = list;
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            DataSoure();
        }
    }
}
