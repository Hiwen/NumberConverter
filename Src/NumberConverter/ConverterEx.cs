using System.Text;

namespace NumberConverter
{
    public static class ConverterEx
    {

        /// <summary>
        /// 逆向16进制16进制
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static string RvsHexToHex(this IConverter conver, string hex)
        {
            var tt = hex.Replace(" ", "");

            if (tt?.Length > 0 && tt.Length % 2 == 0)
            {
                var res = new string(tt.ToCharArray());
                var len = tt.Length / 2;
                var sb = new StringBuilder();
                for (int i = len - 1; i >= 0; i--)
                {
                    sb.Append(tt[i * 2]);
                    sb.Append(tt[i * 2 + 1]);
                    sb.Append(' ');
                }

                return sb.ToString();
            }

            return null;
        }
        public static byte Char2Byte(this char ch)
        {
            if (ch >= '0' && ch <= '9')
            {
                return (byte)(ch - '0');
            }
            else if (ch >= 'A' && ch <= 'F')
            {
                return (byte)(ch - 'A' + 10);
            }

            return 0;
        }
    }
}
