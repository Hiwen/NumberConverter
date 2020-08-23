using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberConverter
{
    public partial class TransCtrl : UserControl
    {
        static IDictionary<string, IConverter> Converters = new Dictionary<string, IConverter>();

        static TransCtrl()
        {
            var types = typeof(TransCtrl).Assembly.GetTypes();
            foreach (Type item in types)
            {
                // 忽略 接口 和 抽象类
                if (item.IsInterface) continue;
                if (item.IsAbstract) continue;
                if (item.IsGenericType) continue;

                Type[] ins = item.GetInterfaces();
                foreach (Type ty in ins)
                {
                    if (ty == typeof(IConverter))
                    {
                        IConverter obj = Activator.CreateInstance(item) as IConverter;
                        if (obj != null)
                        {
                            if (Converters.ContainsKey(obj.Name))
                            {
                                throw new Exception($"数据转换器重复实现! " +
                                    $"重复类：【{obj.Name}】 和 【{Converters[obj.Name].GetType()}】");
                            }

                            Converters.Add(obj.Name, obj);
                        }
                    }
                }
            }

        }

        public TransCtrl()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            cmbConverter.Items.Clear();
            cmbConverter.Items.AddRange(Converters.Keys.ToArray());
            cmbConverter.SelectedIndex = 0;
            tbNum.Focus();
        }

        IConverter _conver = null;

        private void tbNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressComm(sender, e, "-0123456789.eE");
        }

        private void tbNum_TextChanged(object sender, EventArgs e)
        {
            if (!tbNum.Focused)
            {
                return;
            }

            if (_conver != null)
            {
                if (!ReferenceEquals(sender, tbHexRvs))
                {
                    tbHexRvs.Text = _conver.DecToHexRvs(tbNum.Text);
                }
                if (!ReferenceEquals(sender, tbHex))
                {
                    tbHex.Text = _conver.DecToHex(tbNum.Text);
                }
            }
        }

        private void tbHex_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressComm(sender, e, "0123456789ABCDEF ");
        }

        void KeyPressComm(object sender, KeyPressEventArgs e, string legalChars)
        {
            if (e.KeyChar == '\b' || e.KeyChar == '\u0016' || e.KeyChar == '\u0003')
            {
                return;
            }

            e.Handled = legalChars.IndexOf(char.ToUpper(e.KeyChar)) < 0;
        }

        private void tbHex_TextChanged(object sender, EventArgs e)
        {
            if (!tbHex.Focused)
            {
                return;
            }
            if (_conver != null)
            {
                if (!ReferenceEquals(sender, tbHexRvs))
                {
                    tbHexRvs.Text = _conver.DecToHexRvs(tbNum.Text);
                }
                if (!ReferenceEquals(sender, tbNum))
                {
                    var ts = _conver.HexToDec(tbHex.Text);

                    tbNum.Text = _conver.HexToDec(tbHex.Text);
                }
            }
        }

        private void tbHexRvs_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbHex_KeyPress(sender, e);
        }

        private void tbHexRvs_TextChanged(object sender, EventArgs e)
        {
            if (_conver != null && tbHexRvs.Focused)
            {
                if (!ReferenceEquals(sender, tbHex))
                {
                    var tt = _conver.RvsHexToHex(tbHexRvs.Text);
                    if (tt != null)
                    {
                        tbHex.Text = tt;
                    }
                }
                if (!ReferenceEquals(sender, tbNum))
                {
                    tbNum.Text = _conver.HexToDec(tbHex.Text);
                }
            }

            tbStd.Text = _conver.StandString(tbNum?.Text);
            if (string.IsNullOrEmpty(tbStd.Text))
            {
                tbStd.Text = 
                    "转换出错！\r\n" +
                    "可能原因：\r\n\r\n" +
                    "    数字的格式不正确！\r\n" +
                    "    数值范围太大！\r\n";
            }
        }

        private void cmbConverter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _conver = Converters[cmbConverter.Text];

            this.toolTip1.SetToolTip(this.tbNum, _conver.DecTips);
            lbStd.Text = _conver.StandName;
        }

        private void tbNum_Validating(object sender, CancelEventArgs e)
        {
            if (_conver != null)
            {
                e.Cancel = !_conver.IsDecNumLegal(tbNum.Text);
            }
        }

    }
}
