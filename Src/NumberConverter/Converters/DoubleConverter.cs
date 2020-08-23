using System;
using System.Drawing;
using System.Text;

namespace NumberConverter.Converters
{

    public class DoubleConverter : IConverter
    {
        public string Name => "双精度浮点数转换";

        public string DecTips => "请输入双精度的浮点数，如 3.1415926535898";

        public string StandName => "IEEE 754";

        public bool IsDecNumLegal(string num)
        {
            double t;
            return double.TryParse(num, out t);
        }

        public string DecToHex(string num)
        {
            double t = double.NaN;
            if(double.TryParse(num, out t))
            {
                return Double2Hex(t);
            }

            return null;
        }

        public string DecToHexRvs(string num)
        {
            double t = double.NaN;
            if (double.TryParse(num, out t))
            {
                return Double2HexRvs(t);
            }

            return null;
        }

        public string HexToDec(string num)
        {
            var copy = num.Replace(" ", "");
            return $"{Hex2Double(copy)}";
        }

        public string RvsHexToDec(string num)
        {
            var copy = num.Replace(" ", "");
            return $"{HexRvs2Double(copy)}";
        }

        public static string Double2Hex(double value)
        {
            byte[] b = BitConverter.GetBytes(value);

            var sb = new StringBuilder();
            for (int i = b.Length - 1; i >= 0; i--)
            {
                sb.Append(Convert.ToString(b[i], 16).PadLeft(2, '0') + " ");
            }

            return sb.ToString().ToUpper();
        }

        public static string Double2HexRvs(double value)
        {
            byte[] b = BitConverter.GetBytes(value);

            var sb = new StringBuilder();
            for (int i = 0; i < b.Length; i++)
            {
                sb.Append(Convert.ToString(b[i], 16).PadLeft(2, '0') + " ");
            }

            return sb.ToString().ToUpper();
        }
        public static double Hex2Double(string value)
        {
            if (value.Length == 16)
            {
                var b = new byte[8];
                var ts = value.ToUpper();

                for (int i = 0; i < b.Length; i++)
                {
                    b[b.Length - i - 1] = (ts[i * 2].Char2Byte());
                    b[b.Length - i - 1]  = (byte)((b[b.Length - i - 1] << 4) | (ts[i * 2 + 1].Char2Byte()));
                }

                return BitConverter.ToDouble(b, 0);
            }

            return double.NaN;
        }

        public static double HexRvs2Double(string value)
        {
            if (value.Length == 16)
            {
                var b = new byte[8];
                var ts = value.ToUpper();

                for (int i = 0; i < b.Length; i++)
                {
                    b[i] = (ts[i * 2].Char2Byte());
                    b[i] = (byte)((b[b.Length - i - 1] << 4) | (ts[i * 2 + 1].Char2Byte()));
                }

                return BitConverter.ToDouble(b, 0);
            }

            return double.NaN;
        }

        public string StandString(string num)
        {
            double t = double.NaN;
            if (double.TryParse(num, out t))
            {
                byte[] b = BitConverter.GetBytes(t);

                var symbol = Convert.ToString(b[7], 2).PadLeft(8, '0');

                var exp = Convert.ToString(b[6], 2).PadLeft(8, '0');

                var frac =
                    Convert.ToString(b[5], 2).PadLeft(8, '0') + " " +
                    Convert.ToString(b[4], 2).PadLeft(8, '0') + " " +
                    Convert.ToString(b[3], 2).PadLeft(8, '0') + " " +
                    Convert.ToString(b[2], 2).PadLeft(8, '0') + " " +
                    Convert.ToString(b[1], 2).PadLeft(8, '0') + " " +
                    Convert.ToString(b[0], 2).PadLeft(8, '0');

                return  // 符号位s + 指数位e + 精度部分f
                    $"s:({symbol.Substring(0, 1)}) \r\n" +
                    $"e:({symbol.Substring(1,3)} {symbol.Substring(4)}{exp.Substring(0, 4)}) \r\n" +
                    $"f:({exp.Substring(4)} {frac})";
            }

            return null;
        }
    }
}
