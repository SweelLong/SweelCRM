using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace 客户管理系统
{
    /// <summary>
    /// 此类为读写Json字符串类
    /// 注明了读写方法
    /// 前置插件Newtonsoft.Json.dll
    /// Copyright © SweelLong
    /// </summary>
    internal class SweelConfig
    {
        /// <summary>
        /// 用于读取配置文件 用法：👇
        /// SweelConfig.Read("Json文件的对象名");
        /// {
        /// "对象名":参数 //在json文件中
        /// }
        /// </summary>
        /// <param name="keywords"></param>
        /// <returns></returns>
        internal static dynamic Read(string keywords)
        {
            StreamReader sr = File.OpenText(Start.MyDataPath+"\\config.json");
            JsonTextReader jtr = new JsonTextReader(sr);
            JObject jo = (JObject)JToken.ReadFrom(jtr);
            dynamic value = (dynamic)jo[keywords];
            sr.Dispose();
            return value;
        }

        /// <summary>
        /// 用于写入配置文件 用法：👇
        /// SweelConfig.Write("Json文件的对象名", 新参数);
        /// {
        /// "对象名":旧参数 //在json文件中
        /// }
        /// </summary>
        /// <param name="keywords"></param>
        /// <param name="newVaelue"></param>
        internal static void Write(string keywords, dynamic newVaelue)
        {
            string str = File.ReadAllText(Start.MyDataPath+"\\config.json");
            dynamic jo = JsonConvert.DeserializeObject(str);
            jo[keywords] = newVaelue;
            File.WriteAllText(Start.MyDataPath+"\\config.json", JsonConvert.SerializeObject(jo, Formatting.Indented));
        }
    }
}
