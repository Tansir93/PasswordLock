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
    public partial class Form1 : Form
    {
        FileHelper filehelper = null;
        FrSelect fr = null;
        public Form1()
        {
            InitializeComponent();
            if (filehelper == null)
            {
                filehelper = new FileHelper();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            objAccount obj = new objAccount();
            obj.Account = tbAccount.Text;
            obj.AppName = tbAppName.Text;
            obj.Password = tbPassword.Text;
            if (filehelper.AddFileText(obj))
            {
                tbAccount.Text = "";
                tbAppName.Text = "";
                tbPassword.Text = "";
                lbmsg.Text = "保存成功！";
            }
            else
            {
                lbmsg.Text = "保存失败！";
            }
        }

        private void btSelect_Click(object sender, EventArgs e)
        {

            if (fr == null || fr.IsDisposed)
            {
                fr = new FrSelect();
                fr.Show();
            }
            else
            {
                fr.Show();
            }

        }
    }
}
