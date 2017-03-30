using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netframeworkLib
{
    public class Class1
    {
        public static string returnStr()
        {
            setStr(out string nuget)
            return Newtonsoft.Json.JsonConvert.SerializeObject(nuget);

        }

        private static void setStr(out string nuget)
        {
            nuget = ".net framework lib is successful";
        }
    }
}
