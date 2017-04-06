using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Model
{
    public class Validate
    {
        public Boolean text(string text)
        {
            Regex exceptions = new Regex(@"^[0-9]$");
            if (exceptions.IsMatch(text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public Boolean number(string text)
        {
            Regex exceptions = new Regex(@"^[a-zA-Z]$");
            if (exceptions.IsMatch(text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public Boolean textNumber(string texts)
        {

            return !number(texts) && !text(texts);

        }
    }
}
