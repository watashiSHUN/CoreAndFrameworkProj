﻿using System;
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(".netframework");
        }
    }
}
