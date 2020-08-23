using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConverter.Converters
{
    public class Int64Converter : IConverter
    {
        public string Name => "整数转换";

        public string DecTips => "请输入整数，如 314";

        public string StandName => "二进制";

        public bool IsDecNumLegal(string num)
        {
            Int64 t;
            return Int64.TryParse(num, out t);
        }

        public string DecToHex(string num)
        {
            Int64 t = 0;
            if (Int64.TryParse(num, out t))
            {
                return Int2Hex(t);
            }

            return null;
        }

        public string DecToHexRvs(string num)
        {
            Int64 t = 0;
            if (Int64.TryParse(num, out t))
            {
                return Int2HexRvs(t);
            }

            return null;
        }

        public string HexToDec(string num)
        {
            var copy = num.Replace(" ", "");
            return $"{Hex2Int(copy)}";
        }

        public string RvsHexToDec(string num)
        {
            var copy = num.Replace(" ", "");
            return $"{HexRvs2Int(copy)}";
        }

        public static string Int2Hex(Int64 value)
        {
            byte[] b = BitConverter.GetBytes(value);
            var sb = new StringBuilder();
            for (int i = b.Length - 1; i >= 0; i--)
            {
                sb.Append(Convert.ToString(b[i], 16).PadLeft(2, '0') + " ");
            }

            return sb.ToString().ToUpper();
        }

        public static string Int2HexRvs(Int64 value)
        {
            byte[] b = BitConverter.GetBytes(value);

            var sb = new StringBuilder();
            for (int i = 0; i < b.Length; i++)
            {
                sb.Append(Convert.ToString(b[i], 16).PadLeft(2, '0') + " ");
            }

            return sb.ToString().ToUpper();
        }
        public static Int64 Hex2Int(string value)
        {
            if (value.Length == 16)
            {
                var b = new byte[8];
                var ts = value.ToUpper();

                for (int i = 0; i < b.Length; i++)
                {
                    b[b.Length - i - 1] = (ts[i * 2].Char2Byte());
                    b[b.Length - i - 1] = (byte)((b[b.Length - i - 1] << 4) | (ts[i * 2 + 1].Char2Byte()));
                }

                return BitConverter.ToInt64(b, 0);
            }

            return 0;
        }


        public static Int64 HexRvs2Int(string value)
        {
            if (value.Length == 16)
            {
                var b = new byte[8];
                var ts = value.ToUpper();

                for (int i = 0; i < ts.Length; i++)
                {
                    b[i] = (ts[i * 2].Char2Byte());
                    b[i] = (byte)((b[ts.Length - i - 1] << 4) | (ts[i * 2 + 1].Char2Byte()));
                }

                return BitConverter.ToInt64(b, 0);
            }

            return 0;
        }

        public string StandString(string num)
        {
            Int64 t = 0;
            if (Int64.TryParse(num, out t))
            {
                byte[] b = BitConverter.GetBytes(t);

                var sb = new StringBuilder();
                for (int i = b.Length - 1; i >= 0; i--)
                {
                    sb.Append(Convert.ToString(b[i], 2).PadLeft(8, '0') + " ");
                    if (sb.Length == 36)
                    {
                        sb.Append("\r\n");
                    }
                }

                return sb.ToString();
            }

            return null;
        }
    }
}
