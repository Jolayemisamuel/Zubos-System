using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zubos.System.Data
{
    public static class HelperMethods
    {
        public static string ToSafeString(this object obj)
        {
            return (obj ?? string.Empty).ToString();
        }
    }
}
