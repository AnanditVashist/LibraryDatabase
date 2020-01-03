using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryDatabase.Infrastructure.Services;

namespace LibraryDatabase.Infrastructure.Utils
{
    public class ValidationUtil
    {
        public static bool IsInt(string value)
        {
            return int.TryParse(value, out int result);
        }
    }

}