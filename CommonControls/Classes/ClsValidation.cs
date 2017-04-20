using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CommonControls.Classes
{
    public class ClsValidation
    {
        private ClsMessages MESSAGE;

        public ClsValidation()
        {
            MESSAGE = new ClsMessages();
        }

        public bool isEmptyTextBox(string str)
        {
            bool ret = true;

            if (!String.IsNullOrEmpty(str))
            {
                ret = false;
            }
            return ret;
        }

        public bool isLetterOnly(string str)
        {
            string letterOnly = @"^[a-zA-Z]+$";

            bool ret = regexCheck(str, letterOnly);

            return ret;
        }

        public bool isNumberOnly(string number)
        {            
            string numberOnly = @"^[0-9]+$";

            bool ret = regexCheck(number, numberOnly);

            return ret;
        }

        public bool isLetterAndNumberOnly(string str)
        {
            string letterOrNumberOnly = @"^[A-Za-z0-9]+$";

            bool ret = regexCheck(str, letterOrNumberOnly);

            return ret;
        }

        public bool isEmail(string mail)
        {
            string mailReg = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

            bool ret = regexCheck(mail, mailReg);

            return ret;
        }

        public bool isSpecialChars(string chars)
        {
            //string charReg = @"[%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-\]";
            string charReg = @"[!#$%&'=~|\^\\\@\^`+*;:?\/,.\{\}\[\]\-]$";

            bool ret = regexCheck(chars, charReg);

            return ret;
        }

        private bool regexCheck(string str, string regx)
        {
            bool ret = true;

            try
            {
                if (!Regex.IsMatch(str, regx))
                {
                    ret = false;
                }
            }
            catch (Exception ex)
            {
                MESSAGE.exceptionMessage(ex.Message);
                ret = false;
            }
            return ret;
        }
    }
}
