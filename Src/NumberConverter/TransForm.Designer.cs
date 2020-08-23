namespace NumberConverter
{
    partial class TransForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransForm));
            this.transCtrl1 = new NumberConverter.TransCtrl();
            this.SuspendLayout();
            // 
            // transCtrl1
            // 
            this.transCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transCtrl1.Location = new System.Drawing.Point(0, 0);
            this.transCtrl1.Margin = new System.Windows.Forms.Padding(5);
            this.transCtrl1.Name = "transCtrl1";
            this.transCtrl1.Size = new System.Drawing.Size(653, 301);
            this.transCtrl1.TabIndex = 0;
            // 
            // TransForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 301);
            this.Controls.Add(this.transCtrl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransForm";
            this.Text = "全能进制转换工具（输入自动转换）";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TransForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private TransCtrl transCtrl1;
    }
}

