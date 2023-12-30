using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleClinicWinForm.Global_Classes
{
    public static class clsValidation
    {
        public static bool ValidateEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
    }
}
