using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConverter.Converters
{
    public class FloatConverter : IConverter
    {
        public string Name => "单精度浮点数转换";

        public string DecTips => "请输入单精度的浮点数，如 3.14";

        public string StandName => "IEEE 754";

        public bool IsDecNumLegal(string num)
        {
            float t;
            return float.TryParse(num, out t);
        }

        public string DecToHex(string num)
        {
            float t = float.NaN;
            if (float.TryParse(num, out t))
            {
                return Float2Hex(t);
            }

            return null;
        }

        public string DecToHexRvs(string num)
        {
            float t = float.NaN;
            if (float.TryParse(num, out t))
            {
                return Float2HexRvs(t);
            }

            return null;
        }

        public string HexToDec(string num)
        {
            var copy = num.Replace(" ", "");
            return $"{Hex2Float(copy)}";
        }

        public string RvsHexToDec(string num)
        {
            var copy = num.Replace(" ", "");
            return $"{HexRvs2Float(copy)}";
        }

        public static string Float2Hex(float value)
        {
            byte[] b = BitConverter.GetBytes(value);
            var Text =
                Convert.ToString(b[3], 16).PadLeft(2, '0') + " " +
                Convert.ToString(b[2], 16).PadLeft(2, '0') + " " +
                Convert.ToString(b[1], 16).PadLeft(2, '0') + " " +
                Convert.ToString(b[0], 16).PadLeft(2, '0');

            return Text.ToUpper();
        }

        public static string Float2HexRvs(float value)
        {
            byte[] b = BitConverter.GetBytes(value);
            var Text =
                Convert.ToString(b[0], 16).PadLeft(2, '0') + " " +
                Convert.ToString(b[1], 16).PadLeft(2, '0') + " " +
                Convert.ToString(b[2], 16).PadLeft(2, '0') + " " +
                Convert.ToString(b[3], 16).PadLeft(2, '0');

            return Text.ToUpper();
        }
        public static float Hex2Float(string value)
        {
            if (value.Length == 8)
            {
                var b = new byte[4];
                var ts = value.ToUpper();

                for (int i = 0; i < b.Length; i++)
                {
                    b[b.Length - i - 1] = (ts[i * 2].Char2Byte());
                    b[b.Length - i - 1] = (byte)((b[b.Length - i - 1] << 4) | (ts[i * 2 + 1].Char2Byte()));
                }

                return BitConverter.ToSingle(b, 0);
            }

            return float.NaN;
        }


        public static float HexRvs2Float(string value)
        {
            if (value.Length == 8)
            {
                var b = new byte[4];
                var ts = value.ToUpper();

                for (int i = 0; i < ts.Length; i++)
                {
                    b[i] = (ts[i * 2].Char2Byte());
                    b[i] = (byte)((b[ts.Length - i - 1] << 4) | (ts[i * 2 + 1].Char2Byte()));
                }

                return BitConverter.ToSingle(b, 0);
            }

            return float.NaN;
        }

        public string StandString(string num)
        {
            float t = float.NaN;
            if (float.TryParse(num, out t))
            {
                byte[] b = BitConverter.GetBytes(t);

                var symbol = Convert.ToString(b[3], 2).PadLeft(8, '0');

                var exp = Convert.ToString(b[2], 2).PadLeft(8, '0');

                var frac =
                    Convert.ToString(b[1], 2).PadLeft(8, '0') + " " +
                    Convert.ToString(b[0], 2).PadLeft(8, '0');

                return  // 符号位s + 指数位e + 精度部分f
                    $"s:({symbol.Substring(0, 1)}) \r\n" +
                    $"e:({symbol.Substring(1)}{exp.Substring(0, 1)}) \r\n" +
                    $"f:({exp.Substring(1)} {frac})";
            }

            return null;
        }
    }
}
