using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Common
{
    public class DataValidate
    {
        public static bool IsEmail(string emailaddress)
        {
            Regex r = new Regex("^\\s*([A-Za-z0-9_-]+(\\.\\w+)*@(\\w+\\.)+\\w{2,5})\\s*$");

            if (r.IsMatch(emailaddress))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsChines(string str)
        {
            Regex r = new Regex("[\u4e00-\u9fa5]");

            if (r.IsMatch(str))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsEnglish(string str)
        {
            Regex r = new Regex("^[A-Za-z]+$");

            if (r.IsMatch(str))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
