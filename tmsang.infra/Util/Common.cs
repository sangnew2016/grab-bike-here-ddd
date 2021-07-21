using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tmsang.infra
{
    public static class Common
    {
        public static string ReplaceExtra(this string value, IEnumerable<Tuple<string, string>> toReplace)
        {
            var result = new StringBuilder(value);
            foreach (var item in toReplace)
            {
                result.Replace(item.Item1, item.Item2);
            }
            return result.ToString();
        }
    }
}
