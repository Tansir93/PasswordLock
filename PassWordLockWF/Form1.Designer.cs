﻿namespace PassWordLockWF
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAppName = new System.Windows.Forms.TextBox();
            this.tbAccount = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbmsg = new System.Windows.Forms.Label();
            this.btSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "账户：";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(205, 109);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(40, 23);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "密码：";
            // 
            // tbAppName
            // 
            this.tbAppName.Location = new System.Drawing.Point(54, 12);
            this.tbAppName.Name = "tbAppName";
            this.tbAppName.Size = new System.Drawing.Size(191, 21);
            this.tbAppName.TabIndex = 4;
            // 
            // tbAccount
            // 
            this.tbAccount.Location = new System.Drawing.Point(54, 44);
            this.tbAccount.Name = "tbAccount";
            this.tbAccount.Size = new System.Drawing.Size(191, 21);
            this.tbAccount.TabIndex = 5;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(54, 73);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(191, 21);
            this.tbPassword.TabIndex = 6;
            // 
            // lbmsg
            // 
            this.lbmsg.AutoSize = true;
            this.lbmsg.Location = new System.Drawing.Point(14, 109);
            this.lbmsg.Name = "lbmsg";
            this.lbmsg.Size = new System.Drawing.Size(0, 12);
            this.lbmsg.TabIndex = 7;
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(162, 109);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(37, 23);
            this.btSelect.TabIndex = 8;
            this.btSelect.Text = "查看";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 139);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.lbmsg);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbAccount);
            this.Controls.Add(this.tbAppName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAppName;
        private System.Windows.Forms.TextBox tbAccount;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbmsg;
        private System.Windows.Forms.Button btSelect;
    }
}

