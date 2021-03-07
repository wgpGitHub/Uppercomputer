using System;
using System.Collections.Generic;
using System.Text;

namespace UpperStartup
{
    static public class Service
    {
        static public string 截取字符串(string 总字符串,string 前字符串,string 后字符串)
        {
            int 开始位置 = 0, 结束位置 = 0;
            开始位置 = 总字符串.IndexOf(前字符串, 0) + 前字符串.Length;
            结束位置 = 总字符串.IndexOf(后字符串, 开始位置);
            return 总字符串.Substring(开始位置, 结束位置 - 开始位置);
        }
    }
}
