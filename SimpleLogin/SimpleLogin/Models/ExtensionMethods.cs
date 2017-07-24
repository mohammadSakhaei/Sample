using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleLogin.Models
{
    public static class ExtensionMethods
    {
        public static int ToInt(this object input)
        {
            int value;
            if (Int32.TryParse(input.ToString(), out value))
            {
                return value;
            }
            return 0;
        }

        public static long ToLong(this object input)
        {
            long value;
            if (long.TryParse(input.ToString(), out value))
            {
                return value;
            }
            return 0;
        }

        public static float ToFloat(this object input)
        {
            float value;
            if (float.TryParse(input.ToString(), out value))
            {
                return value;
            }
            return 0;
        }

        public static bool ToBool(this object input)
        {
            bool value;
            if (bool.TryParse(input.ToString(),out value))
            {
                return value;
            }
            return false;
        }
    }
}
