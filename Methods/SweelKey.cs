using System.Text;
using System.Text.RegularExpressions;

namespace 客户管理系统
{
    /// <summary>
    /// 这是SweelLong自制的加密算法，原理很简单，破译有难度
    /// </summary>
    internal class SweelKey
    {
        /// <summary>
        /// 加密算法
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        internal static string Encryption(string str)
        {
            char[] charbuffers = str.ToCharArray();
            byte[] buffer;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < charbuffers.Length; i++)
            {
                buffer = Encoding.Unicode.GetBytes(charbuffers[i].ToString());
                sb.Append(string.Format("\\u{0:X2}{1:X2}", buffer[1] + 1, buffer[0]));
            }
            return Regex.Unescape(sb.ToString());
        }
        /// <summary>
        /// 解密算法
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        internal static string Decryption(string str)
        {
            char[] charbuffers = str.ToCharArray();
            byte[] buffer;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < charbuffers.Length; i++)
            {
                buffer = Encoding.Unicode.GetBytes(charbuffers[i].ToString());
                sb.Append(string.Format("\\u{0:X2}{1:X2}", buffer[1] - 1, buffer[0]));
            }
            return Regex.Unescape(sb.ToString());
        }
    }
}
