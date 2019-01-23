using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacPractice1.BL.CompanyParsers
{
    public class CompanyParser
    {
        public virtual string Parse(string userName)
        {
            return System.Text.RegularExpressions.Regex.Match(userName, @"\(.\)").Value;
        }
    }
}
