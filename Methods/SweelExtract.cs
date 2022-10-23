using System.IO;
using System.Reflection;

namespace 客户管理系统
{
    /// <summary>
    /// 这是一个提取内嵌文件的类
    /// </summary>
    internal class SweelExtract
    {
        /// <summary>
        /// 这是一个提取内嵌文件的方法
        /// </summary>
        /// <param name="fn"></param>
        /// <param name="of"></param>
        internal static void Extract(string fn, string of)
        {
            BufferedStream bs = null;
            FileStream fs = null;
            try
            {
                Assembly a = Assembly.GetExecutingAssembly();
                bs = new BufferedStream(a.GetManifestResourceStream(fn));
                fs = new FileStream(of, FileMode.Create, FileAccess.Write);
                byte[] buffer = new byte[1024];
                int length;
                while ((length = bs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fs.Write(buffer, 0, length);
                }
                fs.Flush();
            }
            finally
            {
                if (fs != null)
                {
                    fs.Dispose();
                }
                if (bs != null)
                {
                    bs.Dispose();
                }
            }
        }
    }
}
