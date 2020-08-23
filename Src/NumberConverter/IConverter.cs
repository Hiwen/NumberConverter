using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConverter
{
    /// <summary>
    /// 数字进制转换接口
    /// </summary>
    public interface IConverter
    {
        /// <summary>
        /// 转换器名称
        /// </summary>
        string Name { get; }

        /// <summary>
        /// 输入10进制时的提示
        /// </summary>
        string DecTips { get; }

        /// <summary>
        /// 判断十进制数据是否合法
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        bool IsDecNumLegal(string num);

        /// <summary>
        /// 转16进制
        /// </summary>
        /// <returns></returns>
        string DecToHex(string num);

        /// <summary>
        /// 逆向转16进制
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        string DecToHexRvs(string num);

        /// <summary>
        /// 转10进制
        /// </summary>
        /// <returns></returns>
        string HexToDec(string num);

        /// <summary>
        /// 逆向16进制转10进制
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        string RvsHexToDec(string num);

        /// <summary>
        /// 标准名称
        /// </summary>
        string StandName { get; }

        /// <summary>
        /// 10进制转2进制标准储存
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        string StandString(string num);
    }
}
