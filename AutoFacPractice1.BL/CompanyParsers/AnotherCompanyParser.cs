using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacPractice1.BL.CompanyParsers
{
    public class AnotherCompanyParser : CompanyParser
    {
        public override string Parse(string userName)
        {
            string r = "";
            if (userName.Length > 3) r = userName.Substring(userName.Length - 3, 1);
            return r;
        }
    }
}
