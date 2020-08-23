namespace NumberConverter
{
    partial class TransCtrl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbStd = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbStd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbHexRvs = new System.Windows.Forms.TextBox();
            this.tbHex = new System.Windows.Forms.TextBox();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbConverter = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "10进制";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "16进制";
            // 
            // lbStd
            // 
            this.lbStd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbStd.AutoSize = true;
            this.lbStd.Location = new System.Drawing.Point(56, 176);
            this.lbStd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStd.Name = "lbStd";
            this.lbStd.Size = new System.Drawing.Size(53, 15);
            this.lbStd.TabIndex = 1;
            this.lbStd.Text = " 2进制";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tbStd, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbStd, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbHexRvs, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbHex, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbNum, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbConverter, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(528, 216);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tbStd
            // 
            this.tbStd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbStd.Location = new System.Drawing.Point(117, 156);
            this.tbStd.Margin = new System.Windows.Forms.Padding(4);
            this.tbStd.Multiline = true;
            this.tbStd.Name = "tbStd";
            this.tbStd.ReadOnly = true;
            this.tbStd.Size = new System.Drawing.Size(407, 56);
            this.tbStd.TabIndex = 4;
            this.toolTip1.SetToolTip(this.tbStd, "使用标准格式的二进制格式");
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "逆向16进制";
            // 
            // tbHexRvs
            // 
            this.tbHexRvs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHexRvs.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tbHexRvs.Location = new System.Drawing.Point(117, 120);
            this.tbHexRvs.Margin = new System.Windows.Forms.Padding(4);
            this.tbHexRvs.Name = "tbHexRvs";
            this.tbHexRvs.Size = new System.Drawing.Size(407, 25);
            this.tbHexRvs.TabIndex = 3;
            this.toolTip1.SetToolTip(this.tbHexRvs, "左低位右高位16进制格式，一般在保存文件时使用");
            this.tbHexRvs.TextChanged += new System.EventHandler(this.tbHexRvs_TextChanged);
            this.tbHexRvs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHexRvs_KeyPress);
            // 
            // tbHex
            // 
            this.tbHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHex.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tbHex.Location = new System.Drawing.Point(117, 82);
            this.tbHex.Margin = new System.Windows.Forms.Padding(4);
            this.tbHex.Name = "tbHex";
            this.tbHex.Size = new System.Drawing.Size(407, 25);
            this.tbHex.TabIndex = 2;
            this.toolTip1.SetToolTip(this.tbHex, "左高位右低位16进制格式");
            this.tbHex.TextChanged += new System.EventHandler(this.tbHex_TextChanged);
            this.tbHex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHex_KeyPress);
            // 
            // tbNum
            // 
            this.tbNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNum.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tbNum.Location = new System.Drawing.Point(117, 44);
            this.tbNum.Margin = new System.Windows.Forms.Padding(4);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(407, 25);
            this.tbNum.TabIndex = 1;
            this.toolTip1.SetToolTip(this.tbNum, "xxx");
            this.tbNum.TextChanged += new System.EventHandler(this.tbNum_TextChanged);
            this.tbNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNum_KeyPress);
            this.tbNum.Validating += new System.ComponentModel.CancelEventHandler(this.tbNum_Validating);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "转换方法";
            // 
            // cmbConverter
            // 
            this.cmbConverter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbConverter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConverter.FormattingEnabled = true;
            this.cmbConverter.Location = new System.Drawing.Point(117, 7);
            this.cmbConverter.Margin = new System.Windows.Forms.Padding(4);
            this.cmbConverter.Name = "cmbConverter";
            this.cmbConverter.Size = new System.Drawing.Size(407, 23);
            this.cmbConverter.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cmbConverter, "选择转换方法");
            this.cmbConverter.SelectedIndexChanged += new System.EventHandler(this.cmbConverter_SelectedIndexChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 300;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "提示";
            // 
            // TransCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TransCtrl";
            this.Size = new System.Drawing.Size(528, 216);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbStd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.TextBox tbStd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbHex;
        private System.Windows.Forms.TextBox tbHexRvs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbConverter;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
